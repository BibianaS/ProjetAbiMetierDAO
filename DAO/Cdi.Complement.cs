using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class CDI
    {
        public CDI(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut) : base(numContrat, qualification, salaireBrut, dateDebut)
        {
           
        }

        public CDI()
        {
        }
    }
}
