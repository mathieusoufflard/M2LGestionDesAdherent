namespace Maison_des_ligues.Forms
{
    partial class Supprimer
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
            this.ltBoxAderents = new System.Windows.Forms.ListBox();
            this.btnSupp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltBoxAderents
            // 
            this.ltBoxAderents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltBoxAderents.FormattingEnabled = true;
            this.ltBoxAderents.Location = new System.Drawing.Point(252, 88);
            this.ltBoxAderents.Name = "ltBoxAderents";
            this.ltBoxAderents.Size = new System.Drawing.Size(249, 199);
            this.ltBoxAderents.TabIndex = 0;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(425, 355);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(75, 23);
            this.btnSupp.TabIndex = 1;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.BtnSupp_Click);
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.ltBoxAderents);
            this.Name = "Supprimer";
            this.Text = "Supprimer un adhérent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltBoxAderents;
        private System.Windows.Forms.Button btnSupp;
    }
}