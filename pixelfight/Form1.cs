using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework;
using System.Diagnostics;
using System.Runtime.InteropServices;
//imports


//Begin namespace
namespace pixelfight
{
    /*
     * Count of pixel colours
     * colour saturation based on pixel count
     * colour selectors
     * stop button
     */


    //Begin partial
    public partial class FightingPixels : MetroFramework.Forms.MetroForm //Partial extends Metro framework - MetroForm
    {
        //Varibles
        private static Boolean[,] pixels;
        public static Color color1 = Color.Turquoise;
        public static Color color2 = Color.Aquamarine;
        public int left = 0;
        public int right = 0;


        //Instantiator
        public FightingPixels()
        {
            //Populate components
            InitializeComponent();
            pixels = new Boolean[pictureBox1.Width + 1, pictureBox1.Height + 1];


            //Set application theme
            setTheme();

            //Populate array
            populateArray();

          

            //Draw first frame
            DrawFrame(false, 0, 0);

            SetValues(); //reset for alpha, alpha requires existing frame.

            DrawFrame(false, 0, 0);

            changeTheme(Properties.Settings.Default.DarkTheme);

 
            
        }


        //Initialisers + passive
        private void populateArray()
        {
            int halfway = metroTrackBar1.Value;

            for (int width = 0; width < halfway; width++)
            {
                for (int height = 0; height < pictureBox1.Height; height++)
                {
                    pixels[width, height] = false;
                }
            }

            for (int width = halfway + 1; width < pictureBox1.Width; width++)
            {
                for (int height = 0; height < pictureBox1.Height; height++)
                {
                    pixels[width, height] = true;
                }
            }

        }

        private void setTheme()
        {
            this.Theme = getTheme();
        }

        private static MetroFramework.MetroThemeStyle getTheme()
        {
            MetroThemeStyle theme = MetroThemeStyle.Default;

            if (Properties.Settings.Default.DarkTheme)
            {
                theme = MetroThemeStyle.Dark;
            }
            else
            {
                theme = MetroThemeStyle.Light;
            }

            return theme;
        }

        private void pictureBox1_Click(object sender, MouseEventArgs ev)
        {

            if (FrameRun)
            {
                
                for (int x = 0; x <= TBBomb.Value; x++)
                {
                    for (int i = 0; i <= TBBomb.Value; i++)
                    {
                        try
                        {
                            pixels[ev.Location.X + x, ev.Location.Y + i] = !pixels[ev.Location.X + x, ev.Location.Y + i];
                        } catch (Exception ex){}
                    }
                }
                

            }
            
            else
            {
              populateArray();
              run();
            }

        }



        //Active
        private void DrawFrame(bool throughput, int x, int y)
        {
            try
            {
                Bitmap frame = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Color pixelcolor = Color.Pink;
                string rightalpha = txtRightPercent.Text.Remove(txtRightPercent.Text.Length - 2);
                rightalpha += brightness.Value;
                if (int.Parse(rightalpha) > 255) { rightalpha = "255"; }
  

            string leftalpha = txtLeftPercent.Text.Remove(txtLeftPercent.Text.Length - 2);
            leftalpha += brightness.Value;
            if (int.Parse(leftalpha) > 255) { leftalpha = "255"; }

            left = 0;
            right = 0;
            if (!TGIntensity.Checked)
            {
                leftalpha = "255";
                rightalpha = "255";
            }

            for (int width = 0; width < pictureBox1.Width; width++)
            {
                for (int Height = 0; Height < pictureBox1.Height ; Height++)
                { 
                    pixelcolor = Color.Pink;
                    if (pixels[width, Height])
                    {
                        pixelcolor = Color.FromArgb(int.Parse(leftalpha), color1.R, color1.G, color1.B);
                        left++;
                    }
                    else
                    {
                        pixelcolor = Color.FromArgb(int.Parse(rightalpha), color2.R, color2.G, color2.B);
                        right++;
                    }

                    frame.SetPixel(width, Height, pixelcolor);
                }
                if (FrameRun)
                {
                  //  updateTimeRemaining(false);
                }


            }

            pictureBox1.Image = frame;
            SetValues();
            }
            catch
            {

            }


       
        }

        //private static long timesincelastframe, timeoflastframe;
        //private static int startpercent = 50;
        //private void updateTimeRemaining(bool reset)
        //{
        //    if (reset)
        //    {
        //        timeoflastframe = DateTime.UtcNow.Millisecond;
        //        timesincelastframe = 0;
        //    }

        //    timesincelastframe = DateTime.UtcNow.Millisecond - timeoflastframe;
        //    timeoflastframe = DateTime.UtcNow.Millisecond;    
        //    string currentpercent = txtLeftPercent.Text.Remove(txtLeftPercent.Text.Length - 2);
        //    long timeremaining = timesincelastframe * (startpercent - int.Parse(currentpercent));
        //    txtETA.Text = timeremaining.ToString();
        //    Application.DoEvents();


        //}

        private void SetValues() {

                    int total = (left + right); 
                   
                    double increment = 100 / Convert.ToDouble(total);
                    double secincrement = 314 / Convert.ToDouble(total);

                    txtLeftPercent.Text = Convert.ToString(Math.Round(increment * Convert.ToDouble(left))) + " %";
                    txtRightPercent.Text = Convert.ToString(Math.Round(increment * Convert.ToDouble(right))) + " %";
                    txtLeft.Text = Convert.ToString(left) + " Pixels";
                    txtRight.Text = Convert.ToString(right) + " Pixels";
                    metroTrackBar1.Value = Convert.ToInt32(Math.Round(secincrement * Convert.ToDouble(right)));


                    if (left == 0 || right == 0)
                    {
                        FrameRun = false;
                        if (left == 0) { MessageBox.Show("Left won!"); }
                        if (right == 0) { MessageBox.Show("Right won!"); }
                        populateArray();
                        DrawFrame(false, 0, 0);
                    }
                    }





        Boolean FrameRun = false;
        private void run()
        {
            FrameRun = true;
            CurrentFrameRule = 0;
            Random rnd;
            if (TGSeed.Checked)
            {
                 rnd = new Random(DateTime.UtcNow.Second);
            }
            else
            {
                try
                {
                    rnd = new Random(int.Parse(Seed.Text));
                }
                catch
                {
                    MessageBox.Show("Custom seed was not valid, using a time based one.");
                    TGSeed.Checked = false;
                    Seed.Text = "12345";
                    rnd = new Random(DateTime.UtcNow.Second);
                }

            }
            if (!TGShowProcessing.Checked)
            {

            
            while (FrameRun)
            {
                for (int width = 0; width < pictureBox1.Width - 1; width++)
                {

                    for (int Height = 0; Height < pictureBox1.Height - 1; Height++)
                    {
                        int nextx = 0;
                        int nexty = 0;
                        //width = current x
                        //height = current y
                        // x, y = current pixel

                        //randomly choose pixel above or below


                        if (rnd.Next(10) > 5)
                        {
                            nextx = width + 1;
                        }
                        else
                        {
                            nextx = width - 1;
                        }


                        //randomly choose pixel left or right
                        if (rnd.Next(10) > 5)
                        {
                            nexty = Height + 1;
                        }
                        else
                        {
                            nexty = Height - 1;
                        }

                        //TODO add boundy detection.
                        if (nextx < 0) { nextx = 0; }
                        if (nextx > pictureBox1.Width) { nexty = pictureBox1.Width; }
                        if (nexty < 0) { nexty = 0; }
                        if (nexty > pictureBox1.Height) { nexty = pictureBox1.Height; }

                        pixels[nextx, nexty] = pixels[width, Height];
                    }
                }
                


                if (TGFrameSkip.Checked) {
                          if (CurrentFrameRule == FrameSkip)
                            {
                                DrawFrame(false, 0, 0);
                                CurrentFrameRule = 0;
                            }
                            else
                            {
                                CurrentFrameRule++;
                            }
                } else {
                    DrawFrame(false, 0, 0);
                }




                Application.DoEvents();
            }
        }else {
                 while (FrameRun)
            {
            DrawFrame(true, 0, 0);
            Bitmap imagebuffer = (Bitmap) pictureBox1.Image;


            for (int width = 0; width < pictureBox1.Width - 1; width++)
            {
                for (int Height = 0; Height < pictureBox1.Height - 1; Height++)
                {
                    int nextx = 0;
                    int nexty = 0;
                    //width = current x
                    //height = current y
                    // x, y = current pixel

                    //randomly choose pixel above or below
                    if (rnd.Next(10) > 5)
                    {
                        nextx = width + 1;
                    }
                    else
                    {
                        nextx = width - 1;
                    }


                    //randomly choose pixel left or right
                    if (rnd.Next(10) > 5)
                    {
                        nexty = Height + 1;
                    }
                    else
                    {
                        nexty = Height - 1;
                    }




                    if (nextx < 0) { nextx = 0; }
                    if (nextx > pictureBox1.Width) { nexty = pictureBox1.Width; }
                    if (nexty < 0) { nexty = 0; }
                    if (nexty > pictureBox1.Height) { nexty = pictureBox1.Height; }

                    Bitmap image = imagebuffer;
                    image.SetPixel(width, Height, Color.Red);
                    image.SetPixel(nextx, nexty, Color.Blue);

                    drawExactFrame(image);
                    pixels[nextx, nexty] = pixels[width, Height];

                    Application.DoEvents();
                    if (!FrameRun) { return; }
                }

                }
            DrawFrame(false,0, 0);
            SetValues();
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            }

    }}


        private void drawExactFrame(Bitmap Image)
        {
            pictureBox1.Image = Image;
        }

        private void MidpointChanged(object sender, EventArgs e)
        {
            FrameRun = false;
            populateArray();
            DrawFrame(false, 0, 0);
        }



        public static int FrameSkip = 0, CurrentFrameRule = 0;
        private void TBFrameSkip_Scroll(object sender, ScrollEventArgs e)
        {
            lblFrameSkip.Text = TBFrameSkip.Value.ToString();
            FrameSkip = TBFrameSkip.Value;
        }

        private void TBSeed(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(Seed.Text);
            } catch {
                Seed.Text = "12345";
            }

        }

        private void RadBright_CheckedChanged(object sender, EventArgs e)
        {
            changeTheme(false);
        }

        private void RadDark_CheckedChanged(object sender, EventArgs e)
        {
            changeTheme(true);
        }


        private void changeTheme(Boolean dark)
        {
            Properties.Settings.Default.DarkTheme = dark;
            if (dark) 
            {
                this.Theme = MetroThemeStyle.Dark;
                Display.Theme = MetroThemeStyle.Dark;
                metroTrackBar1.Theme = MetroThemeStyle.Dark;
                metroLabel1.Theme = MetroThemeStyle.Dark;
                metroLabel2.Theme = MetroThemeStyle.Dark;
                metroLabel3.Theme = MetroThemeStyle.Dark;
                metroLabel4.Theme = MetroThemeStyle.Dark;
                metroLabel5.Theme = MetroThemeStyle.Dark;
                metroLabel6.Theme = MetroThemeStyle.Dark;
                metroTabPage1.Theme = MetroThemeStyle.Dark;
                metroTabPage2.Theme = MetroThemeStyle.Dark;
                txtLeft.Theme = MetroThemeStyle.Dark;
                txtRight.Theme = MetroThemeStyle.Dark;
                txtLeftPercent.Theme = MetroThemeStyle.Dark;
                txtRightPercent.Theme = MetroThemeStyle.Dark;
                RadBright.Theme = MetroThemeStyle.Dark;
                RadDark.Theme = MetroThemeStyle.Dark;
                TGFrameSkip.Theme = MetroThemeStyle.Dark;
                TGSeed.Theme = MetroThemeStyle.Dark;
                TBFrameSkip.Theme = MetroThemeStyle.Dark;
                Seed.Theme = MetroThemeStyle.Dark;
                lblFrameSkip.Theme = MetroThemeStyle.Dark;
                metroLabel7.Theme = MetroThemeStyle.Dark;
                metroLabel8.Theme = MetroThemeStyle.Dark;
                brightness.Theme = MetroThemeStyle.Dark;
                TGIntensity.Theme = MetroThemeStyle.Dark;

            }
            else
            {
                this.Theme = MetroThemeStyle.Light;
                Display.Theme = MetroThemeStyle.Light;
                metroTrackBar1.Theme = MetroThemeStyle.Light;
                metroLabel1.Theme = MetroThemeStyle.Light;
                metroLabel2.Theme = MetroThemeStyle.Light;
                metroLabel3.Theme = MetroThemeStyle.Light;
                metroLabel4.Theme = MetroThemeStyle.Light;
                metroLabel5.Theme = MetroThemeStyle.Light;
                metroLabel6.Theme = MetroThemeStyle.Light;
                metroTabPage1.Theme = MetroThemeStyle.Light;
                metroTabPage2.Theme = MetroThemeStyle.Light;
                txtLeft.Theme = MetroThemeStyle.Light;
                txtRight.Theme = MetroThemeStyle.Light;
                txtLeftPercent.Theme = MetroThemeStyle.Light;
                txtRightPercent.Theme = MetroThemeStyle.Light;
                RadBright.Theme = MetroThemeStyle.Light;
                RadDark.Theme = MetroThemeStyle.Light;
                TGFrameSkip.Theme = MetroThemeStyle.Light;
                TGSeed.Theme = MetroThemeStyle.Light;
                TBFrameSkip.Theme = MetroThemeStyle.Light;
                Seed.Theme = MetroThemeStyle.Light;
                lblFrameSkip.Theme = MetroThemeStyle.Light;
                metroLabel7.Theme = MetroThemeStyle.Light;
                metroLabel8.Theme = MetroThemeStyle.Light;
                brightness.Theme = MetroThemeStyle.Light;
                TGIntensity.Theme = MetroThemeStyle.Light;
            }
            this.Hide();
            this.Show();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = metroTile1.BackColor;
            colorDialog1.ShowDialog();
            color2 = colorDialog1.Color;
            metroTile1.BackColor = colorDialog1.Color;

            FrameRun = false;
            populateArray();
            DrawFrame(false, 0, 0);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = metroTile2.BackColor;
            colorDialog1.ShowDialog();
            color1 = colorDialog1.Color;
            metroTile2.BackColor = colorDialog1.Color;

            FrameRun = false;
            populateArray();
            DrawFrame(false, 0, 0);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = metroTile2.BackColor;
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
            metroTile3.BackColor = colorDialog1.Color;

            FrameRun = false;
            populateArray();
            DrawFrame(false, 0, 0);
        }

        private void TGIntensity_CheckedChanged(object sender, EventArgs e)
        {
            DrawFrame(false, 0, 0);
        }

        private void youreAMinorInconvenienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 20");
            MessageBox.Show("Hopefully you'll learn your lesson.");
            Application.Exit();
        }

        private void bdl(object sender, MouseEventArgs e)
        {
            metroContextMenu1.Show();
        }

        private void dbl(object sender, EventArgs e)
        {
            metroContextMenu1.Show();
        }



        private void TGShowProcessing_CheckedChanged(object sender, EventArgs e)
        {
            FrameRun = false;
        }


        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            FrameRun = false;
            
        }

        private void MidpointChanged(object sender, MouseEventArgs e)
        {

        }



    }
}
