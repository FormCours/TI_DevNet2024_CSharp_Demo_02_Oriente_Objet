using Demo_OO_06_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_06_Interface.Models
{
    public class Eleve : Personne, IEleve
    {
        public void Etudier(string matiere)
        {
            Console.WriteLine($"{NomComplet} etudie {matiere}");
        }

        public void SuivreCours(string matiere)
        {
            Console.WriteLine($"{NomComplet} suit un cours de {matiere}");
        }
    }
}
