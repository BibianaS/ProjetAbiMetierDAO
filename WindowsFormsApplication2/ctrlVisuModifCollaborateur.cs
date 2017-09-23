using DAO;
using ABI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ctrlVisuModifCollaborateur
    {
        MCollaborateur monCollaborateur;
        frmModification frmModif;
               
        public ctrlVisuModifCollaborateur(MCollaborateur unCollaborateur)
        {
            this.monCollaborateur = unCollaborateur;
            MContratDAOEFStatic.InstancieUnContrat(unCollaborateur);
            frmModif = new frmModification(this.monCollaborateur);            
            this.frmModif.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.frmModif.grdContrats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContrats_DoubleClick);
            if (this.frmModif.ShowDialog() == DialogResult.OK)
            {
                MCollaborateurDAOEFStatic.ModifCollaborateur(this.monCollaborateur);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmModif.ModifCollaborateur();
        }

        private void grdContrats_DoubleClick(object sender, EventArgs e)
        {
            MContrat unContrat; 
            Int32 cle;
            cle = (Int32)this.frmModif.grdContrats.CurrentRow.Cells[0].Value;
            unContrat = monCollaborateur.RestituerContrat(cle);
            CtrlVisuContrat ctrlContrat = new CtrlVisuContrat(unContrat); 
        }
    }
}
