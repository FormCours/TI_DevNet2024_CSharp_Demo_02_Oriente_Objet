using Demo_OO_04_Heritage.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_04_Heritage.Models
{
    public class Apprenant : Personne
    {
        public void Apprendre(string matiere)
        {
            if(Random.Shared.Next(10) > 3)
            {
                Console.WriteLine($"{Prenom} {Nom} travail sur {matiere}");
            }
            else
            {
                Console.WriteLine($"{Prenom} {Nom} glandouille 🍻");
            }
        }
    }
}
