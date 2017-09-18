using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{


    class CtrlVisuContrat
    {

        MContrat leContrat;
        frmVisuContrat frmContrat;

        public CtrlVisuContrat (MContrat unContrat)
        {
            this.leContrat = unContrat;
            frmContrat = new frmVisuContrat(leContrat);
            frmContrat.ShowDialog();
        }



    }
}
