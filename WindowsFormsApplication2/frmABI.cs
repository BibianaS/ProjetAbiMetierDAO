using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ABI
{
    public partial class frmABI : Form
    {
        MListeCollaborateurs listeCollaborateurs;

        public frmABI(MListeCollaborateurs liste)
        {
            InitializeComponent();
            this.listeCollaborateurs = liste;
        }

        /// <summary>
        /// affichage des collaborateurs dans la data grid view
        /// </summary>
        public void afficherCollaborateurs()
        {
            this.grdCollaborateurs.DataSource =  listeCollaborateurs.ListerCollaborateurs();
            this.grdCollaborateurs.Refresh();
        }

        /// <summary>
        /// Methode fermeture du frm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
