using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_01_Encapsulation.Models
{
    internal class House
    {
        public string Address { get; set; }
        public int NbRoom { get; set; }
        public bool HasGarden { get; set; }
        public PersonV2 Proprio { get; set; }
    }
}
