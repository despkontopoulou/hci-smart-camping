using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTent.Helpers;

public static class SharedData
{
    public static int SelectedLocation { get; set; }
    public static string SelectedRotation {  get; set; }
    public static string SelectedPressure { get; set; }

    public static Boolean SelectedCanopies {  get; set; }

}
