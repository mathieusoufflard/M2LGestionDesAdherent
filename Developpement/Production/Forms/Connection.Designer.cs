namespace Maison_des_ligues.Forms
{
    partial class Connection
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxbLogin = new System.Windows.Forms.TextBox();
            this.TxbMdp = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblMdp = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TxbLogin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxbMdp, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblLogin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblMdp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnConnect, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxbLogin
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxbLogin, 2);
            this.TxbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbLogin.Location = new System.Drawing.Point(311, 107);
            this.TxbLogin.Name = "TxbLogin";
            this.TxbLogin.Size = new System.Drawing.Size(302, 20);
            this.TxbLogin.TabIndex = 0;
            // 
            // TxbMdp
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxbMdp, 2);
            this.TxbMdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbMdp.Location = new System.Drawing.Point(311, 211);
            this.TxbMdp.Name = "TxbMdp";
            this.TxbMdp.Size = new System.Drawing.Size(302, 20);
            this.TxbMdp.TabIndex = 1;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLogin.Location = new System.Drawing.Point(157, 104);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(148, 104);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login";
            // 
            // LblMdp
            // 
            this.LblMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMdp.AutoSize = true;
            this.LblMdp.Location = new System.Drawing.Point(157, 208);
            this.LblMdp.Name = "LblMdp";
            this.LblMdp.Size = new System.Drawing.Size(148, 104);
            this.LblMdp.TabIndex = 3;
            this.LblMdp.Text = "Mot de passe";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(465, 315);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 4;
            this.BtnConnect.Text = "Connexion";
            this.BtnConnect.UseVisualStyleBackColor = true;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 419);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(787, 458);
            this.Name = "Connection";
            this.Text = "Connection";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxbLogin;
        private System.Windows.Forms.TextBox TxbMdp;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblMdp;
        private System.Windows.Forms.Button BtnConnect;
    }
}