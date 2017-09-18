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
            this.txtMatricule.Text = monCollabo.Matricule.ToString();
            this.txtPrenom.Text = monCollabo.PrenomCollabo;
            this.txtNom.Text = monCollabo.NomCollabo;
            this.txtSS.Text = monCollabo.NumeroSS;

            this.grdContrats.DataSource = monCollabo.ListerContrats();
        }
               
        internal void ModifCollaborateur()
        {
            try
            {
                this.monCollabo.Matricule = Int32.Parse(txtMatricule.Text);
                this.monCollabo.PrenomCollabo = txtPrenom.Text;
                this.monCollabo.NomCollabo = txtNom.Text;
                this.monCollabo.NumeroSS = txtSS.Text;
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
