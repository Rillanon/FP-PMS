using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace FP_PMS.Ex
{
    class staticProperties
    {
        public static int? userLevel { get; set; }
        public static string userName { get; set; }
        public static string connectionString { get; set; }
        public static List<Form> currentActiveForms { get; set; }
        public static Form lastForm { get; set; }
    }
}
