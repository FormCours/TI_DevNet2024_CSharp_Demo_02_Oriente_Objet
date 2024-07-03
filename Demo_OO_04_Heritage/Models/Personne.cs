using Demo_OO_04_Heritage.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_04_Heritage.Models
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomComplet 
        { 
            get { return Prenom + " " + Nom.ToUpper(); }
        }

        public DateTime DateNaiss { get; set; }
        public Gender Genre { get; set; }

        public virtual void Dormir(int nbHeure)
        {
            Console.WriteLine($"{Prenom} {Nom} dort {nbHeure} heure(s)");
        }
    }
}
