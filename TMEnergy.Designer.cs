namespace SmartTent
{
    partial class TMEnergy
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
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            MainPanel = new Panel();
            MainExploreNearby = new Button();
            MainTentManagement = new Button();
            SubPanelEmergency = new Panel();
            SubEmergNav1 = new Button();
            MainEmergencyNav = new Button();
            SubPanelExplore = new Panel();
            SubExplore4 = new Button();
            SubExplore3 = new Button();
            SubExplore1 = new Button();
            SubPanelTent = new Panel();
            SubTent5 = new Button();
            SubTent4 = new Button();
            SubTent3 = new Button();
            SubTent2 = new Button();
            SubTent1 = new Button();
            automaticSaving = new Button();
            heating = new ReaLTaiizor.Controls.HopeToggle();
            lighting = new ReaLTaiizor.Controls.HopeToggle();
            stove = new ReaLTaiizor.Controls.HopeToggle();
            music = new ReaLTaiizor.Controls.HopeToggle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            onlineHelp = new PictureBox();
            MainPanel.SuspendLayout();
            SubPanelEmergency.SuspendLayout();
            SubPanelExplore.SuspendLayout();
            SubPanelTent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)onlineHelp).BeginInit();
            SuspendLayout();
            // 
            // nightControlBox2
            // 
            nightControlBox2.BackColor = Color.Transparent;
            nightControlBox2.CloseHoverColor = Color.Gold;
            nightControlBox2.CloseHoverForeColor = Color.DarkBlue;
            nightControlBox2.DefaultLocation = true;
            nightControlBox2.DisableMaximizeColor = Color.CornflowerBlue;
            nightControlBox2.DisableMinimizeColor = Color.CornflowerBlue;
            nightControlBox2.Dock = DockStyle.Right;
            nightControlBox2.EnableCloseColor = Color.DarkBlue;
            nightControlBox2.EnableMaximizeButton = true;
            nightControlBox2.EnableMaximizeColor = Color.DarkBlue;
            nightControlBox2.EnableMinimizeButton = true;
            nightControlBox2.EnableMinimizeColor = Color.DarkBlue;
            nightControlBox2.Location = new Point(1781, 0);
            nightControlBox2.MaximizeHoverColor = Color.CornflowerBlue;
            nightControlBox2.MaximizeHoverForeColor = Color.DarkBlue;
            nightControlBox2.MinimizeHoverColor = Color.CornflowerBlue;
            nightControlBox2.MinimizeHoverForeColor = Color.DarkBlue;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new Size(139, 31);
            nightControlBox2.TabIndex = 11;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(46, 51, 69);
            MainPanel.Controls.Add(MainExploreNearby);
            MainPanel.Controls.Add(MainTentManagement);
            MainPanel.Controls.Add(SubPanelEmergency);
            MainPanel.Controls.Add(MainEmergencyNav);
            MainPanel.Controls.Add(SubPanelExplore);
            MainPanel.Controls.Add(SubPanelTent);
            MainPanel.Location = new Point(34, 142);
            MainPanel.Margin = new Padding(2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(325, 596);
            MainPanel.TabIndex = 12;
            // 
            // MainExploreNearby
            // 
            MainExploreNearby.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            MainExploreNearby.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            MainExploreNearby.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 39, 53);
            MainExploreNearby.FlatStyle = FlatStyle.Flat;
            MainExploreNearby.Font = new Font("Segoe UI", 14F);
            MainExploreNearby.ForeColor = Color.FromArgb(254, 254, 247);
            MainExploreNearby.Location = new Point(0, 240);
            MainExploreNearby.Margin = new Padding(2);
            MainExploreNearby.Name = "MainExploreNearby";
            MainExploreNearby.Padding = new Padding(14, 0, 0, 0);
            MainExploreNearby.Size = new Size(316, 40);
            MainExploreNearby.TabIndex = 4;
            MainExploreNearby.Text = "Explore Nearby";
            MainExploreNearby.TextAlign = ContentAlignment.MiddleLeft;
            MainExploreNearby.UseVisualStyleBackColor = true;
            MainExploreNearby.Click += MainExploreNearby_Click;
            // 
            // MainTentManagement
            // 
            MainTentManagement.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            MainTentManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            MainTentManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 39, 53);
            MainTentManagement.FlatStyle = FlatStyle.Flat;
            MainTentManagement.Font = new Font("Segoe UI", 14F);
            MainTentManagement.ForeColor = Color.FromArgb(254, 254, 247);
            MainTentManagement.Location = new Point(0, 0);
            MainTentManagement.Margin = new Padding(2);
            MainTentManagement.Name = "MainTentManagement";
            MainTentManagement.Padding = new Padding(14, 0, 0, 0);
            MainTentManagement.Size = new Size(316, 40);
            MainTentManagement.TabIndex = 0;
            MainTentManagement.Text = "Tent Management";
            MainTentManagement.TextAlign = ContentAlignment.MiddleLeft;
            MainTentManagement.UseVisualStyleBackColor = true;
            MainTentManagement.Click += MainTentManagement_Click;
            // 
            // SubPanelEmergency
            // 
            SubPanelEmergency.BackColor = Color.FromArgb(65, 71, 95);
            SubPanelEmergency.Controls.Add(SubEmergNav1);
            SubPanelEmergency.Location = new Point(0, 440);
            SubPanelEmergency.Margin = new Padding(2);
            SubPanelEmergency.Name = "SubPanelEmergency";
            SubPanelEmergency.Size = new Size(316, 43);
            SubPanelEmergency.TabIndex = 9;
            SubPanelEmergency.Visible = false;
            // 
            // SubEmergNav1
            // 
            SubEmergNav1.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubEmergNav1.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubEmergNav1.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubEmergNav1.FlatStyle = FlatStyle.Flat;
            SubEmergNav1.Font = new Font("Segoe UI", 14F);
            SubEmergNav1.ForeColor = Color.FromArgb(254, 254, 247);
            SubEmergNav1.Location = new Point(0, 0);
            SubEmergNav1.Margin = new Padding(2);
            SubEmergNav1.Name = "SubEmergNav1";
            SubEmergNav1.Padding = new Padding(14, 0, 0, 0);
            SubEmergNav1.Size = new Size(289, 40);
            SubEmergNav1.TabIndex = 6;
            SubEmergNav1.Text = "Emergency Shelters";
            SubEmergNav1.TextAlign = ContentAlignment.TopLeft;
            SubEmergNav1.UseVisualStyleBackColor = true;
            SubEmergNav1.Click += SubEmergNav1_Click;
            // 
            // MainEmergencyNav
            // 
            MainEmergencyNav.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            MainEmergencyNav.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            MainEmergencyNav.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 39, 53);
            MainEmergencyNav.FlatStyle = FlatStyle.Flat;
            MainEmergencyNav.Font = new Font("Segoe UI", 14F);
            MainEmergencyNav.ForeColor = Color.FromArgb(254, 254, 247);
            MainEmergencyNav.Location = new Point(0, 400);
            MainEmergencyNav.Margin = new Padding(2);
            MainEmergencyNav.Name = "MainEmergencyNav";
            MainEmergencyNav.Padding = new Padding(14, 0, 0, 0);
            MainEmergencyNav.Size = new Size(316, 40);
            MainEmergencyNav.TabIndex = 5;
            MainEmergencyNav.Text = "Emergency Navigation";
            MainEmergencyNav.TextAlign = ContentAlignment.MiddleLeft;
            MainEmergencyNav.UseVisualStyleBackColor = true;
            MainEmergencyNav.Click += MainEmergencyNav_Click;
            // 
            // SubPanelExplore
            // 
            SubPanelExplore.BackColor = Color.FromArgb(65, 71, 95);
            SubPanelExplore.Controls.Add(SubExplore4);
            SubPanelExplore.Controls.Add(SubExplore3);
            SubPanelExplore.Controls.Add(SubExplore1);
            SubPanelExplore.Location = new Point(0, 280);
            SubPanelExplore.Margin = new Padding(2);
            SubPanelExplore.Name = "SubPanelExplore";
            SubPanelExplore.Size = new Size(316, 120);
            SubPanelExplore.TabIndex = 7;
            SubPanelExplore.Visible = false;
            // 
            // SubExplore4
            // 
            SubExplore4.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubExplore4.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubExplore4.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubExplore4.FlatStyle = FlatStyle.Flat;
            SubExplore4.Font = new Font("Segoe UI", 14F);
            SubExplore4.ForeColor = Color.FromArgb(254, 254, 247);
            SubExplore4.Location = new Point(0, 80);
            SubExplore4.Margin = new Padding(2);
            SubExplore4.Name = "SubExplore4";
            SubExplore4.Padding = new Padding(14, 0, 0, 0);
            SubExplore4.Size = new Size(262, 40);
            SubExplore4.TabIndex = 9;
            SubExplore4.Text = "Weather";
            SubExplore4.TextAlign = ContentAlignment.TopLeft;
            SubExplore4.UseVisualStyleBackColor = true;
            SubExplore4.Click += SubExplore3_Click;
            // 
            // SubExplore3
            // 
            SubExplore3.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubExplore3.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubExplore3.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubExplore3.FlatStyle = FlatStyle.Flat;
            SubExplore3.Font = new Font("Segoe UI", 14F);
            SubExplore3.ForeColor = Color.FromArgb(254, 254, 247);
            SubExplore3.Location = new Point(0, 40);
            SubExplore3.Margin = new Padding(2);
            SubExplore3.Name = "SubExplore3";
            SubExplore3.Padding = new Padding(14, 0, 0, 0);
            SubExplore3.Size = new Size(289, 40);
            SubExplore3.TabIndex = 8;
            SubExplore3.Text = "Services";
            SubExplore3.TextAlign = ContentAlignment.TopLeft;
            SubExplore3.UseVisualStyleBackColor = true;
            SubExplore3.Click += SubExplore2_Click;
            // 
            // SubExplore1
            // 
            SubExplore1.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubExplore1.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubExplore1.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubExplore1.FlatStyle = FlatStyle.Flat;
            SubExplore1.Font = new Font("Segoe UI", 14F);
            SubExplore1.ForeColor = Color.FromArgb(254, 254, 247);
            SubExplore1.Location = new Point(0, 0);
            SubExplore1.Margin = new Padding(2);
            SubExplore1.Name = "SubExplore1";
            SubExplore1.Padding = new Padding(14, 0, 0, 0);
            SubExplore1.Size = new Size(316, 40);
            SubExplore1.TabIndex = 6;
            SubExplore1.Text = "Local Attractions";
            SubExplore1.TextAlign = ContentAlignment.TopLeft;
            SubExplore1.UseVisualStyleBackColor = true;
            SubExplore1.Click += SubExplore1_Click;
            // 
            // SubPanelTent
            // 
            SubPanelTent.BackColor = Color.FromArgb(65, 71, 95);
            SubPanelTent.Controls.Add(SubTent5);
            SubPanelTent.Controls.Add(SubTent4);
            SubPanelTent.Controls.Add(SubTent3);
            SubPanelTent.Controls.Add(SubTent2);
            SubPanelTent.Controls.Add(SubTent1);
            SubPanelTent.Location = new Point(0, 40);
            SubPanelTent.Margin = new Padding(2);
            SubPanelTent.Name = "SubPanelTent";
            SubPanelTent.Size = new Size(316, 200);
            SubPanelTent.TabIndex = 3;
            // 
            // SubTent5
            // 
            SubTent5.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubTent5.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubTent5.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubTent5.FlatStyle = FlatStyle.Flat;
            SubTent5.Font = new Font("Segoe UI", 14F);
            SubTent5.ForeColor = Color.FromArgb(219, 166, 30);
            SubTent5.Location = new Point(0, 160);
            SubTent5.Margin = new Padding(2);
            SubTent5.Name = "SubTent5";
            SubTent5.Padding = new Padding(14, 0, 0, 0);
            SubTent5.Size = new Size(289, 40);
            SubTent5.TabIndex = 5;
            SubTent5.Text = "Energy Consumption";
            SubTent5.TextAlign = ContentAlignment.TopLeft;
            SubTent5.UseVisualStyleBackColor = true;
            SubTent5.Click += SubTent5_Click;
            // 
            // SubTent4
            // 
            SubTent4.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubTent4.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubTent4.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubTent4.FlatStyle = FlatStyle.Flat;
            SubTent4.Font = new Font("Segoe UI", 14F);
            SubTent4.ForeColor = Color.FromArgb(254, 254, 247);
            SubTent4.Location = new Point(0, 120);
            SubTent4.Margin = new Padding(2);
            SubTent4.Name = "SubTent4";
            SubTent4.Padding = new Padding(14, 0, 0, 0);
            SubTent4.Size = new Size(316, 40);
            SubTent4.TabIndex = 4;
            SubTent4.Text = "Lighting Settings";
            SubTent4.TextAlign = ContentAlignment.TopLeft;
            SubTent4.UseVisualStyleBackColor = true;
            SubTent4.Click += SubTent4_Click;
            // 
            // SubTent3
            // 
            SubTent3.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubTent3.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubTent3.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubTent3.FlatStyle = FlatStyle.Flat;
            SubTent3.Font = new Font("Segoe UI", 14F);
            SubTent3.ForeColor = Color.FromArgb(254, 254, 247);
            SubTent3.Location = new Point(0, 80);
            SubTent3.Margin = new Padding(2);
            SubTent3.Name = "SubTent3";
            SubTent3.Padding = new Padding(14, 0, 0, 0);
            SubTent3.Size = new Size(316, 40);
            SubTent3.TabIndex = 3;
            SubTent3.Text = "Protective Canopy Installation";
            SubTent3.TextAlign = ContentAlignment.TopLeft;
            SubTent3.Click += SubTent3_Click;
            // 
            // SubTent2
            // 
            SubTent2.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubTent2.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubTent2.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubTent2.FlatStyle = FlatStyle.Flat;
            SubTent2.Font = new Font("Segoe UI", 14F);
            SubTent2.ForeColor = Color.FromArgb(254, 254, 247);
            SubTent2.Location = new Point(0, 40);
            SubTent2.Margin = new Padding(2);
            SubTent2.Name = "SubTent2";
            SubTent2.Padding = new Padding(14, 0, 0, 0);
            SubTent2.Size = new Size(316, 40);
            SubTent2.TabIndex = 2;
            SubTent2.Text = "Tent Peg Installation";
            SubTent2.TextAlign = ContentAlignment.TopLeft;
            SubTent2.UseVisualStyleBackColor = true;
            SubTent2.Click += SubTent2_Click;
            // 
            // SubTent1
            // 
            SubTent1.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubTent1.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubTent1.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubTent1.FlatStyle = FlatStyle.Flat;
            SubTent1.Font = new Font("Segoe UI", 14F);
            SubTent1.ForeColor = Color.FromArgb(254, 254, 247);
            SubTent1.Location = new Point(0, 0);
            SubTent1.Margin = new Padding(2);
            SubTent1.Name = "SubTent1";
            SubTent1.Padding = new Padding(14, 0, 0, 0);
            SubTent1.Size = new Size(316, 40);
            SubTent1.TabIndex = 1;
            SubTent1.Text = "Location Selection";
            SubTent1.TextAlign = ContentAlignment.TopLeft;
            SubTent1.UseVisualStyleBackColor = true;
            SubTent1.Click += SubTent1_Click;
            // 
            // automaticSaving
            // 
            automaticSaving.BackColor = Color.FromArgb(211, 236, 220);
            automaticSaving.FlatAppearance.BorderSize = 0;
            automaticSaving.FlatAppearance.MouseDownBackColor = Color.FromArgb(189, 224, 175);
            automaticSaving.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 200, 140);
            automaticSaving.FlatStyle = FlatStyle.Flat;
            automaticSaving.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            automaticSaving.ForeColor = Color.DarkGreen;
            automaticSaving.Location = new Point(1532, 202);
            automaticSaving.Name = "automaticSaving";
            automaticSaving.Size = new Size(330, 60);
            automaticSaving.TabIndex = 13;
            automaticSaving.Text = "Enable Automatic Energy Saving";
            automaticSaving.UseVisualStyleBackColor = false;
            automaticSaving.Click += automaticSaving_Click;
            // 
            // heating
            // 
            heating.AutoSize = true;
            heating.BackColor = Color.FromArgb(65, 71, 95);
            heating.BaseColor = Color.FromArgb(65, 71, 95);
            heating.BaseColorA = Color.FromArgb(220, 223, 230);
            heating.BaseColorB = Color.Goldenrod;
            heating.Checked = true;
            heating.CheckState = CheckState.Checked;
            heating.HeadColorA = Color.FromArgb(220, 223, 230);
            heating.HeadColorB = Color.White;
            heating.HeadColorC = Color.White;
            heating.HeadColorD = Color.White;
            heating.Location = new Point(1753, 569);
            heating.Name = "heating";
            heating.Size = new Size(48, 20);
            heating.TabIndex = 14;
            heating.Text = "hopeToggle1";
            heating.UseVisualStyleBackColor = false;
            // 
            // lighting
            // 
            lighting.AutoSize = true;
            lighting.BackColor = Color.FromArgb(65, 71, 95);
            lighting.BaseColor = Color.FromArgb(65, 71, 95);
            lighting.BaseColorA = Color.FromArgb(220, 223, 230);
            lighting.BaseColorB = Color.Goldenrod;
            lighting.HeadColorA = Color.FromArgb(220, 223, 230);
            lighting.HeadColorB = Color.White;
            lighting.HeadColorC = Color.White;
            lighting.HeadColorD = Color.White;
            lighting.Location = new Point(1753, 618);
            lighting.Name = "lighting";
            lighting.Size = new Size(48, 20);
            lighting.TabIndex = 15;
            lighting.Text = "hopeToggle2";
            lighting.UseVisualStyleBackColor = false;
            // 
            // stove
            // 
            stove.AutoSize = true;
            stove.BackColor = Color.FromArgb(65, 71, 95);
            stove.BaseColor = Color.FromArgb(65, 71, 95);
            stove.BaseColorA = Color.FromArgb(220, 223, 230);
            stove.BaseColorB = Color.Goldenrod;
            stove.Checked = true;
            stove.CheckState = CheckState.Checked;
            stove.HeadColorA = Color.FromArgb(220, 223, 230);
            stove.HeadColorB = Color.White;
            stove.HeadColorC = Color.White;
            stove.HeadColorD = Color.White;
            stove.Location = new Point(1728, 663);
            stove.Name = "stove";
            stove.Size = new Size(48, 20);
            stove.TabIndex = 16;
            stove.Text = "hopeToggle3";
            stove.UseVisualStyleBackColor = false;
            // 
            // music
            // 
            music.AutoSize = true;
            music.BackColor = Color.FromArgb(65, 71, 95);
            music.BaseColor = Color.FromArgb(65, 71, 95);
            music.BaseColorA = Color.FromArgb(220, 223, 230);
            music.BaseColorB = Color.Goldenrod;
            music.Checked = true;
            music.CheckState = CheckState.Checked;
            music.HeadColorA = Color.FromArgb(220, 223, 230);
            music.HeadColorB = Color.White;
            music.HeadColorC = Color.White;
            music.HeadColorD = Color.White;
            music.Location = new Point(1728, 709);
            music.Name = "music";
            music.Size = new Size(48, 20);
            music.TabIndex = 17;
            music.Text = "hopeToggle4";
            music.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(1738, 364);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 18;
            label1.Text = "80%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(1745, 401);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 19;
            label2.Text = "100%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(1787, 438);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 20;
            label3.Text = "5kWh/ hour";
            // 
            // onlineHelp
            // 
            onlineHelp.BackColor = Color.Transparent;
            onlineHelp.Location = new Point(25, 877);
            onlineHelp.Name = "onlineHelp";
            onlineHelp.Size = new Size(178, 40);
            onlineHelp.TabIndex = 21;
            onlineHelp.TabStop = false;
            onlineHelp.Click += onlineHelp_Click;
            // 
            // TMEnergy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 69);
            BackgroundImage = Properties.Resources.Group_2261;
            ClientSize = new Size(1920, 1080);
            Controls.Add(onlineHelp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(music);
            Controls.Add(stove);
            Controls.Add(lighting);
            Controls.Add(heating);
            Controls.Add(automaticSaving);
            Controls.Add(MainPanel);
            Controls.Add(nightControlBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TMEnergy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TMEnergy";
            MainPanel.ResumeLayout(false);
            SubPanelEmergency.ResumeLayout(false);
            SubPanelExplore.ResumeLayout(false);
            SubPanelTent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)onlineHelp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private Panel MainPanel;
        private Button MainExploreNearby;
        private Button MainTentManagement;
        private Panel SubPanelEmergency;
        private Button SubEmergNav1;
        private Button MainEmergencyNav;
        private Panel SubPanelExplore;
        private Button SubExplore4;
        private Button SubExplore3;
        private Button SubExplore1;
        private Panel SubPanelTent;
        private Button SubTent5;
        private Button SubTent4;
        private Button SubTent3;
        private Button SubTent2;
        private Button SubTent1;
        private Button automaticSaving;
        private ReaLTaiizor.Controls.HopeToggle heating;
        private ReaLTaiizor.Controls.HopeToggle lighting;
        private ReaLTaiizor.Controls.HopeToggle stove;
        private ReaLTaiizor.Controls.HopeToggle music;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox onlineHelp;
    }
}