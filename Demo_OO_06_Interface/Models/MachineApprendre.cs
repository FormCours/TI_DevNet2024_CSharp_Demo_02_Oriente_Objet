using Demo_OO_06_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_06_Interface.Models
{
    public class MachineApprendre : IProf
    {
        public string Nom
        {
            get { return "La machine à apprendre ♥"; }
        }

        public void DonnerCours(string matiere)
        {
            Console.WriteLine($"La machine donne cours de {matiere}");

            if (Random.Shared.Next(5) == 0)
            {
                Console.WriteLine($"La machine \"corrige\" les erreurs de l'apprenant");
            }
        }
    }
}
