using Demo_OO_04_Heritage.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_04_Heritage.Models
{
    public class Formateur : Personne
    {
        public string Specialisation { get; set; }

        public void DonnerCours(string matiere)
        {
            Console.WriteLine($"{Prenom} {Nom} donne cours de {matiere}");
        }

        public override void Dormir(int nbHeure)
        {
            int nbHeureCours = 0;
            if (Random.Shared.Next(100) <= 5)
            {
                nbHeureCours = Random.Shared.Next(2, nbHeure);
                Console.WriteLine($"{Prenom} {Nom} prepare son cours durant {nbHeureCours} heures");
            }
            base.Dormir(nbHeure - nbHeureCours);
        }
    }
}
