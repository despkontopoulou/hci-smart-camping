using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTent.Helpers;
using System.Diagnostics;

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

        public TMLocationSelection(int selectedLocation)
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



            if (selectedLocation > 0)
            {
                clickedCamp = selectedLocation;
                UpdateCampsiteInfo(clickedCamp);
                SelectLocationClick(this, EventArgs.Empty);

                hopeNotify1.Text = "Location has been finalized";
                hopeNotify1.Visible = true;

            }

        }

        private int clickedCamp = 0;
        private int lastClickedCamp = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            UIHelper.TogglePanelVisibility(SubPanelTent, SubPanelExplore, SubPanelEmergency);
            placeButtons();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UIHelper.TogglePanelVisibility(SubPanelExplore, SubPanelTent, SubPanelEmergency);
            placeButtons();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UIHelper.TogglePanelVisibility(SubPanelEmergency, SubPanelExplore, SubPanelTent);
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

        private void SubTent2_Click(object sender, EventArgs e)
        {
            if (SharedData.SelectedRotation == null)
            {
                TMPegInstallation pegInstallation = new TMPegInstallation();
                pegInstallation.Show();
                this.Hide();
            }
            else
            {
                TMPegInstallation pegInstallation = new TMPegInstallation(SharedData.SelectedRotation, SharedData.SelectedPressure);
                pegInstallation.Show();
                this.Hide();
            }
        }

        private void SubTent3_Click(object sender, EventArgs e)
        {
            TMCanopyInstallation canopyInstallation = new TMCanopyInstallation(SharedData.SelectedCanopies);
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
        private void SubEmergNav1_Click(object sender, EventArgs e)
        {
            ENShelters shelters = new ENShelters();
            shelters.Show();
            this.Hide();

        }
        private void SubExplore2_Click(object sender, EventArgs e)
        {
            EXServices services = new EXServices();
            services.Show();
            this.Hide();
        }
        private void SubExplore3_Click(object sender, EventArgs e)
        {
            EXWeather weather = new EXWeather();
            weather.Show();
            this.Hide();

        }

        private void SubExplore1_Click(object sender, EventArgs e)
        {
            EXAttractions attractions = new EXAttractions();
            attractions.Show();
            this.Hide();
        }

        private void SubTent1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateCampsiteInfo(1);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateCampsiteInfo(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UpdateCampsiteInfo(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdateCampsiteInfo(4);
        }

        private PictureBox selectedPictureBox = null;

        private void changeOnHover(PictureBox pictureBox, Image normal, Image hover, int camp)
        {
            //hover
            //change if not selected
            pictureBox.MouseEnter += (sender, e) =>
            {
                if (selectedPictureBox != pictureBox)
                {
                    pictureBox.Image = hover;
                }
            };

            pictureBox.MouseLeave += (sender, e) =>
            {
                if (selectedPictureBox != pictureBox)
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
                clickedCamp = camp;
                if (clickedCamp != lastClickedCamp)
                {
                    button1.Text = "Select Location";
                    button1.BackColor = Color.FromArgb(219, 166, 30);
                    button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(172, 129, 22);
                    button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(147, 111, 20);
                    current.ForeColor = Color.FromArgb(219, 166, 30);
                }
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

        //method to update camp info
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
        private void SelectLocationClick(object sender, EventArgs e)
        {
            if (clickedCamp != 0)
            {
                hopeNotify1.Visible = true;
                button1.Text = "Selected Location";
                SharedData.SelectedLocation = clickedCamp;
                button1.BackColor = Color.FromArgb(19, 168, 36);
                button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 125, 28);
                button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 87, 28);
                current.ForeColor = Color.FromArgb(19, 168, 36);
                if (clickedCamp == 1)
                {
                    pictureBox1.Image = Properties.Resources.campsite1_g;

                }
                if (clickedCamp == 2)
                {
                    pictureBox2.Image = Properties.Resources.campsite2_g;
                }
                if (clickedCamp == 3)
                {
                    pictureBox3.Image = Properties.Resources.campsite3_g;
                }
                if (clickedCamp == 4)
                {
                    pictureBox4.Image = Properties.Resources.campsite4_g;
                }
                lastClickedCamp = clickedCamp;

            }
        }


        private void onlineHelp_Click(object sender, EventArgs e)
        {
            OnlineHelp help = new OnlineHelp();
            help.Show();

        }
    }

}
