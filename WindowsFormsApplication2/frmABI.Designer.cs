namespace ABI
{
    partial class frmABI
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
            this.grdCollaborateurs = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCollaborateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCollaborateurs
            // 
            this.grdCollaborateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCollaborateurs.Location = new System.Drawing.Point(12, 12);
            this.grdCollaborateurs.Name = "grdCollaborateurs";
            this.grdCollaborateurs.Size = new System.Drawing.Size(505, 262);
            this.grdCollaborateurs.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(361, 280);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(442, 280);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmABI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 314);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grdCollaborateurs);
            this.Name = "frmABI";
            this.Text = "Lister les Collaborateurs";
            ((System.ComponentModel.ISupportInitialize)(this.grdCollaborateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFermer;
        internal System.Windows.Forms.Button btnAjouter;
        internal System.Windows.Forms.DataGridView grdCollaborateurs;
    }
}