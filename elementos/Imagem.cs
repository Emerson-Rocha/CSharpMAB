using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elementos
{
    public partial class Imagem : Form
    {
        public Imagem()
        {
            InitializeComponent();
        }



        private void Bt2_Click(object sender, EventArgs e)
        {
            pcbImagem.Image = Properties.Resources.img02_;

        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            pcbImagem.Image = Properties.Resources.img03_;
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            pcbImagem.Image = Properties.Resources.img01_;
        }

        private void Pcb3_MouseHover(object sender, EventArgs e)
        {
            pcbImagem.Image = Properties.Resources.img03_;
        }

        private void Pcb2_MouseHover(object sender, EventArgs e)
        {
            pcbImagem.Image = Properties.Resources.img02_;
        }

        private void Pcb1_MouseHover(object sender, EventArgs e)
        {
            pcbImagem.Image = Properties.Resources.img01_;
        }
    }
}
