using DAO;
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
            //Instanciation d'une liste de collaborateurs
            //
            init();
            //instanciation du frm principale 
            frmAbi = new frmABI(listeCol);
            frmAbi.MdiParent = parent;
            this.frmAbi.afficherCollaborateurs();
            this.frmAbi.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.frmAbi.grdCollaborateurs.DoubleClick += new System.EventHandler(this.grdCollaborateurs_DoubleClick);
            frmAbi.Show();
        }

        /// <summary>
        ///Instanciation d'une liste de collaborateurs
        ///Utilise une méthode de la class DAO pour recuperer les valeurs de la BDD et creer une liste
        /// </summary>
        public void init()
        {
            //Instancie une collection de collaborateurs
            //Cree une liste et une dataTable dns MListeCollaborateurs
            this.listeCol = new MListeCollaborateurs();
            MCollaborateurDAOEFStatic.InstancieCollaborateur(this.listeCol);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            CtrlNouveauCollaborateur nouvCol = new CtrlNouveauCollaborateur();

            //Si l'instanciation du collaborateur s'est bien passe
            if (nouvCol.ResultatDialog == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    //Ajouter a la liste de collaborateurs
                    this.listeCol.Ajouter(nouvCol.UnCollaborateur);
                }
                catch (Exception ex)
                {
                    // this.frmAbi.L
                    throw new Exception("Ajouter click erreur");
                }

                //mettre à jour la BDD à l'aide d'un dbContext
                MCollaborateurDAOEFStatic.InsereCollaborateur(nouvCol.UnCollaborateur);

                //régènerer l'affichage du dataGridView
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
