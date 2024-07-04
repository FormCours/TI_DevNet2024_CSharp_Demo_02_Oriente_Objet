using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_06_Interface.Interfaces
{
    public interface IEleve : IPersonne
    {
        void SuivreCours(string matiere);
        void Etudier(string matiere);
    }
}
