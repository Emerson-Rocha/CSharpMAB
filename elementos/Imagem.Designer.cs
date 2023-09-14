namespace elementos
{
    partial class Imagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagem));
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.pcb3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImagem
            // 
            this.pcbImagem.Location = new System.Drawing.Point(48, 26);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(370, 333);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagem.TabIndex = 0;
            this.pcbImagem.TabStop = false;
            // 
            // bt1
            // 
            this.bt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt1.BackgroundImage")));
            this.bt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt1.Location = new System.Drawing.Point(457, 26);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(115, 107);
            this.bt1.TabIndex = 1;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackgroundImage = global::elementos.Properties.Resources.img02_;
            this.bt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt2.Location = new System.Drawing.Point(457, 139);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(115, 107);
            this.bt2.TabIndex = 1;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // bt3
            // 
            this.bt3.BackgroundImage = global::elementos.Properties.Resources.img03_;
            this.bt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt3.Location = new System.Drawing.Point(457, 252);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(115, 107);
            this.bt3.TabIndex = 1;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.Bt3_Click);
            // 
            // pcb1
            // 
            this.pcb1.Image = global::elementos.Properties.Resources.img01_;
            this.pcb1.Location = new System.Drawing.Point(48, 365);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(117, 84);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb1.TabIndex = 2;
            this.pcb1.TabStop = false;
            this.pcb1.MouseHover += new System.EventHandler(this.Pcb1_MouseHover);
            // 
            // pcb2
            // 
            this.pcb2.Image = global::elementos.Properties.Resources.img02_;
            this.pcb2.Location = new System.Drawing.Point(181, 365);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(117, 84);
            this.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb2.TabIndex = 2;
            this.pcb2.TabStop = false;
            this.pcb2.MouseHover += new System.EventHandler(this.Pcb2_MouseHover);
            // 
            // pcb3
            // 
            this.pcb3.Image = global::elementos.Properties.Resources.img03_;
            this.pcb3.Location = new System.Drawing.Point(315, 365);
            this.pcb3.Name = "pcb3";
            this.pcb3.Size = new System.Drawing.Size(117, 84);
            this.pcb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb3.TabIndex = 2;
            this.pcb3.TabStop = false;
            this.pcb3.MouseHover += new System.EventHandler(this.Pcb3_MouseHover);
            // 
            // Imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 456);
            this.Controls.Add(this.pcb3);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.pcbImagem);
            this.Name = "Imagem";
            this.Text = "Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.PictureBox pcb3;
    }
}