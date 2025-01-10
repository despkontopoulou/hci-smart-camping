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
    public partial class EXWeather : Form
    {
        public EXWeather()
        {
            InitializeComponent();
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
    }
}
