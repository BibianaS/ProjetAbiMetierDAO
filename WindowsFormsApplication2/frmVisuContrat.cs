using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public partial class frmVisuContrat : WindowsFormsApplication2.frmContrat
    {
        MContrat leContrat;

        public frmVisuContrat(MContrat unContrat)
        {
            leContrat = unContrat;
            InitializeComponent();
            init();
        }
        public void init()
        {

            this.txtNumContrat.Text = leContrat.NumeroContrat.ToString();
            this.txtNumContrat.Enabled = false;
            this.dateTimeDebut.Enabled = false;
            this.dateTimeFin.Enabled = false;
            this.txtQualification.Text = leContrat.Qualification;
            this.txtQualification.Enabled = false;
            this.txtSalaireBrut.Text = leContrat.SalaireBrut.ToString();
            this.txtSalaireBrut.Enabled = false;
            this.txtMotif.Enabled = false;
            this.txtAgence.Enabled = false;
            this.txtIndemnisation.Enabled = false;
            this.txtEcole.Enabled = false;
            this.txtMission.Enabled = false;



            if (leContrat is MCdi)
            {
                MCdi cdi = leContrat as MCdi;
                affichageCDI(cdi);
            }
            if (leContrat is MCdd)
            {
                MCdd cdd = leContrat as MCdd;
                affichageCDD(cdd);
            }
            if (leContrat is MInterim)
            {
                MInterim inter = leContrat as MInterim;
                affichageInterim(inter);
            }
            if (leContrat is MStagiaire)
            {
                MStagiaire stag = leContrat as MStagiaire; 
                affichageStage(stag);
            }


        }

        public void affichageCDI(MCdi cdi)
        {
            this.dateTimeDebut.Value = leContrat.DateDebut;

        }
        public void affichageCDD(MCdd unContrat)
        {
            this.dateTimeFin.Value = unContrat.DateFin;
            this.dateTimeDebut.Value = unContrat.DateDebut;
            this.txtMotif.Text = unContrat.Motif;
        }
        public void affichageInterim(MInterim unContrat)
        {
            this.dateTimeFin.Value = unContrat.DateFin;
            this.dateTimeDebut.Value = unContrat.DateDebut;
            this.txtMotif.Text = unContrat.Motif;
            this.txtAgence.Text = unContrat.AgenceInterim;
            this.txtIndemnisation.Text = unContrat.IndemnitesInterim.ToString();
        }
        public void affichageStage(MStagiaire unContrat)
        {
            this.dateTimeFin.Value = unContrat.DateFin;
            this.dateTimeDebut.Value = unContrat.DateDebut;
            this.txtEcole.Text = unContrat.Ecole;
            this.txtMission.Text = unContrat.Mission;
        }
    }
}
