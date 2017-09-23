using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Interim
    {
        public Interim(Int32 numContrat, String qualification,  DateTime dateDebut, DateTime dateFin, String motif, String agence, Decimal indemnites): base (numContrat, qualification, dateDebut, dateFin, motif)
        {
            
            this.AgenceInterim = agence;
            this.Indemnites = indemnites;
        }
        public Interim() { }
    }
}
