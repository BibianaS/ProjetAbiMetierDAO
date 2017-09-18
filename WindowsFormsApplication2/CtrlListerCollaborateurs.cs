using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2;

namespace ABI
{
    class CtrlListerCollaborateurs
    {
        private MListeCollaborateurs listeCol;
        private MCollaborateur monCollabo;
        frmABI frmAbi;
        /// <summary>
        /// constructeur controleur liste collaborateurs
        /// </summary>
        public CtrlListerCollaborateurs(MDIParent1 parent)
        {
            init();
            //instanciation du frm principale 
            frmAbi = new frmABI(listeCol);
            frmAbi.MdiParent = parent;
            frmAbi.Show();
            this.frmAbi.afficherCollaborateurs();
            this.frmAbi.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.frmAbi.grdCollaborateurs.DoubleClick += new System.EventHandler(this.grdCollaborateurs_DoubleClick);
        }

        /// <summary>
        /// Initialisation jeu d'essai
        /// </summary>
        public void init()
        {
            //Initialise la collection de collaborateurs
            //Cree une liste et une dataTable dns MListeCollaborateurs
            this.listeCol = new MListeCollaborateurs();
            
            //Collaborateur essaie
            MCollaborateur collab1 = new MCollaborateur(32569,"thomas", "Depuis", "896");
            this.listeCol.Ajouter(collab1);
            //Collaborateur essaie
            MCollaborateur collab2 = new MCollaborateur(75965, "Roberto", "Carlos", "123");
            this.listeCol.Ajouter(collab2);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            CtrlNouveauCollaborateur nouvCol = new CtrlNouveauCollaborateur();

            //Si l'instanciation du collaborateur s'est bien passe
            if(nouvCol.ResultatDialog == System.Windows.Forms.DialogResult.OK)
            {
                //Ajouter a la liste de collaborateurs
                this.listeCol.Ajouter(nouvCol.UnCollaborateur);
                this.frmAbi.afficherCollaborateurs();
            }
        }

        private void grdCollaborateurs_DoubleClick(object sender, EventArgs e)
        {
            Int32 cleCollaborateur;
            cleCollaborateur = (Int32)this.frmAbi.grdCollaborateurs.CurrentRow.Cells[0].Value;
            monCollabo = listeCol.RestituerCollaborateur(cleCollaborateur);
            ctrlVisuModifCollaborateur ctrlFrmVisu = new ctrlVisuModifCollaborateur(monCollabo);
            this.frmAbi.afficherCollaborateurs();
        }
    }
}
