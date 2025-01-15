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
    public partial class TMCanopyInstallation : Form
    {
        public TMCanopyInstallation(Boolean canopiesInstalled)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SubPanelTent.Visible = true;
            SubPanelExplore.Visible = false;
            SubPanelEmergency.Visible = false;
            MainExploreNearby.Location = new Point(0, 240);
            MainEmergencyNav.Location = new Point(0, 280);
            if (canopiesInstalled)
            {
                hopeToggle1.Checked = true;
                hopeToggle1.CheckState = CheckState.Checked;
                status1.Text = "Retraction of canopies not suggested";
                this.BackgroundImage = Properties.Resources.Group_2093;
            }
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

        private void SubTent3_Click(object sender, EventArgs e)
        {

        }

        private void hopeToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeToggle1.CheckState == CheckState.Unchecked)
            {
                status1.Text = "Deployment of canopies suggested  ";
                this.BackgroundImage = Properties.Resources.Group_364;
                SharedData.SelectedCanopies = false;

            }
            else
            {
                status1.Text = "Retraction of canopies not suggested";
                this.BackgroundImage = Properties.Resources.Group_2093;
                SharedData.SelectedCanopies = true;
            }
        }


        private void SubExplore1_Click(object sender, EventArgs e)
        {
            EXAttractions attractions = new EXAttractions();
            attractions.Show();
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
        private void SubEmergNav1_Click(object sender, EventArgs e)
        {
            ENShelters shelters = new ENShelters();
            shelters.Show();
            this.Hide();


        }
        private void onlineHelp_Click(object sender, EventArgs e)
        {
            OnlineHelp help = new OnlineHelp();
            help.Show();

        }
    }
}
