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
    public partial class EXServices : Form
    {
        public EXServices()
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
        private void SubTent5_Click(object sender, EventArgs e)
        {
            TMEnergy energy = new TMEnergy();
            energy.Show();
            this.Hide();

        }

        private void SubExplore1_Click(object sender, EventArgs e)
        {
            EXAttractions attractions = new EXAttractions();
            attractions.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ordered1;
            panel1.Visible = false;
            plus.Visible = false;
            minus.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            string textbox = quantity.Text;
            string strQuant = textbox.Substring(0, textbox.Length);
            int quant = Convert.ToInt32(strQuant);

            if (quant > 1)
            {
                quant--;
                quantity.Text = quant + "";
                total.Text = quant * 3 + "€";
            }

        }
        private void plus_Click(object sender, EventArgs e)
        {
            string textbox = quantity.Text;
            string strQuant = textbox.Substring(0, textbox.Length);
            int quant = Convert.ToInt32(strQuant);

            if (quant < 5)
            {
                quant++;
                quantity.Text = quant + "";
                total.Text = quant * 3 + "€";

            }


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

        private void SubEmergNav1_Click(object sender, EventArgs e)
        {
            ENShelters shelters = new ENShelters();
            shelters.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            message_box.Text = "";
            hopeNotify1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "Pending";
            button7.BackColor = Color.BurlyWood;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Pending";
            button6.BackColor = Color.BurlyWood;
        }
        private void onlineHelp_Click(object sender, EventArgs e)
        {
            OnlineHelp help = new OnlineHelp();
            help.Show();

        }
    }
}
