using ABI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmContrat : Form
    {
        MContrat nouveauContrat;
        private String type = "CDI";
        
        public MContrat NouveauContrat
        {
            get
            {
                return nouveauContrat;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public frmContrat()
        {
           InitializeComponent();
           init();
        }

        /// <summary>
        /// Initialise toutes les casse à enabled
        /// </summary>
        private void init()
        {
            lblDateFin.Enabled = false;
            dateTimeFin.Enabled = false;
            lblMotif.Enabled = false;
            txtMotif.Enabled = false;
            lblAgenceInterim.Enabled = false;
            txtAgence.Enabled = false;
            lblIndemnisation.Enabled = false;
            txtIndemnisation.Enabled = false;
            lblEcole.Enabled = false;
            txtEcole.Enabled = false;
            lblMission.Enabled = false;
            txtMission.Enabled = false;
        }

        /// <summary>
        /// rbt Interim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtInterim_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtInterim.Checked)
            {
                lblDateFin.Enabled = true;
                dateTimeFin.Enabled = true;
                lblMotif.Enabled = true;
                txtMotif.Enabled = true;
                lblAgenceInterim.Enabled = true;
                txtAgence.Enabled = true;
                lblIndemnisation.Enabled = true;
                txtIndemnisation.Enabled = true;
            }
            else
            {
                lblDateFin.Enabled = false;
                dateTimeFin.Enabled = false;
                lblMotif.Enabled = false;
                txtMotif.Enabled = false;
                lblAgenceInterim.Enabled = false;
                txtAgence.Enabled = false;
                lblIndemnisation.Enabled = false;
                txtIndemnisation.Enabled = false;
            }
        }

        /// <summary>
        /// rbt CDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtCDD_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtCDD.Checked)
            {
                lblDateFin.Enabled = true;
                dateTimeFin.Enabled = true;
                lblMotif.Enabled = true;
                txtMotif.Enabled = true;
            }
            else
            {
                lblDateFin.Enabled = false;
                dateTimeFin.Enabled = false;
                lblMotif.Enabled = false;
                txtMotif.Enabled = false;
            }
        }

        /// <summary>
        /// rbt Stage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtStage_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtStage.Checked)
            {
                lblDateFin.Enabled = true;
                dateTimeFin.Enabled = true;
                lblEcole.Enabled = true;
                txtEcole.Enabled = true;
                lblMission.Enabled = true;
                txtMission.Enabled = true;
            }
            else
            {
                lblDateFin.Enabled = false;
                dateTimeFin.Enabled = false;
                lblEcole.Enabled = false;
                txtEcole.Enabled = false;
                lblMission.Enabled = false;
                txtMission.Enabled = false;
            }
        }

        internal Boolean Controle()
        {
            Boolean code = true;
            if (!(Outils.EstEntier(this.txtNumContrat.Text))) // appel fonction générique de contrôle
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("le numero de contrat n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            return code;
        }


        /// <summary>
        /// Instanciation d'un contrat interim
        /// </summary>
        /// <returns></returns>
        internal Boolean Instancie()
        {
            try
            {
                //Instanciation contrat interim
                if (this.rbtInterim.Checked)
                {
                    this.type = "Interim"; 
                    //Instanciation du contrat Interim
                    nouveauContrat = new MInterim(
                        Int32.Parse(txtNumContrat.Text),
                        txtQualification.Text,
                        dateTimeDebut.Value.Date,
                        dateTimeFin.Value.Date,
                        txtMotif.Text,
                        txtAgence.Text,
                        Decimal.Parse(txtIndemnisation.Text));
                }
                //Instanciation contrat interim
                else if (this.rbtCDD.Checked)
                {
                    this.type = "CDD";
                    //Instanciation du contrat Interim
                    nouveauContrat = new MCdd(Int32.Parse(txtNumContrat.Text),
                        txtQualification.Text,
                        Decimal.Parse(txtSalaireBrut.Text),
                        dateTimeDebut.Value.Date,
                        dateTimeFin.Value.Date,
                        txtMotif.Text);
                }
                else if (this.rbtStage.Checked)
                {
                    this.type = "Stage";
                    //Instanciation du contrat Interim
                    nouveauContrat = new MStagiaire(
                        Int32.Parse(txtNumContrat.Text),
                        txtQualification.Text,
                        Decimal.Parse(txtSalaireBrut.Text),
                        txtMission.Text,
                        dateTimeDebut.Value.Date,
                        dateTimeFin.Value.Date,
                        txtEcole.Text);
                }
                else
                {
                    this.type = "CDI";
                    nouveauContrat = new MCdi(
                        Int32.Parse(txtNumContrat.Text),
                        txtQualification.Text,
                        Decimal.Parse(txtSalaireBrut.Text),
                        dateTimeDebut.Value.Date
                        );
                }
                return true;
            }
            catch (Exception ex)
            {
                nouveauContrat = null;
                MessageBox.Show("Erreur : \n" +ex.Message, "Ajout d'un contrat interim");
                return false;
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDateFin_Click(object sender, EventArgs e)
        {
        }
    }
}
