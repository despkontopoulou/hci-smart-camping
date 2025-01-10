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

namespace SmartTent
{
    public partial class TMPegInstallation : Form
    {
        public TMPegInstallation()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SubPanelTent.Visible = true;
            SubPanelExplore.Visible = false;
            SubPanelEmergency.Visible = false;
            MainExploreNearby.Location = new Point(0, 240);
            MainEmergencyNav.Location = new Point(0, 280);
            lastRotation = "";
            lastPressure = "";

        }
        public TMPegInstallation(string selectedRotation, string selectedPressure)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SubPanelTent.Visible = true;
            SubPanelExplore.Visible = false;
            SubPanelEmergency.Visible = false;
            MainExploreNearby.Location = new Point(0, 240);
            MainEmergencyNav.Location = new Point(0, 280);

            lastRotation = selectedRotation;
            lastPressure = selectedPressure;
            rotation.Text = lastRotation;
            pressure.Text = lastPressure;
            updateCurrentInstallation();

        }
        public string lastRotation;
        public string lastPressure;

        private void SubTent2_Click(object sender, EventArgs e)
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

        private void SubTent1_Click(object sender, EventArgs e)
        {
            if (SharedData.SelectedLocation > 0)
            {
                TMLocationSelection locationSelection = new TMLocationSelection(SharedData.SelectedLocation);
                locationSelection.Show();
                this.Hide();
            }
            else
            {
                TMLocationSelection locationSelection = new TMLocationSelection();
                locationSelection.Show();
                this.Hide();
            }
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

        private void MainExploreNearby_Click(object sender, EventArgs e)
        {
            SubPanelExplore.Visible = !SubPanelExplore.Visible;
            if (SubPanelExplore.Visible)
            {
                SubPanelTent.Visible = false;
                SubPanelEmergency.Visible = false;
            }
            placeButtons();
        }

        private void MainTentManagement_Click(object sender, EventArgs e)
        {
            SubPanelTent.Visible = !SubPanelTent.Visible;//toggle buttons
            if (SubPanelTent.Visible)
            {
                SubPanelExplore.Visible = false;
                SubPanelEmergency.Visible = false;
            }
            placeButtons();
        }

        private void MainEmergencyNav_Click(object sender, EventArgs e)
        {
            SubPanelEmergency.Visible = !SubPanelEmergency.Visible;
            if (SubPanelEmergency.Visible)
            {
                SubPanelTent.Visible = false;
                SubPanelExplore.Visible = false;
            }
            placeButtons();
        }

        private void rotationMinus_Click(object sender, EventArgs e)
        {
            string textbox = rotation.Text;
            string strAngle = textbox.Substring(0, textbox.Length - 1);
            int angle = Convert.ToInt32(strAngle);

            if (angle > 30)
            {
                angle--;
                rotation.Text = angle + "°";
                updateCurrentInstallation();
            }

        }
        private void rotationPlus_Click(object sender, EventArgs e)
        {
            string textbox = rotation.Text;
            string strAngle = textbox.Substring(0, textbox.Length - 1);
            int angle = Convert.ToInt32(strAngle);

            if (angle < 50)
            {
                angle++;
                rotation.Text = angle + "°";
                updateCurrentInstallation();
            }


        }

        private void pressureMinus_Click(object sender, EventArgs e)
        {
            string textbox = pressure.Text;
            string strPressure = textbox.Substring(0, textbox.Length - 1);
            int pressureInt = Convert.ToInt32(strPressure);

            if (pressureInt > 50)
            {
                pressureInt--;
                pressure.Text = pressureInt + "%";
                updateCurrentInstallation();
            }


        }
        private void pressurePlus_Click(object sender, EventArgs e)
        {
            string textbox = pressure.Text;
            string strPressure = textbox.Substring(0, textbox.Length - 1);
            int pressureInt = Convert.ToInt32(strPressure);

            if (pressureInt < 100)
            {
                pressureInt++;
                pressure.Text = pressureInt + "%";
                updateCurrentInstallation();
            }


        }
        private void updateCurrentInstallation()
        {
            currentInstallation.Text = rotation.Text + ", " + pressure.Text;
            UpdateInstallStatus();
        }
        private void UpdateInstallStatus()
        {
            if (rotation.Text == "45°" && pressure.Text == "100%")
            {
                installationState.Text = "Optimal";
                installationState.ForeColor = Color.MediumSeaGreen;
            }
            else
            {
                installationState.Text = "Not Optimal";
                installationState.ForeColor = Color.Khaki;
            }

            if (rotation.Text != lastRotation || pressure.Text != lastPressure)
            {
                InstallPegsButton.Text = "Install Pegs";
                InstallPegsButton.BackColor = Color.FromArgb(219, 166, 30);
                InstallPegsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 160, 66);
                InstallPegsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 137, 64);

            }
            else
            {
                InstallPegsButton.Text = "Selected Installation";
                InstallPegsButton.BackColor = Color.Green;
                InstallPegsButton.FlatAppearance.MouseOverBackColor = Color.Green;
                InstallPegsButton.FlatAppearance.MouseDownBackColor = Color.Green;
            }
        }

        private void InstallPegsButton_Click(object sender, EventArgs e)
        {
            if (SharedData.SelectedLocation > 0)
            {
                hopeNotify1.Visible = false;
                string currentRotation = rotation.Text;
                string currentPressure = pressure.Text;
                if (currentRotation != lastRotation || currentPressure != lastPressure)
                {
                    SharedData.SelectedRotation = currentRotation;
                    SharedData.SelectedPressure = currentPressure;
                    lastRotation = currentRotation;
                    lastPressure = currentPressure;
                    UpdateInstallStatus();

                }
                //if its not changed we dont need to do anything
            }
            else
            {
                hopeNotify1.Visible = true;
            }
        }
    }
}
