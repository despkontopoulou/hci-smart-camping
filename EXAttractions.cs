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
    public partial class EXAttractions : Form
    {
        public EXAttractions()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SubPanelTent.Visible = false;
            SubPanelExplore.Visible = true;
            SubPanelEmergency.Visible = false;
            MainExploreNearby.Location = new Point(0, 38);
            SubPanelTent.Visible = false;
            SubPanelExplore.Location = new Point(0, 76);
            MainEmergencyNav.Location = new Point(0, 196);
            SubPanelEmergency.Visible = false;

        }
        public Boolean toggle_archeo = false;
        public Boolean toggle_waterfall = false;
        public Boolean toggle_riverbank = false;

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

        private void MainExploreNearby_Click(object sender, EventArgs e)
        {

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

        private void SubExplore1_Click(object sender, EventArgs e)
        {

        }

        private void archaeo_btn_Click(object sender, EventArgs e)
        {
            toggle_archeo = !toggle_archeo;
            archeo_window.Visible = toggle_archeo;
            send_archeo.Visible = toggle_archeo;
        }
        private void riverbank_btn_Click(object sender, EventArgs e)
        {
            toggle_riverbank = !toggle_riverbank;
            riverbank_window.Visible = toggle_riverbank;
            send_riverbank.Visible = toggle_riverbank;
        }
        private void waterfall_btn_Click(object sender, EventArgs e)
        {
            toggle_waterfall = !toggle_waterfall;
            waterfall_window.Visible = toggle_waterfall;
            send_waterfall.Visible = toggle_waterfall;
        }
    }
}
