using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial  class Stage
    {
        public Stage(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif, String ecole, String mission):base (numContrat, qualification, salaireBrut, dateDebut, dateFin, motif)
        {
            this.Ecole = ecole;
            this.Mission = mission;
        }
        public Stage() { }
    }
}
