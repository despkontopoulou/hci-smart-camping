
namespace SmartTent
{
    public partial class StartPage : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private float targetFontSize = 12f; // Target font size when animation ends
        private Point targetLocation = new Point(20, 15); // Target location
        private float fontSizeStep = -1.0f; // Step for font size reduction
        private int locationStep = 5; // Step for location adjustment

        public StartPage()
        {
            InitializeComponent();

            //set image buttons
            Image image1Normal = Properties.Resources.tent_management_btn;
            Image image1Hover = Properties.Resources.tent_management_btn_2;

            Image image2Normal = Properties.Resources.explore_nearby_btn;
            Image image2Hover = Properties.Resources.explore_nearby_btn_2;

            Image image3Normal = Properties.Resources.emergency_nav_btn;
            Image image3Hover = Properties.Resources.emergency_nav_btn_2;

            changeImgOnHover(pictureBox1, image1Normal, image1Hover);
            changeImgOnHover(pictureBox2, image2Normal, image2Hover);
            changeImgOnHover(pictureBox3, image3Normal, image3Hover);

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // main btns click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TMLocationSelection locationSelection = new TMLocationSelection();
            locationSelection.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EXAttractions attractions= new EXAttractions();
            attractions.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ENShelters shelters= new ENShelters();
            shelters.Show();
            this.Hide();

        }

        //helper functions
        private void changeImgOnHover(PictureBox pictureBox, Image normal, Image hover) {
            pictureBox.MouseHover += (sender, e) => pictureBox.Image = hover;
            pictureBox.MouseLeave += (sender, e) => pictureBox.Image = normal;
        }
       
    }
}
