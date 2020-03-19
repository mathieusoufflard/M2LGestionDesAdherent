namespace Maison_des_ligues.Forms
{
    partial class Ajouter
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(204, 160);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(207, 227);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(286, 160);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(213, 20);
            this.txbNom.TabIndex = 2;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(286, 227);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(213, 20);
            this.txbPrenom.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(423, 283);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.Button btnAjouter;
    }
}