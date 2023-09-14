namespace elementos
{
    partial class frmcad
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btcadastro = new System.Windows.Forms.Button();
            this.lblmostra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(31, 29);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(60, 19);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(97, 22);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(253, 26);
            this.txtnome.TabIndex = 1;
            // 
            // btcadastro
            // 
            this.btcadastro.Location = new System.Drawing.Point(368, 19);
            this.btcadastro.Name = "btcadastro";
            this.btcadastro.Size = new System.Drawing.Size(132, 33);
            this.btcadastro.TabIndex = 2;
            this.btcadastro.Text = "CADASTRO";
            this.btcadastro.UseVisualStyleBackColor = true;
            this.btcadastro.Click += new System.EventHandler(this.Btcadastro_Click);
            // 
            // lblmostra
            // 
            this.lblmostra.AutoSize = true;
            this.lblmostra.Location = new System.Drawing.Point(43, 123);
            this.lblmostra.Name = "lblmostra";
            this.lblmostra.Size = new System.Drawing.Size(0, 13);
            this.lblmostra.TabIndex = 3;
            // 
            // frmcad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 273);
            this.Controls.Add(this.lblmostra);
            this.Controls.Add(this.btcadastro);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Name = "frmcad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btcadastro;
        private System.Windows.Forms.Label lblmostra;
    }
}

