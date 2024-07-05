using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_07_Constructeur.Models
{
    public class Moto : Vehicule
    {
        public bool PorteBagage { get; set; }

        public Moto(string marque, string modele, decimal prix, int kilometrage, bool porteBagage = false)
            : base(marque, modele, prix, kilometrage)
        {
            Console.WriteLine("Ctor -> Moto(marque, modele, prix, kilometrage, porteBagage)");
            PorteBagage = porteBagage;
        }
    }
}
