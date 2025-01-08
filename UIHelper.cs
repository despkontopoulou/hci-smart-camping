using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTent.Helpers
{
    public static class UIHelper
    {
        public static void SetupHoverEffect(PictureBox picturebox, Image normal, Image hover, Action onClick = null)
        {
            picturebox.MouseEnter += (sender, e) => picturebox.Image = hover;
            picturebox.MouseLeave += (sender, e) => picturebox.Image = normal;//handle image hovering

            if (onClick != null) {
                picturebox.Click += (sender, e) => onClick();//put onclick method
            }
        }

        public static void TogglePanelVisibility(Panel panelToToggle, params Panel[] otherPanels)
        { 
        
            panelToToggle.Visible = !panelToToggle.Visible;
            if (panelToToggle.Visible) {
                foreach (var panel in otherPanels) {
                    panel.Visible = false;
                }
            }
        }

        public static void AdjustButtons(Control button, Point visibleLocation, Point hiddenLocation, bool isVisible) 
        { 
            button.Location=isVisible ? visibleLocation : hiddenLocation;
        }

       
    }
}
