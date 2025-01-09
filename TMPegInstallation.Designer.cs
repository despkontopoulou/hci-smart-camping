namespace SmartTent
{
    partial class TMPegInstallation
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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            rotation = new TextBox();
            pressure = new TextBox();
            rotationMinus = new Button();
            button3 = new Button();
            rotationPlus = new Button();
            pressureMinus = new Button();
            pressurePlus = new Button();
            MainPanel.SuspendLayout();
            SubPanelEmergency.SuspendLayout();
            SubPanelExplore.SuspendLayout();
            SubPanelTent.SuspendLayout();
            SuspendLayout();
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
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
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
            SubPanelEmergency.Size = new Size(316, 40);
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
            SubEmergNav1.Size = new Size(316, 40);
            SubEmergNav1.TabIndex = 6;
            SubEmergNav1.Text = "Emergency Shelters";
            SubEmergNav1.TextAlign = ContentAlignment.TopLeft;
            SubEmergNav1.UseVisualStyleBackColor = true;
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
            SubExplore4.Location = new Point(0, 76);
            SubExplore4.Margin = new Padding(2);
            SubExplore4.Name = "SubExplore4";
            SubExplore4.Padding = new Padding(14, 0, 0, 0);
            SubExplore4.Size = new Size(316, 40);
            SubExplore4.TabIndex = 9;
            SubExplore4.Text = "Weather";
            SubExplore4.TextAlign = ContentAlignment.TopLeft;
            SubExplore4.UseVisualStyleBackColor = true;
            // 
            // SubExplore3
            // 
            SubExplore3.FlatAppearance.BorderColor = Color.FromArgb(65, 71, 95);
            SubExplore3.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 39, 53);
            SubExplore3.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 71, 95);
            SubExplore3.FlatStyle = FlatStyle.Flat;
            SubExplore3.Font = new Font("Segoe UI", 14F);
            SubExplore3.ForeColor = Color.FromArgb(254, 254, 247);
            SubExplore3.Location = new Point(0, 36);
            SubExplore3.Margin = new Padding(2);
            SubExplore3.Name = "SubExplore3";
            SubExplore3.Padding = new Padding(14, 0, 0, 0);
            SubExplore3.Size = new Size(316, 40);
            SubExplore3.TabIndex = 8;
            SubExplore3.Text = "Services";
            SubExplore3.TextAlign = ContentAlignment.TopLeft;
            SubExplore3.UseVisualStyleBackColor = true;
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
            SubTent5.ForeColor = Color.FromArgb(254, 254, 247);
            SubTent5.Location = new Point(0, 160);
            SubTent5.Margin = new Padding(2);
            SubTent5.Name = "SubTent5";
            SubTent5.Padding = new Padding(14, 0, 0, 0);
            SubTent5.Size = new Size(316, 40);
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
            SubTent2.ForeColor = Color.FromArgb(219, 166, 30);
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
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.Gold;
            nightControlBox1.CloseHoverForeColor = Color.DarkBlue;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.CornflowerBlue;
            nightControlBox1.DisableMinimizeColor = Color.CornflowerBlue;
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.DarkBlue;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.DarkBlue;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.DarkBlue;
            nightControlBox1.Location = new Point(1781, 0);
            nightControlBox1.MaximizeHoverColor = Color.CornflowerBlue;
            nightControlBox1.MaximizeHoverForeColor = Color.DarkBlue;
            nightControlBox1.MinimizeHoverColor = Color.CornflowerBlue;
            nightControlBox1.MinimizeHoverForeColor = Color.DarkBlue;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 6;
            // 
            // rotation
            // 
            rotation.BackColor = Color.FromArgb(65, 71, 95);
            rotation.BorderStyle = BorderStyle.None;
            rotation.Font = new Font("Segoe UI", 18F);
            rotation.ForeColor = Color.FromArgb(178, 193, 208);
            rotation.Location = new Point(1666, 629);
            rotation.Name = "rotation";
            rotation.Size = new Size(42, 32);
            rotation.TabIndex = 7;
            rotation.Text = "45°";
            rotation.TextChanged += textBox1_TextChanged;
            // 
            // pressure
            // 
            pressure.BackColor = Color.FromArgb(65, 71, 95);
            pressure.BorderStyle = BorderStyle.None;
            pressure.Font = new Font("Segoe UI", 18F);
            pressure.ForeColor = Color.FromArgb(178, 193, 208);
            pressure.Location = new Point(1666, 689);
            pressure.Name = "pressure";
            pressure.Size = new Size(65, 32);
            pressure.TabIndex = 8;
            pressure.Text = "100%";
            // 
            // rotationMinus
            // 
            rotationMinus.BackColor = Color.FromArgb(65, 71, 95);
            rotationMinus.FlatAppearance.BorderSize = 0;
            rotationMinus.FlatStyle = FlatStyle.Flat;
            rotationMinus.Font = new Font("Segoe UI", 20F);
            rotationMinus.ForeColor = Color.FromArgb(219, 166, 30);
            rotationMinus.ImageAlign = ContentAlignment.MiddleRight;
            rotationMinus.Location = new Point(1635, 619);
            rotationMinus.Name = "rotationMinus";
            rotationMinus.Size = new Size(22, 48);
            rotationMinus.TabIndex = 13;
            rotationMinus.Text = "-";
            rotationMinus.UseVisualStyleBackColor = false;
            rotationMinus.Click += rotationMinus_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(65, 71, 95);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 20F);
            button3.ForeColor = Color.FromArgb(219, 166, 30);
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(1726, 673);
            button3.Name = "button3";
            button3.Size = new Size(22, 48);
            button3.TabIndex = 15;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            // 
            // rotationPlus
            // 
            rotationPlus.BackColor = Color.FromArgb(65, 71, 95);
            rotationPlus.FlatAppearance.BorderSize = 0;
            rotationPlus.FlatStyle = FlatStyle.Flat;
            rotationPlus.Font = new Font("Segoe UI", 20F);
            rotationPlus.ForeColor = Color.FromArgb(219, 166, 30);
            rotationPlus.ImageAlign = ContentAlignment.MiddleRight;
            rotationPlus.Location = new Point(1714, 619);
            rotationPlus.Name = "rotationPlus";
            rotationPlus.Size = new Size(22, 48);
            rotationPlus.TabIndex = 16;
            rotationPlus.Text = "+";
            rotationPlus.UseVisualStyleBackColor = false;
            rotationPlus.Click += rotationPlus_Click;
            // 
            // pressureMinus
            // 
            pressureMinus.BackColor = Color.FromArgb(65, 71, 95);
            pressureMinus.FlatAppearance.BorderSize = 0;
            pressureMinus.FlatStyle = FlatStyle.Flat;
            pressureMinus.Font = new Font("Segoe UI", 20F);
            pressureMinus.ForeColor = Color.FromArgb(219, 166, 30);
            pressureMinus.ImageAlign = ContentAlignment.MiddleRight;
            pressureMinus.Location = new Point(1638, 674);
            pressureMinus.Name = "pressureMinus";
            pressureMinus.Size = new Size(22, 48);
            pressureMinus.TabIndex = 17;
            pressureMinus.Text = "-";
            pressureMinus.UseVisualStyleBackColor = false;
            pressureMinus.Click += pressureMinus_Click;
            // 
            // pressurePlus
            // 
            pressurePlus.BackColor = Color.FromArgb(65, 71, 95);
            pressurePlus.FlatAppearance.BorderSize = 0;
            pressurePlus.FlatStyle = FlatStyle.Flat;
            pressurePlus.Font = new Font("Segoe UI", 20F);
            pressurePlus.ForeColor = Color.FromArgb(219, 166, 30);
            pressurePlus.ImageAlign = ContentAlignment.MiddleRight;
            pressurePlus.Location = new Point(1726, 674);
            pressurePlus.Name = "pressurePlus";
            pressurePlus.Size = new Size(22, 48);
            pressurePlus.TabIndex = 18;
            pressurePlus.Text = "+";
            pressurePlus.UseVisualStyleBackColor = false;
            pressurePlus.Click += pressurePlus_Click;
            // 
            // TMPegInstallation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 69);
            BackgroundImage = Properties.Resources.TMPegInstallation;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pressurePlus);
            Controls.Add(pressureMinus);
            Controls.Add(rotationPlus);
            Controls.Add(button3);
            Controls.Add(rotationMinus);
            Controls.Add(pressure);
            Controls.Add(rotation);
            Controls.Add(nightControlBox1);
            Controls.Add(MainPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TMPegInstallation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            SubPanelEmergency.ResumeLayout(false);
            SubPanelExplore.ResumeLayout(false);
            SubPanelTent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private TextBox rotation;
        private TextBox pressure;
        private Button rotationMinus;
        private Button button3;
        private Button rotationPlus;
        private Button pressureMinus;
        private Button pressurePlus;
    }
}