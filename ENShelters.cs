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
    public partial class ENShelters : Form
    {
        public ENShelters()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SubPanelTent.Visible = false;
            SubPanelExplore.Visible = true;
            SubPanelEmergency.Visible = false;
            MainExploreNearby.Location = new Point(0, 38);
            SubPanelTent.Visible = false;
            SubPanelExplore.Visible = false;
            MainEmergencyNav.Location = new Point(0, 76);
            SubPanelEmergency.Location = new Point(0, 114);
            SubPanelEmergency.Visible = true;
        }
        private Boolean toggle_1 = false;
        private Boolean toggle_2 = false;
        private Boolean toggle_3 = false;
        private Boolean toggle_4 = false;

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

        private void SubTent3_Click(object sender, EventArgs e)
        {
            TMCanopyInstallation canopyInnstallation = new TMCanopyInstallation(SharedData.SelectedCanopies);
            canopyInnstallation.Show();
            this.Hide();
        }

        private void SubTent4_Click(object sender, EventArgs e)
        {
            TMLightingSettings lightingSettings = new TMLightingSettings();
            lightingSettings.Show();
            this.Hide();
        }

        private void SubExplore1_Click(object sender, EventArgs e)
        {
            EXAttractions attractions = new EXAttractions();
            attractions.Show();
            this.Hide();
        }

        private void SubEmergNav1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            toggle_1 = !toggle_1;
            shelter1.Visible = toggle_1;
            shelbtn1.Visible = toggle_1;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            toggle_2 = !toggle_2;
            shelter2.Visible = toggle_2;
            shelbtn2.Visible = toggle_2;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            toggle_3 = !toggle_3;
            shelter3.Visible = toggle_3;
            shelbtn3.Visible = toggle_3;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            toggle_4 = !toggle_4;
            shelter4.Visible = toggle_4;
            shelbtn4.Visible = toggle_4;
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
        private void MainExploreNearby_Click(object sender, EventArgs e)
        {
            UIHelper.TogglePanelVisibility(SubPanelExplore, SubPanelTent, SubPanelEmergency);
            placeButtons();
        }

        private void MainTentManagement_Click(object sender, EventArgs e)
        {
            UIHelper.TogglePanelVisibility(SubPanelTent, SubPanelExplore, SubPanelEmergency);
            placeButtons();
        }

        private void MainEmergencyNav_Click(object sender, EventArgs e)
        {
            UIHelper.TogglePanelVisibility(SubPanelEmergency, SubPanelExplore, SubPanelTent);
            placeButtons();
        }

        private void SubExplore3_Click(object sender, EventArgs e)
        {
            EXWeather weather = new EXWeather();
            weather.Show();
            this.Hide();
        }

        private void SubExplore2_Click(object sender, EventArgs e)
        {
            EXServices services = new EXServices();
            services.Show();
            this.Hide();
        }
    }
}
