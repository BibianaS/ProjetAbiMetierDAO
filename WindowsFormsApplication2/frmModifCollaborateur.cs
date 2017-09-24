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
    public partial class frmModification : ABI.frmCollaborateur
    {
        private MCollaborateur monCollabo;
        public frmModification(MCollaborateur unCollabo)
        {
            InitializeComponent();
            this.monCollabo = unCollabo;
            init();
        }

        public void init()
        {
            this.btnAjouterPhoto.Text = "Modifier la photo";
            this.txtMatricule.Text = monCollabo.Matricule.ToString();
            this.txtPrenom.Text = monCollabo.PrenomCollaborateur;
            this.txtNom.Text = monCollabo.NomCollaborateur;
            this.txtSecu.Text = monCollabo.NumeroSecu;

            this.grdContrats.DataSource = monCollabo.ListerContrats();
        }
               
        internal void ModifCollaborateur()
        {
            try
            {
                this.monCollabo.Matricule = Int32.Parse(txtMatricule.Text);
                this.monCollabo.PrenomCollaborateur = txtPrenom.Text;
                this.monCollabo.NomCollaborateur = txtNom.Text;
                this.monCollabo.NumeroSecu = txtSecu.Text;
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur : \n" + ex.Message, "Modification Collaborateur");
            }            
        }

        private void btnRevenir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
