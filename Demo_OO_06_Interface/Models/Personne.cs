using Demo_OO_06_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_06_Interface.Models
{
    public class Personne : IPersonne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string NomComplet
        {
            get { return Prenom + " " + Nom; }
        }

        public void Dormir()
        {
            Console.WriteLine($"{NomComplet} dort...");
        }
    }
}
