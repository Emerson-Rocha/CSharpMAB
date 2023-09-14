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
    public partial class frmcad : Form
    {
        public frmcad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btcadastro_Click(object sender, EventArgs e)
        {
            // 1º TENHO QUE PEGAR O TEXTO QUE SE ENCONTRA NO TEXTBOX
            string nome = txtnome.Text;
            //2º MOSTRAR A MENSAGEM COM O NOME
            MessageBox.Show("nome digita é " + nome, "CADASTRO");
            // 3º LIMPAR O TEXTBOX
            txtnome.Clear();
            //txtnome.Text = "";

            // 4º MOSTRAR O NOME NO LABEL
            lblmostra.Text = nome;




        }
    }
}
