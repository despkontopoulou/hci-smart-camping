using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTent
{
    public partial class TMLocationSelection : Form
    {
        public TMLocationSelection()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SubPanelTent.Visible = true;
            SubPanelExplore.Visible = false;
            SubPanelEmergency.Visible = false;
            MainExploreNearby.Location = new Point(0, 240);
            MainEmergencyNav.Location = new Point(0, 280);


            Image campsite1Normal = Properties.Resources.campsite1_n;
            Image campsite1Hover = Properties.Resources.campsite1_y;

            Image campsite2Normal = Properties.Resources.campsite2_n;
            Image campsite2Hover = Properties.Resources.campsite2_y;

            Image campsite3Normal = Properties.Resources.campsite3_n;
            Image campsite3Hover = Properties.Resources.campsite3_y;

            Image campsite4Normal = Properties.Resources.campsite4_n;
            Image campsite4Hover = Properties.Resources.campsite4_y1;

            changeOnHover(pictureBox1, campsite1Normal, campsite1Hover, 1);
            changeOnHover(pictureBox2, campsite2Normal, campsite2Hover, 2);
            changeOnHover(pictureBox3, campsite3Normal, campsite3Hover, 3);
            changeOnHover(pictureBox4, campsite4Normal, campsite4Hover, 4);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            TMPegInstallation pegInstallation = new TMPegInstallation();
            pegInstallation.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubPanelTent.Visible = !SubPanelTent.Visible;//toggle buttons
            if (SubPanelTent.Visible)
            {
                SubPanelExplore.Visible = false;
                SubPanelEmergency.Visible = false;
            }
            placeButtons();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubPanelExplore.Visible = !SubPanelExplore.Visible;
            if (SubPanelExplore.Visible)
            {
                SubPanelTent.Visible = false;
                SubPanelEmergency.Visible = false;
            }
            placeButtons();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SubPanelEmergency.Visible = !SubPanelEmergency.Visible;
            if (SubPanelEmergency.Visible)
            {
                SubPanelTent.Visible = false;
                SubPanelExplore.Visible = false;
            }
            placeButtons();
        }

        private void placeButtons()
        {
            if (SubPanelTent.Visible)
            {
                MainExploreNearby.Location = new Point(0, 240);
                MainEmergencyNav.Location = new Point(0, 280);

            }
            if (!SubPanelTent.Visible)
            {
                MainExploreNearby.Location = new Point(0, 38);
                MainEmergencyNav.Location = new Point(0, 76);

            }

            if (SubPanelExplore.Visible)
            {
                MainExploreNearby.Location = new Point(0, 38);
                SubPanelExplore.Location = new Point(0, 76);
                MainEmergencyNav.Location = new Point(0, 196);
            }
            if (SubPanelEmergency.Visible)
            {
                SubPanelEmergency.Location = new Point(0, 114);
            }

        }

       /* private void changeOnHover(PictureBox pictureBox, Image normal, Image hover, int camp)
        {
            pictureBox.MouseHover += (sender, e) =>
            {
                pictureBox.Image = hover;

                switch (camp)
                {
                    case 1:
                        campground.Text = "Campsite 1";
                        current.Text = "Campsite 1";
                        coordinates.Text = "25°27'32.0\"N 32°57'21.2\"W";
                        weather.Text = "Rainy";
                        humidity.Text = "90%";
                        stability.Text = "100%";
                        sunExposure.Text = "Low";
                        break;

                    case 2:
                        campground.Text = "Campsite 2";
                        current.Text = "Campsite 2";
                        coordinates.Text = "25°27'32.0\"N 32°67'21.2\"W";
                        weather.Text = "Rainy";
                        humidity.Text = "90%";
                        stability.Text = "100%";
                        sunExposure.Text = "Medium";
                        break;

                    case 3:
                        campground.Text = "Campsite 3";
                        current.Text = "Campsite 3";
                        coordinates.Text = "25°28'32.0\"N 32°75'21.2\"W";
                        weather.Text = "Rainy";
                        humidity.Text = "95%";
                        stability.Text = "100%";
                        sunExposure.Text = "Medium";
                        break;

                    case 4:
                        campground.Text = "Campsite 4";
                        current.Text = "Campsite 4";
                        coordinates.Text = "25°21'32.0\"N 32°70'21.2\"W";
                        weather.Text = "Rainy";
                        humidity.Text = "85%";
                        stability.Text = "100%";
                        sunExposure.Text = "Low";
                        break;
                }
            };
            pictureBox.MouseLeave += (sender, e) =>
            {
                pictureBox.Image = normal;
                campground.Text = "";
                current.Text = "";
                coordinates.Text = "";
                weather.Text = "";
                humidity.Text = "";
                stability.Text = "";
                sunExposure.Text = "";
            };


        }*/

        private void TMLocationSelection_Load(object sender, EventArgs e)
        {

        }

        private void SubEmergNav1_Click(object sender, EventArgs e)
        {

        }

        private void SubExplore3_Click(object sender, EventArgs e)
        {

        }

        private void SubExplore2_Click(object sender, EventArgs e)
        {

        }

        private void SubExplore4_Click(object sender, EventArgs e)
        {

        }

        private void SubTent3_Click(object sender, EventArgs e)
        {
            TMCanopyInstallation canopyInstallation = new TMCanopyInstallation();
            canopyInstallation.Show();
            this.Hide();
        }

        private void SubTent4_Click(object sender, EventArgs e)
        {
            TMLightingSettings lightingSettings = new TMLightingSettings();
            lightingSettings.Show();
            this.Hide();
        }

        private void SubTent5_Click(object sender, EventArgs e)
        {
            TMEnergy energy = new TMEnergy();
            energy.Show();
            this.Hide();
        }
        private void SubTent1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            campground.Text = "Campsite 1";
            current.Text = "Campsite 1";
            coordinates.Text = "25°27'32.0\"N 32°57'21.2\"W";
            weather.Text = "Rainy";
            humidity.Text = "90%";
            stability.Text = "100%";
            sunExposure.Text = "Low";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            campground.Text = "Campsite 2";
            current.Text = "Campsite 2";
            coordinates.Text = "25°27'32.0\"N 32°67'21.2\"W";
            weather.Text = "Rainy";
            humidity.Text = "90%";
            stability.Text = "100%";
            sunExposure.Text = "Medium";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            campground.Text = "Campsite 3";
            current.Text = "Campsite 3";
            coordinates.Text = "25°28'32.0\"N 32°75'21.2\"W";
            weather.Text = "Rainy";
            humidity.Text = "95%";
            stability.Text = "100%";
            sunExposure.Text = "Medium";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            campground.Text = "Campsite 4";
            current.Text = "Campsite 4";
            coordinates.Text = "25°21'32.0\"N 32°70'21.2\"W";
            weather.Text = "Rainy";
            humidity.Text = "85%";
            stability.Text = "100%";
            sunExposure.Text = "Low";
        }

        private PictureBox selectedPictureBox = null;

        private void changeOnHover(PictureBox pictureBox, Image normal, Image hover, int camp)
        {
            // Handle hover effect
            pictureBox.MouseEnter += (sender, e) =>
            {
                if (selectedPictureBox != pictureBox) // Only change if not selected
                {
                    pictureBox.Image = hover;
                }
            };

            pictureBox.MouseLeave += (sender, e) =>
            {
                if (selectedPictureBox != pictureBox) // Only change if not selected
                {
                    pictureBox.Image = normal;
                }
            };

            // Handle click to select
            pictureBox.Click += (sender, e) =>
            {
                if (selectedPictureBox != null) // Reset previously selected PictureBox
                {
                    selectedPictureBox.Image = GetNormalImage(selectedPictureBox); // Retrieve normal image
                }

                selectedPictureBox = pictureBox; // Set new selection
                pictureBox.Image = hover; // Keep hover image on selection

                UpdateCampsiteInfo(camp); // Update displayed information
            };
        }

        // Helper method to get the normal image of a PictureBox
        private Image GetNormalImage(PictureBox pictureBox)
        {
            if (pictureBox == pictureBox1) return Properties.Resources.campsite1_n;
            if (pictureBox == pictureBox2) return Properties.Resources.campsite2_n;
            if (pictureBox == pictureBox3) return Properties.Resources.campsite3_n;
            if (pictureBox == pictureBox4) return Properties.Resources.campsite4_n;
            return null;
        }

        // Helper method to update campsite information
        private void UpdateCampsiteInfo(int camp)
        {
            switch (camp)
            {
                case 1:
                    campground.Text = "Campsite 1";
                    current.Text = "Campsite 1";
                    coordinates.Text = "25°27'32.0\"N 32°57'21.2\"W";
                    weather.Text = "Rainy";
                    humidity.Text = "90%";
                    stability.Text = "100%";
                    sunExposure.Text = "Low";
                    break;

                case 2:
                    campground.Text = "Campsite 2";
                    current.Text = "Campsite 2";
                    coordinates.Text = "25°27'32.0\"N 32°67'21.2\"W";
                    weather.Text = "Rainy";
                    humidity.Text = "90%";
                    stability.Text = "100%";
                    sunExposure.Text = "Medium";
                    break;

                case 3:
                    campground.Text = "Campsite 3";
                    current.Text = "Campsite 3";
                    coordinates.Text = "25°28'32.0\"N 32°75'21.2\"W";
                    weather.Text = "Rainy";
                    humidity.Text = "95%";
                    stability.Text = "100%";
                    sunExposure.Text = "Medium";
                    break;

                case 4:
                    campground.Text = "Campsite 4";
                    current.Text = "Campsite 4";
                    coordinates.Text = "25°21'32.0\"N 32°70'21.2\"W";
                    weather.Text = "Rainy";
                    humidity.Text = "85%";
                    stability.Text = "100%";
                    sunExposure.Text = "Low";
                    break;
            }
        }



    }
}
