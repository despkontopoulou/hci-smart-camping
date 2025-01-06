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
                MainEmergencyNav.Location = new Point(0, 236);
            }
            if (SubPanelEmergency.Visible)
            {
                SubPanelEmergency.Location = new Point(0, 114);
            }

        }

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
            energy.Hide();
        }

        private void SubEmergNav2_Click(object sender, EventArgs e)
        {

        }

        private void TMLocationSelection_Load_1(object sender, EventArgs e)
        {

        }

        private void SubTent1_Click(object sender, EventArgs e)
        {

        }
    }
}
