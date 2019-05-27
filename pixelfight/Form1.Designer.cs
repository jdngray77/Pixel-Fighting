namespace pixelfight
{
    partial class FightingPixels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Display = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtRightPercent = new MetroFramework.Controls.MetroLabel();
            this.txtLeftPercent = new MetroFramework.Controls.MetroLabel();
            this.txtRight = new MetroFramework.Controls.MetroLabel();
            this.txtLeft = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TBBomb = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.TGShowProcessing = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.brightness = new MetroFramework.Controls.MetroTrackBar();
            this.TGIntensity = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Seed = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TGSeed = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblFrameSkip = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TBFrameSkip = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TGFrameSkip = new MetroFramework.Controls.MetroToggle();
            this.RadDark = new MetroFramework.Controls.MetroRadioButton();
            this.RadBright = new MetroFramework.Controls.MetroRadioButton();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.youreAMinorInconvenienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Display.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Controls.Add(this.metroTabPage1);
            this.Display.Controls.Add(this.metroTabPage2);
            this.Display.Location = new System.Drawing.Point(12, 63);
            this.Display.Name = "Display";
            this.Display.SelectedIndex = 0;
            this.Display.Size = new System.Drawing.Size(330, 475);
            this.Display.TabIndex = 1;
            this.Display.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtRightPercent);
            this.metroTabPage1.Controls.Add(this.txtLeftPercent);
            this.metroTabPage1.Controls.Add(this.txtRight);
            this.metroTabPage1.Controls.Add(this.txtLeft);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroTrackBar1);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(322, 433);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Display";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtRightPercent
            // 
            this.txtRightPercent.AutoSize = true;
            this.txtRightPercent.Location = new System.Drawing.Point(53, 44);
            this.txtRightPercent.Name = "txtRightPercent";
            this.txtRightPercent.Size = new System.Drawing.Size(31, 19);
            this.txtRightPercent.TabIndex = 11;
            this.txtRightPercent.Text = "0 %";
            // 
            // txtLeftPercent
            // 
            this.txtLeftPercent.AutoSize = true;
            this.txtLeftPercent.Location = new System.Drawing.Point(44, 15);
            this.txtLeftPercent.Name = "txtLeftPercent";
            this.txtLeftPercent.Size = new System.Drawing.Size(31, 19);
            this.txtLeftPercent.TabIndex = 10;
            this.txtLeftPercent.Text = "0 %";
            // 
            // txtRight
            // 
            this.txtRight.AutoSize = true;
            this.txtRight.Location = new System.Drawing.Point(90, 44);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(16, 19);
            this.txtRight.TabIndex = 9;
            this.txtRight.Text = "0";
            // 
            // txtLeft
            // 
            this.txtLeft.AutoSize = true;
            this.txtLeft.Location = new System.Drawing.Point(90, 15);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(16, 19);
            this.txtLeft.TabIndex = 8;
            this.txtLeft.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Right:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Left:";
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(5, 66);
            this.metroTrackBar1.Maximum = 314;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(314, 23);
            this.metroTrackBar1.TabIndex = 5;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroToolTip1.SetToolTip(this.metroTrackBar1, "Halfway definition of colours");
            this.metroTrackBar1.Value = 157;
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            this.metroTrackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MidpointChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(5, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 335);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox1, "display of pixels fighting\r\n\r\nClick to start or add pixels\r\n");
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.TBBomb);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.TGShowProcessing);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroTile3);
            this.metroTabPage2.Controls.Add(this.brightness);
            this.metroTabPage2.Controls.Add(this.TGIntensity);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroTile2);
            this.metroTabPage2.Controls.Add(this.metroTile1);
            this.metroTabPage2.Controls.Add(this.Seed);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.TGSeed);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.lblFrameSkip);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.TBFrameSkip);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.TGFrameSkip);
            this.metroTabPage2.Controls.Add(this.RadDark);
            this.metroTabPage2.Controls.Add(this.RadBright);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(322, 433);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Preferences";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 386);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Bomb size";
            // 
            // TBBomb
            // 
            this.TBBomb.BackColor = System.Drawing.Color.Transparent;
            this.TBBomb.Location = new System.Drawing.Point(86, 386);
            this.TBBomb.Name = "TBBomb";
            this.TBBomb.Size = new System.Drawing.Size(90, 23);
            this.TBBomb.TabIndex = 22;
            this.TBBomb.Text = "metroTrackBar2";
            this.metroToolTip1.SetToolTip(this.TBBomb, "Halfway definition of colours");
            this.TBBomb.Value = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(6, 364);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(183, 19);
            this.metroLabel12.TabIndex = 21;
            this.metroLabel12.Text = "Go slow and show processing;";
            // 
            // TGShowProcessing
            // 
            this.TGShowProcessing.AutoSize = true;
            this.TGShowProcessing.Location = new System.Drawing.Point(195, 367);
            this.TGShowProcessing.Name = "TGShowProcessing";
            this.TGShowProcessing.Size = new System.Drawing.Size(80, 17);
            this.TGShowProcessing.TabIndex = 20;
            this.TGShowProcessing.Text = "Off";
            this.TGShowProcessing.UseSelectable = true;
            this.TGShowProcessing.CheckedChanged += new System.EventHandler(this.TGShowProcessing_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(7, 338);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Min intensity";
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.Red;
            this.metroTile3.Location = new System.Drawing.Point(215, 219);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(98, 90);
            this.metroTile3.TabIndex = 18;
            this.metroTile3.Text = "Back Colour";
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // brightness
            // 
            this.brightness.BackColor = System.Drawing.Color.Transparent;
            this.brightness.Location = new System.Drawing.Point(111, 338);
            this.brightness.Maximum = 30;
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(98, 23);
            this.brightness.TabIndex = 17;
            this.brightness.Text = "metroTrackBar2";
            this.brightness.Value = 5;
            // 
            // TGIntensity
            // 
            this.TGIntensity.AutoSize = true;
            this.TGIntensity.Checked = true;
            this.TGIntensity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TGIntensity.Location = new System.Drawing.Point(111, 315);
            this.TGIntensity.Name = "TGIntensity";
            this.TGIntensity.Size = new System.Drawing.Size(80, 17);
            this.TGIntensity.TabIndex = 16;
            this.TGIntensity.Text = "On";
            this.TGIntensity.UseSelectable = true;
            this.TGIntensity.CheckedChanged += new System.EventHandler(this.TGIntensity_CheckedChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(7, 312);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Intensity";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.Aquamarine;
            this.metroTile2.Location = new System.Drawing.Point(111, 219);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(98, 90);
            this.metroTile2.TabIndex = 14;
            this.metroTile2.Text = "Right Colour";
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Turquoise;
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(7, 219);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(98, 90);
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Left Colour";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Seed
            // 
            // 
            // 
            // 
            this.Seed.CustomButton.Image = null;
            this.Seed.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.Seed.CustomButton.Name = "";
            this.Seed.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Seed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Seed.CustomButton.TabIndex = 1;
            this.Seed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Seed.CustomButton.UseSelectable = true;
            this.Seed.CustomButton.Visible = false;
            this.Seed.Lines = new string[] {
        "12345"};
            this.Seed.Location = new System.Drawing.Point(109, 185);
            this.Seed.MaxLength = 32767;
            this.Seed.Name = "Seed";
            this.Seed.PasswordChar = '\0';
            this.Seed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Seed.SelectedText = "";
            this.Seed.SelectionLength = 0;
            this.Seed.SelectionStart = 0;
            this.Seed.ShortcutsEnabled = true;
            this.Seed.Size = new System.Drawing.Size(91, 23);
            this.Seed.TabIndex = 12;
            this.Seed.Text = "12345";
            this.Seed.UseSelectable = true;
            this.Seed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Seed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Seed.Click += new System.EventHandler(this.TBSeed);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 185);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Custom Seed:";
            // 
            // TGSeed
            // 
            this.TGSeed.AutoSize = true;
            this.TGSeed.Checked = true;
            this.TGSeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TGSeed.Location = new System.Drawing.Point(109, 159);
            this.TGSeed.Name = "TGSeed";
            this.TGSeed.Size = new System.Drawing.Size(80, 17);
            this.TGSeed.TabIndex = 10;
            this.TGSeed.Text = "On";
            this.TGSeed.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 157);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Use Time Seed";
            // 
            // lblFrameSkip
            // 
            this.lblFrameSkip.AutoSize = true;
            this.lblFrameSkip.Location = new System.Drawing.Point(184, 99);
            this.lblFrameSkip.Name = "lblFrameSkip";
            this.lblFrameSkip.Size = new System.Drawing.Size(16, 19);
            this.lblFrameSkip.TabIndex = 8;
            this.lblFrameSkip.Text = "5";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 99);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Skip #";
            // 
            // TBFrameSkip
            // 
            this.TBFrameSkip.BackColor = System.Drawing.Color.Transparent;
            this.TBFrameSkip.Location = new System.Drawing.Point(93, 99);
            this.TBFrameSkip.Name = "TBFrameSkip";
            this.TBFrameSkip.Size = new System.Drawing.Size(75, 23);
            this.TBFrameSkip.TabIndex = 6;
            this.TBFrameSkip.Text = "metroTrackBar2";
            this.TBFrameSkip.Value = 5;
            this.TBFrameSkip.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TBFrameSkip_Scroll);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Frame Skip";
            // 
            // TGFrameSkip
            // 
            this.TGFrameSkip.AutoSize = true;
            this.TGFrameSkip.Checked = true;
            this.TGFrameSkip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TGFrameSkip.Location = new System.Drawing.Point(88, 76);
            this.TGFrameSkip.Name = "TGFrameSkip";
            this.TGFrameSkip.Size = new System.Drawing.Size(80, 17);
            this.TGFrameSkip.TabIndex = 4;
            this.TGFrameSkip.Text = "On";
            this.TGFrameSkip.UseSelectable = true;
            // 
            // RadDark
            // 
            this.RadDark.AutoSize = true;
            this.RadDark.Location = new System.Drawing.Point(7, 36);
            this.RadDark.Name = "RadDark";
            this.RadDark.Size = new System.Drawing.Size(47, 15);
            this.RadDark.TabIndex = 3;
            this.RadDark.Text = "Dark";
            this.RadDark.UseSelectable = true;
            this.RadDark.CheckedChanged += new System.EventHandler(this.RadDark_CheckedChanged);
            // 
            // RadBright
            // 
            this.RadBright.AutoSize = true;
            this.RadBright.Checked = true;
            this.RadBright.Location = new System.Drawing.Point(7, 14);
            this.RadBright.Name = "RadBright";
            this.RadBright.Size = new System.Drawing.Size(50, 15);
            this.RadBright.TabIndex = 2;
            this.RadBright.TabStop = true;
            this.RadBright.Text = "Light";
            this.RadBright.UseSelectable = true;
            this.RadBright.CheckedChanged += new System.EventHandler(this.RadBright_CheckedChanged);
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = null;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Silver;
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youreAMinorInconvenienceToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(235, 26);
            // 
            // youreAMinorInconvenienceToolStripMenuItem
            // 
            this.youreAMinorInconvenienceToolStripMenuItem.Name = "youreAMinorInconvenienceToolStripMenuItem";
            this.youreAMinorInconvenienceToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.youreAMinorInconvenienceToolStripMenuItem.Text = "You\'re a minor inconvenience.";
            this.youreAMinorInconvenienceToolStripMenuItem.Click += new System.EventHandler(this.youreAMinorInconvenienceToolStripMenuItem_Click);
            // 
            // FightingPixels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 547);
            this.Controls.Add(this.Display);
            this.Name = "FightingPixels";
            this.Resizable = false;
            this.Text = "Fighters";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bdl);
            this.Resize += new System.EventHandler(this.dbl);
            this.Display.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Display;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroRadioButton RadDark;
        private MetroFramework.Controls.MetroRadioButton RadBright;
        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroLabel txtRight;
        private MetroFramework.Controls.MetroLabel txtLeft;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel txtRightPercent;
        private MetroFramework.Controls.MetroLabel txtLeftPercent;
        private MetroFramework.Controls.MetroLabel lblFrameSkip;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar TBFrameSkip;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle TGFrameSkip;
        private MetroFramework.Controls.MetroTextBox Seed;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle TGSeed;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MetroFramework.Controls.MetroToggle TGIntensity;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTrackBar brightness;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem youreAMinorInconvenienceToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroToggle TGShowProcessing;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTrackBar TBBomb;

    }
}

