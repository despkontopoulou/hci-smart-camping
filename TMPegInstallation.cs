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
        }


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                rotation.Text = angle + "%";
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
            }


        }
        private void pressurePlus_Click(object sender, EventArgs e)
        {
            string textbox = pressure.Text;
            string strPressure = textbox.Substring(0, textbox.Length - 1);
            int pressureInt = Convert.ToInt32(strPressure);

            if (pressureInt < 50)
            {
                pressureInt++;
                pressure.Text = pressureInt + "%";
            }


        }



        private void rotationMinus_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
