using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_04_Heritage.Models
{
    public class Formation
    {
        public string Nom { get; set; }
        public List<Personne> Personnes { get; set; } = new List<Personne>();
    }
}
