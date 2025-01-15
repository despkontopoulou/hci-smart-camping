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
    public partial class OnlineHelp : Form
    {
        private List<Image> pdfImages = new List<Image>();
        private int currentPageIndex = 0;
        public OnlineHelp()
        {
            InitializeComponent();
            LoadImages();
            DisplayCurrent();

        }
        private void LoadImages()
        {
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0001);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0002);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0003);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0004);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0005);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0006);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0007);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0008);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0009);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0010);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0011);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0012);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0013);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0014);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0015);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0016);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0017);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0018);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0019);
            pdfImages.Add(Properties.Resources.SmartCamping_UserManual_page_0020);
        }
        private void DisplayCurrent()
        {
            if (currentPageIndex >= 0 && currentPageIndex < pdfImages.Count)
            {
                pictureBox1.Image = pdfImages[currentPageIndex];
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < pdfImages.Count - 1)
            {
                currentPageIndex++;
                DisplayCurrent();
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                DisplayCurrent();
            }
        }
    }
}
