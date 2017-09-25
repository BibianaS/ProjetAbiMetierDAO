using ABI;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace ABI
{
    class CtrlNouveauCollaborateur
    {
        frmAjouterCollaborateur frmAjouter;
        private DialogResult resultatDialog;
        private MCollaborateur unCollaborateur;
        private MContrat leContrat;
        private CtrlNouvContrat nouvContrat;



        /// <summary>
        /// Constructeur du controleur pour la création d'un nouveau collaboateur
        /// </summary>
        public CtrlNouveauCollaborateur()
        {
            //Affichag du frm Ajouter
            frmAjouter = new frmAjouterCollaborateur();
            this.frmAjouter.Text = "Ajouter un Nouveau Collaborateur";

            //Btn Ajouter un contrat
            this.frmAjouter.btnAjouterContrat.Click += new System.EventHandler(this.btnAjouterContrat_Click);
            this.frmAjouter.btnOK.Enabled = false;
            ////Btn OK
            this.frmAjouter.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            resultatDialog = this.frmAjouter.ShowDialog();
                    }


        //Création d'un collaborateur
        private void btnOK_Click(object sender, EventArgs e)
        {
            //Démande au form de contrôler et instancier un collaborateur 
            if (this.frmAjouter.Control())
            {
                if (this.frmAjouter.Instancie())
                {
                    this.frmAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.unCollaborateur = this.frmAjouter.NouvCollaborateur;
                    //Impact su la BDD. 
                    MCollaborateurDAOEFStatic.InserenouveauCollaborateur(unCollaborateur, leContrat);
                    unCollaborateur.AjouterContrat(leContrat);
                    MessageBox.Show("Le collaborateur a bien été créé");
                    this.resultatDialog = this.frmAjouter.DialogResult;
                }
                else
                {
                    this.resultatDialog = DialogResult.No;
                }
            }
        }

        //Création d'un nouveau contrat
        private void btnAjouterContrat_Click(object sender, EventArgs e)
        {
            nouvContrat = new CtrlNouvContrat();

            //Si un nouveau contrat a été crée
            if (nouvContrat.Resultat == DialogResult.OK)
            {
                //le bouton OK pour créer un collaborateur devient visible
                this.frmAjouter.btnOK.Enabled = true;
                //on récupère la reference du contrat
                this.leContrat = this.nouvContrat.LeContrat;
            }
        }
        //Acccesseur pour un collaborateur
        public MCollaborateur UnCollaborateur
        {
            get
            {
                return unCollaborateur;
            }
        }

        public DialogResult ResultatDialog
        {
            get
            {
                return resultatDialog;
            }
        }
    }
}
