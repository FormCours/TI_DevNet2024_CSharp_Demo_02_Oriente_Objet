using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_02_Indexeur.Models
{
    public class Commune
    {
        private string _codePostal;

        public string CodePostal 
        {
            get
            {
                return _codePostal;
            }
            set
            {
                _codePostal = value;
            }
        }
        public string Nom {  get; set; }
        public int NbHabitant  { get; set; }
    }
}
