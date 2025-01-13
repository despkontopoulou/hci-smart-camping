namespace SmartTent
{
    partial class EXServices
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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            plus = new Button();
            minus = new Button();
            quantity = new TextBox();
            total = new TextBox();
            message_box = new TextBox();
            hopeNotify1 = new ReaLTaiizor.Controls.HopeNotify();
            button6 = new Button();
            button7 = new Button();
            MainPanel.SuspendLayout();
            SubPanelEmergency.SuspendLayout();
            SubPanelExplore.SuspendLayout();
            SubPanelTent.SuspendLayout();
            SuspendLayout();
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
            nightControlBox1.TabIndex = 9;
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
            MainPanel.TabIndex = 10;
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
            SubExplore4.Location = new Point(0, 76);
            SubExplore4.Margin = new Padding(2);
            SubExplore4.Name = "SubExplore4";
            SubExplore4.Padding = new Padding(14, 0, 0, 0);
            SubExplore4.Size = new Size(316, 40);
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
            SubExplore3.ForeColor = Color.FromArgb(219, 166, 30);
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(215, 200, 184);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1007, 351);
            button1.Name = "button1";
            button1.Size = new Size(156, 44);
            button1.TabIndex = 11;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(111, 118, 147);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 98, 141);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 87);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(1052, 276);
            button2.Name = "button2";
            button2.Size = new Size(101, 27);
            button2.TabIndex = 12;
            button2.Text = "Add to Bill";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(111, 118, 147);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 98, 141);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 87);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(1180, 276);
            button3.Name = "button3";
            button3.Size = new Size(101, 27);
            button3.TabIndex = 13;
            button3.Text = "Pay Now";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(111, 118, 147);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 98, 141);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 87);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(1143, 309);
            button4.Name = "button4";
            button4.Size = new Size(173, 33);
            button4.TabIndex = 14;
            button4.Text = "Pick Delivery Time";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(111, 118, 147);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 98, 141);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 87);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(1715, 1017);
            button5.Name = "button5";
            button5.Size = new Size(163, 37);
            button5.TabIndex = 15;
            button5.Text = "Send Message";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(996, 262);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 133);
            panel1.TabIndex = 16;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(249, 249, 255);
            plus.FlatAppearance.BorderSize = 0;
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Segoe UI", 20F);
            plus.ForeColor = Color.FromArgb(111, 118, 147);
            plus.ImageAlign = ContentAlignment.MiddleRight;
            plus.Location = new Point(1283, 171);
            plus.Name = "plus";
            plus.Size = new Size(22, 48);
            plus.TabIndex = 19;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.FromArgb(249, 249, 255);
            minus.FlatAppearance.BorderSize = 0;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Segoe UI", 20F);
            minus.ForeColor = Color.FromArgb(111, 118, 147);
            minus.ImageAlign = ContentAlignment.MiddleRight;
            minus.Location = new Point(1218, 171);
            minus.Name = "minus";
            minus.Size = new Size(22, 48);
            minus.TabIndex = 18;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // quantity
            // 
            quantity.BackColor = Color.FromArgb(249, 249, 255);
            quantity.BorderStyle = BorderStyle.None;
            quantity.Font = new Font("Segoe UI", 18F);
            quantity.ForeColor = Color.FromArgb(111, 118, 147);
            quantity.Location = new Point(1228, 181);
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Size = new Size(64, 32);
            quantity.TabIndex = 17;
            quantity.Text = "1";
            quantity.TextAlign = HorizontalAlignment.Center;
            // 
            // total
            // 
            total.BackColor = Color.FromArgb(249, 249, 255);
            total.BorderStyle = BorderStyle.None;
            total.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.ForeColor = Color.FromArgb(111, 128, 104);
            total.Location = new Point(946, 230);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(41, 28);
            total.TabIndex = 20;
            total.Text = "3€";
            total.TextAlign = HorizontalAlignment.Center;
            // 
            // message_box
            // 
            message_box.Location = new Point(1453, 946);
            message_box.Name = "message_box";
            message_box.Size = new Size(369, 23);
            message_box.TabIndex = 21;
            // 
            // hopeNotify1
            // 
            hopeNotify1.Close = true;
            hopeNotify1.CloseColor = Color.FromArgb(144, 148, 154);
            hopeNotify1.ErrorBackColor = Color.FromArgb(25, 245, 108, 108);
            hopeNotify1.ErrorTextColor = Color.FromArgb(245, 108, 108);
            hopeNotify1.Font = new Font("Segoe UI", 12F);
            hopeNotify1.InfoBackColor = Color.FromArgb(25, 144, 147, 153);
            hopeNotify1.InfoTextColor = Color.FromArgb(144, 147, 153);
            hopeNotify1.Location = new Point(1552, 796);
            hopeNotify1.Name = "hopeNotify1";
            hopeNotify1.Size = new Size(156, 34);
            hopeNotify1.SuccessBackColor = Color.FromArgb(25, 103, 194, 58);
            hopeNotify1.SuccessTextColor = Color.FromArgb(103, 194, 58);
            hopeNotify1.TabIndex = 22;
            hopeNotify1.Text = "Message Sent";
            hopeNotify1.Type = ReaLTaiizor.Controls.HopeNotify.AlertType.Info;
            hopeNotify1.Visible = false;
            hopeNotify1.WarningBackColor = Color.FromArgb(25, 230, 162, 60);
            hopeNotify1.WarningTextColor = Color.FromArgb(230, 162, 60);
            // 
            // button6
            // 
            button6.BackColor = Color.RosyBrown;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14.25F);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(1551, 493);
            button6.Name = "button6";
            button6.Size = new Size(156, 45);
            button6.TabIndex = 23;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.RosyBrown;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14.25F);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(1551, 733);
            button7.Name = "button7";
            button7.Size = new Size(156, 45);
            button7.TabIndex = 24;
            button7.Text = "Reserve";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // EXServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 71, 95);
            BackgroundImage = Properties.Resources.Group_3412;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(hopeNotify1);
            Controls.Add(message_box);
            Controls.Add(total);
            Controls.Add(plus);
            Controls.Add(minus);
            Controls.Add(quantity);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MainPanel);
            Controls.Add(nightControlBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EXServices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EXActivities";
            MainPanel.ResumeLayout(false);
            SubPanelEmergency.ResumeLayout(false);
            SubPanelExplore.ResumeLayout(false);
            SubPanelTent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Button plus;
        private Button minus;
        private TextBox quantity;
        private TextBox total;
        private TextBox message_box;
        private ReaLTaiizor.Controls.HopeNotify hopeNotify1;
        private Button button6;
        private Button button7;
    }
}