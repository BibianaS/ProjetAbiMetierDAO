using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Temporaire
    {
        public Temporaire(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif): base (numContrat, qualification, salaireBrut, dateDebut)
        {
            this.DateFin = dateFin;
            this.Motf = motif;
        }

        public Temporaire() { }
    }
}
