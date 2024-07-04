using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_06_Interface.Interfaces
{
    public interface IProf
    {
        string Nom { get; }

        void DonnerCours(string matiere);
    }
}
