using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_05_Static.Tools
{
    public static class ExempleTool
    {
        public static int Valeur { get; set; }

        public static double Round(double val)
        {
            return Convert.ToInt32(val);
        }
    }
}
