namespace ABI
{
    partial class frmCollaborateur
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
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblSS = new System.Windows.Forms.Label();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.gpbCollaborateur = new System.Windows.Forms.GroupBox();
            this.gpbCollaborateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(30, 35);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(56, 13);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule :";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(123, 32);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(86, 20);
            this.txtMatricule.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(30, 77);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(123, 74);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(179, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(30, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(123, 118);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(179, 20);
            this.txtNom.TabIndex = 5;
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Location = new System.Drawing.Point(30, 160);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(82, 13);
            this.lblSS.TabIndex = 6;
            this.lblSS.Text = "Numéro de SS :";
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(123, 157);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 20);
            this.txtSS.TabIndex = 7;
            // 
            // gpbCollaborateur
            // 
            this.gpbCollaborateur.Controls.Add(this.txtSS);
            this.gpbCollaborateur.Controls.Add(this.lblSS);
            this.gpbCollaborateur.Controls.Add(this.txtNom);
            this.gpbCollaborateur.Controls.Add(this.lblNom);
            this.gpbCollaborateur.Controls.Add(this.txtPrenom);
            this.gpbCollaborateur.Controls.Add(this.lblPrenom);
            this.gpbCollaborateur.Controls.Add(this.txtMatricule);
            this.gpbCollaborateur.Controls.Add(this.lblMatricule);
            this.gpbCollaborateur.Location = new System.Drawing.Point(33, 28);
            this.gpbCollaborateur.Name = "gpbCollaborateur";
            this.gpbCollaborateur.Size = new System.Drawing.Size(329, 210);
            this.gpbCollaborateur.TabIndex = 8;
            this.gpbCollaborateur.TabStop = false;
            this.gpbCollaborateur.Text = "Collaborateur";
            // 
            // frmCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 356);
            this.Controls.Add(this.gpbCollaborateur);
            this.Name = "frmCollaborateur";
            this.Text = "frmCollaborateur";
            this.Load += new System.EventHandler(this.frmCollaborateur_Load);
            this.gpbCollaborateur.ResumeLayout(false);
            this.gpbCollaborateur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.GroupBox gpbCollaborateur;
        internal System.Windows.Forms.TextBox txtMatricule;
        internal System.Windows.Forms.TextBox txtPrenom;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.TextBox txtSS;
    }
}