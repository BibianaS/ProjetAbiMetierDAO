using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace ABI
{
    class CtrlNouvContrat
    {
        private frmContrat frmNouvContrat;
        private MContrat leContrat;
        private DialogResult resultat;

        public CtrlNouvContrat()
        {
            frmNouvContrat = new frmContrat();

            this.frmNouvContrat.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            resultat = this.frmNouvContrat.ShowDialog();

            //en fin de dialogue recuperer la ref de l'objet
            this.leContrat = frmNouvContrat.NouveauContrat;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (frmNouvContrat.Controle())
            {
                if (frmNouvContrat.Instancie())
                {
                    frmNouvContrat.DialogResult = DialogResult.OK;
                    this.resultat = DialogResult.OK;
                }
                else
                {
                    this.resultat = DialogResult.Cancel;
                }
            }
        }

        public DialogResult Resultat
        {
            get
            {
                return resultat;
            }
        }

        //Accesseur à la ref du contrat
        public MContrat LeContrat
        {
            get
            {
                return this.leContrat;
            }
        }
    }
}
