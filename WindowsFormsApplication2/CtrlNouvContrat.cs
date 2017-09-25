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

        /// <summary>
        /// Constructeur du controleur d'un nouveau contrat
        /// </summary>
        public CtrlNouvContrat()
        {
            frmNouvContrat = new frmContrat();
            this.frmNouvContrat.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            resultat = this.frmNouvContrat.ShowDialog();
        }

        /// <summary>
        /// Enregistrement du nouveau contrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (frmNouvContrat.Controle())
            {
                if (frmNouvContrat.Instancie())
                {
                    frmNouvContrat.DialogResult = DialogResult.OK;
                    //recupere la reference du contrat
                    this.leContrat = frmNouvContrat.NouveauContrat;
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

        //Accesseur du contrat
        public MContrat LeContrat
        {
            get
            {
                return this.leContrat;
            }
        }
    }
}
