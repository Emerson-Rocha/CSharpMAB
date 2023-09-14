namespace elementos
{
    partial class Aula_Checkbox
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
            this.ckb01 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdb01 = new System.Windows.Forms.RadioButton();
            this.rdb02 = new System.Windows.Forms.RadioButton();
            this.gb01 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb01
            // 
            this.ckb01.AutoSize = true;
            this.ckb01.Location = new System.Drawing.Point(632, 12);
            this.ckb01.Name = "ckb01";
            this.ckb01.Size = new System.Drawing.Size(68, 17);
            this.ckb01.TabIndex = 0;
            this.ckb01.Text = "Desativo";
            this.ckb01.UseVisualStyleBackColor = true;
            this.ckb01.CheckedChanged += new System.EventHandler(this.Ckb01_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(498, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rdb01
            // 
            this.rdb01.AutoSize = true;
            this.rdb01.Location = new System.Drawing.Point(615, 35);
            this.rdb01.Name = "rdb01";
            this.rdb01.Size = new System.Drawing.Size(85, 17);
            this.rdb01.TabIndex = 2;
            this.rdb01.TabStop = true;
            this.rdb01.Text = "radioButton1";
            this.rdb01.UseVisualStyleBackColor = true;
            this.rdb01.CheckedChanged += new System.EventHandler(this.Rdb01_CheckedChanged);
            // 
            // rdb02
            // 
            this.rdb02.AutoSize = true;
            this.rdb02.Location = new System.Drawing.Point(66, 21);
            this.rdb02.Name = "rdb02";
            this.rdb02.Size = new System.Drawing.Size(85, 17);
            this.rdb02.TabIndex = 3;
            this.rdb02.TabStop = true;
            this.rdb02.Text = "radioButton1";
            this.rdb02.UseVisualStyleBackColor = true;
            this.rdb02.CheckedChanged += new System.EventHandler(this.Rdb02_CheckedChanged);
            // 
            // gb01
            // 
            this.gb01.Controls.Add(this.rdb02);
            this.gb01.Location = new System.Drawing.Point(588, 73);
            this.gb01.Name = "gb01";
            this.gb01.Size = new System.Drawing.Size(200, 100);
            this.gb01.TabIndex = 4;
            this.gb01.TabStop = false;
            this.gb01.Text = "Ver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::elementos.Properties.Resources.img02_;
            this.pictureBox1.Location = new System.Drawing.Point(91, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Aula_Checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb01);
            this.Controls.Add(this.rdb01);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ckb01);
            this.Name = "Aula_Checkbox";
            this.Text = "Aula_Checkbox";
            this.Load += new System.EventHandler(this.Aula_Checkbox_Load);
            this.gb01.ResumeLayout(false);
            this.gb01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb01;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rdb01;
        private System.Windows.Forms.RadioButton rdb02;
        private System.Windows.Forms.GroupBox gb01;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}