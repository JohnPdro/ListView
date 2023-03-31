using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //vamos limpar algumas coisas antes

        private void limpar()
        {
            txtId.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtId.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            String[] produtos = new String[4];
            produtos[0] = txtId.Text;
            produtos[1] = txtProduto.Text;
            produtos[2] = txtQuantidade.Text;
            produtos[3] = txtPreco.Text;

            ListViewItem L = new ListViewItem(produtos);
            listProdutos.Items.Add(L);
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
