using ABI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmAjouterCollaborateur : ABI.frmCollaborateur
    {
        MCollaborateur nouvCollaborateur;
        //On a acces au collaborateur pour le recuperer depuis le controleur Ajouter
        public MCollaborateur NouvCollaborateur
        {
            get
            {
                return nouvCollaborateur;
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public frmAjouterCollaborateur()
        {
            InitializeComponent();
        }

        internal Boolean Control()
        {
            //code re retour
            Boolean code = true;

            if (!(Outils.EstEntier(this.txtMatricule.Text)))
            {
                code = false;
                MessageBox.Show("La matricule n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            if (!(Outils.EstEntier(this.txtSS.Text)))
            {
                code = false;
                MessageBox.Show("Le numéro de Securité Sociale n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            return code;
        }
        internal Boolean Instancie()
        {
            //Creation d'une refernece d'objet Collaborateur
            try
            {
                nouvCollaborateur = new MCollaborateur(
                        Int32.Parse(base.txtMatricule.Text.Trim()),
                        base.txtPrenom.Text,
                        base.txtNom.Text,
                        base.txtSS.Text);
                return true;
            }
            catch (Exception ex)
            {
                nouvCollaborateur = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout collaborateur");
                return false;
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
