namespace SmartTent
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu_btn = new PictureBox();
            exit_btn = new PictureBox();
            title = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)menu_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menu_btn
            // 
            menu_btn.BackColor = Color.Transparent;
            menu_btn.BackgroundImage = Properties.Resources.menu_btn;
            menu_btn.BackgroundImageLayout = ImageLayout.Stretch;
            menu_btn.Location = new Point(15, 15);
            menu_btn.Name = "menu_btn";
            menu_btn.Size = new Size(26, 24);
            menu_btn.TabIndex = 0;
            menu_btn.TabStop = false;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.Transparent;
            exit_btn.BackgroundImage = Properties.Resources.exit_btn;
            exit_btn.BackgroundImageLayout = ImageLayout.Stretch;
            exit_btn.Location = new Point(1882, 15);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(26, 24);
            exit_btn.TabIndex = 1;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Candara", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(65, 71, 95);
            title.Location = new Point(47, 10);
            title.Name = "title";
            title.Size = new Size(199, 35);
            title.TabIndex = 2;
            title.Text = "Smart Camping";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.tent_management_btn;
            pictureBox1.Location = new Point(419, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 486);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.explore_nearby_btn;
            pictureBox2.Location = new Point(790, 297);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 486);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.emergency_nav_btn;
            pictureBox3.Location = new Point(1161, 297);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(340, 486);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainbg;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(title);
            Controls.Add(exit_btn);
            Controls.Add(menu_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)menu_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox menu_btn;
        private PictureBox exit_btn;
        private Label title;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
