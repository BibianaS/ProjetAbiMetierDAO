namespace WindowsFormsApplication2
{
    partial class frmContrat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dateTimeDebut = new System.Windows.Forms.DateTimePicker();
            this.lblQualification = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.gpbTypeContrat = new System.Windows.Forms.GroupBox();
            this.rbtInterim = new System.Windows.Forms.RadioButton();
            this.rbtStage = new System.Windows.Forms.RadioButton();
            this.rbtCDD = new System.Windows.Forms.RadioButton();
            this.rbtCDI = new System.Windows.Forms.RadioButton();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.lblSalaireBrut = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblAgenceInterim = new System.Windows.Forms.Label();
            this.txtAgence = new System.Windows.Forms.TextBox();
            this.lblIndemnisation = new System.Windows.Forms.Label();
            this.txtIndemnisation = new System.Windows.Forms.TextBox();
            this.lblEcole = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNumContrat = new System.Windows.Forms.Label();
            this.txtNumContrat = new System.Windows.Forms.TextBox();
            this.txtSalaireBrut = new System.Windows.Forms.TextBox();
            this.gpbTypeContrat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(12, 138);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(69, 13);
            this.lblDateDebut.TabIndex = 18;
            this.lblDateDebut.Text = "Date debut : ";
            // 
            // dateTimeDebut
            // 
            this.dateTimeDebut.Location = new System.Drawing.Point(134, 131);
            this.dateTimeDebut.Name = "dateTimeDebut";
            this.dateTimeDebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDebut.TabIndex = 5;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(12, 208);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(71, 13);
            this.lblQualification.TabIndex = 20;
            this.lblQualification.Text = "Qualification :";
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(134, 201);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(148, 20);
            this.txtQualification.TabIndex = 7;
            // 
            // gpbTypeContrat
            // 
            this.gpbTypeContrat.Controls.Add(this.rbtInterim);
            this.gpbTypeContrat.Controls.Add(this.rbtStage);
            this.gpbTypeContrat.Controls.Add(this.rbtCDD);
            this.gpbTypeContrat.Controls.Add(this.rbtCDI);
            this.gpbTypeContrat.Location = new System.Drawing.Point(12, 47);
            this.gpbTypeContrat.Name = "gpbTypeContrat";
            this.gpbTypeContrat.Size = new System.Drawing.Size(322, 73);
            this.gpbTypeContrat.TabIndex = 6;
            this.gpbTypeContrat.TabStop = false;
            this.gpbTypeContrat.Text = "Type de contrat";
            // 
            // rbtInterim
            // 
            this.rbtInterim.AutoSize = true;
            this.rbtInterim.Location = new System.Drawing.Point(23, 34);
            this.rbtInterim.Name = "rbtInterim";
            this.rbtInterim.Size = new System.Drawing.Size(56, 17);
            this.rbtInterim.TabIndex = 1;
            this.rbtInterim.Text = "Interim";
            this.rbtInterim.UseVisualStyleBackColor = true;
            this.rbtInterim.CheckedChanged += new System.EventHandler(this.rbtInterim_CheckedChanged);
            // 
            // rbtStage
            // 
            this.rbtStage.AutoSize = true;
            this.rbtStage.Location = new System.Drawing.Point(171, 34);
            this.rbtStage.Name = "rbtStage";
            this.rbtStage.Size = new System.Drawing.Size(53, 17);
            this.rbtStage.TabIndex = 3;
            this.rbtStage.Text = "Stage";
            this.rbtStage.UseVisualStyleBackColor = true;
            this.rbtStage.CheckedChanged += new System.EventHandler(this.rbtStage_CheckedChanged);
            // 
            // rbtCDD
            // 
            this.rbtCDD.AutoSize = true;
            this.rbtCDD.Location = new System.Drawing.Point(101, 34);
            this.rbtCDD.Name = "rbtCDD";
            this.rbtCDD.Size = new System.Drawing.Size(48, 17);
            this.rbtCDD.TabIndex = 2;
            this.rbtCDD.Text = "CDD";
            this.rbtCDD.UseVisualStyleBackColor = true;
            this.rbtCDD.CheckedChanged += new System.EventHandler(this.rbtCDD_CheckedChanged);
            // 
            // rbtCDI
            // 
            this.rbtCDI.AutoSize = true;
            this.rbtCDI.Checked = true;
            this.rbtCDI.Location = new System.Drawing.Point(242, 34);
            this.rbtCDI.Name = "rbtCDI";
            this.rbtCDI.Size = new System.Drawing.Size(43, 17);
            this.rbtCDI.TabIndex = 4;
            this.rbtCDI.TabStop = true;
            this.rbtCDI.Text = "CDI";
            this.rbtCDI.UseVisualStyleBackColor = true;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(12, 169);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(56, 13);
            this.lblDateFin.TabIndex = 19;
            this.lblDateFin.Text = "Date fint : ";
            this.lblDateFin.Click += new System.EventHandler(this.lblDateFin_Click);
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(134, 163);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 6;
            // 
            // lblSalaireBrut
            // 
            this.lblSalaireBrut.AutoSize = true;
            this.lblSalaireBrut.Location = new System.Drawing.Point(12, 247);
            this.lblSalaireBrut.Name = "lblSalaireBrut";
            this.lblSalaireBrut.Size = new System.Drawing.Size(66, 13);
            this.lblSalaireBrut.TabIndex = 22;
            this.lblSalaireBrut.Text = "Salaire brut :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(12, 286);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 23;
            this.lblMotif.Text = "Motif :";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(134, 279);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(148, 20);
            this.txtMotif.TabIndex = 10;
            // 
            // lblAgenceInterim
            // 
            this.lblAgenceInterim.AutoSize = true;
            this.lblAgenceInterim.Location = new System.Drawing.Point(12, 325);
            this.lblAgenceInterim.Name = "lblAgenceInterim";
            this.lblAgenceInterim.Size = new System.Drawing.Size(83, 13);
            this.lblAgenceInterim.TabIndex = 24;
            this.lblAgenceInterim.Text = "Agence interim :";
            // 
            // txtAgence
            // 
            this.txtAgence.Location = new System.Drawing.Point(134, 318);
            this.txtAgence.Name = "txtAgence";
            this.txtAgence.Size = new System.Drawing.Size(148, 20);
            this.txtAgence.TabIndex = 11;
            // 
            // lblIndemnisation
            // 
            this.lblIndemnisation.AutoSize = true;
            this.lblIndemnisation.Location = new System.Drawing.Point(12, 368);
            this.lblIndemnisation.Name = "lblIndemnisation";
            this.lblIndemnisation.Size = new System.Drawing.Size(78, 13);
            this.lblIndemnisation.TabIndex = 25;
            this.lblIndemnisation.Text = "Indemnisation :";
            // 
            // txtIndemnisation
            // 
            this.txtIndemnisation.Location = new System.Drawing.Point(134, 361);
            this.txtIndemnisation.Name = "txtIndemnisation";
            this.txtIndemnisation.Size = new System.Drawing.Size(148, 20);
            this.txtIndemnisation.TabIndex = 12;
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(12, 402);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(40, 13);
            this.lblEcole.TabIndex = 26;
            this.lblEcole.Text = "Ecole :";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(12, 443);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(48, 13);
            this.lblMission.TabIndex = 27;
            this.lblMission.Text = "Mission :";
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(134, 438);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(148, 20);
            this.txtMission.TabIndex = 14;
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(134, 399);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(148, 20);
            this.txtEcole.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(161, 505);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(259, 505);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblNumContrat
            // 
            this.lblNumContrat.AutoSize = true;
            this.lblNumContrat.Location = new System.Drawing.Point(12, 19);
            this.lblNumContrat.Name = "lblNumContrat";
            this.lblNumContrat.Size = new System.Drawing.Size(90, 13);
            this.lblNumContrat.TabIndex = 17;
            this.lblNumContrat.Text = "Contrat Numero : ";
            // 
            // txtNumContrat
            // 
            this.txtNumContrat.Location = new System.Drawing.Point(134, 12);
            this.txtNumContrat.Name = "txtNumContrat";
            this.txtNumContrat.Size = new System.Drawing.Size(148, 20);
            this.txtNumContrat.TabIndex = 0;
            // 
            // txtSalaireBrut
            // 
            this.txtSalaireBrut.Location = new System.Drawing.Point(134, 240);
            this.txtSalaireBrut.Name = "txtSalaireBrut";
            this.txtSalaireBrut.Size = new System.Drawing.Size(148, 20);
            this.txtSalaireBrut.TabIndex = 9;
            // 
            // frmContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 537);
            this.Controls.Add(this.txtNumContrat);
            this.Controls.Add(this.lblNumContrat);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEcole);
            this.Controls.Add(this.txtMission);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.lblEcole);
            this.Controls.Add(this.txtIndemnisation);
            this.Controls.Add(this.lblIndemnisation);
            this.Controls.Add(this.txtAgence);
            this.Controls.Add(this.lblAgenceInterim);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtSalaireBrut);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblSalaireBrut);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.gpbTypeContrat);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.dateTimeDebut);
            this.Controls.Add(this.lblDateDebut);
            this.Name = "frmContrat";
            this.Text = "Ajouter un contrat";
            this.gpbTypeContrat.ResumeLayout(false);
            this.gpbTypeContrat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.GroupBox gpbTypeContrat;
        private System.Windows.Forms.RadioButton rbtInterim;
        private System.Windows.Forms.RadioButton rbtStage;
        private System.Windows.Forms.RadioButton rbtCDD;
        private System.Windows.Forms.RadioButton rbtCDI;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblSalaireBrut;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblAgenceInterim;
        private System.Windows.Forms.Label lblIndemnisation;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Button btnAnnuler;
        internal System.Windows.Forms.TextBox txtMotif;
        internal System.Windows.Forms.TextBox txtAgence;
        internal System.Windows.Forms.TextBox txtIndemnisation;
        internal System.Windows.Forms.TextBox txtMission;
        internal System.Windows.Forms.TextBox txtEcole;
        internal System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblNumContrat;
        internal System.Windows.Forms.TextBox txtNumContrat;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.TextBox txtSalaireBrut;
        internal System.Windows.Forms.DateTimePicker dateTimeDebut;
        internal System.Windows.Forms.DateTimePicker dateTimeFin;
    }
}