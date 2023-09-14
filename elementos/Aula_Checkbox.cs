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
    public partial class Aula_Checkbox : Form
    {
        public Aula_Checkbox()
        {
            InitializeComponent();
        }

        private void Ckb01_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb01.Checked == true)
            {
                ckb01.Text = "Ativo";
                MessageBox.Show("Ativo");
                
            }
            else {
                ckb01.Text = "Desativado";
                MessageBox.Show("Desativado");
               
            }
        }

        private void Aula_Checkbox_Load(object sender, EventArgs e)
        {
            // mudar o nome do elemento radio
            rdb01.Text = "Ativo";
            rdb02.Text = "Desativado";
        }

        private void Rdb01_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(rdb01.Checked.ToString());
        }

        private void Rdb02_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(rdb02.Checked));
        }
    }
}
