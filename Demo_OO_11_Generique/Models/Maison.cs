using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_11_Generique.Models
{
    public class Maison
    {
        public string Couleur { get; set; }
        public int NbPiece { get; set; }

        public Maison(string couleur, int nbPiece)
        {
            Couleur = couleur;
            NbPiece = nbPiece;
        }
    }
}
