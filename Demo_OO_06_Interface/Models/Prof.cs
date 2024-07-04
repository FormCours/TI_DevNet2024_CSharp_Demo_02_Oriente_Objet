using Demo_OO_06_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_06_Interface.Models
{
    public class Prof : Personne, IProf
    {
        public void DonnerCours(string matiere)
        {
            Console.WriteLine($"{NomComplet} donne cours de {matiere}");
        }
    }
}
