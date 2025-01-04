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
            MainExploreNearby.Location = new Point(0, 214);
            MainEmergencyNav.Location = new Point(0, 245);
        }


        private void button3_Click(object sender, EventArgs e)
        {

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
                MainExploreNearby.Location = new Point(0, 214);
                MainEmergencyNav.Location = new Point(0, 245);

            }
            if (!SubPanelTent.Visible)
            {
                MainExploreNearby.Location = new Point(0, 32);
                MainEmergencyNav.Location = new Point(0, 65);

            }

            if (SubPanelExplore.Visible)
            {
                MainExploreNearby.Location = new Point(0, 32);
                SubPanelExplore.Location = new Point(34, 245);
                MainEmergencyNav.Location = new Point(0, 203);
            }
            if (SubPanelEmergency.Visible)
            {
                SubPanelEmergency.Location = new Point(0, 98);
            }

        }

        private void TMLocationSelection_Load(object sender, EventArgs e)
        {

        }
    }
}
