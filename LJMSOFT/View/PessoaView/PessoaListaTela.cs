using LJMSOFT.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.View.PessoaView
{
    public partial class PessoaListaTela : Form
    {
        public PessoaListaTela()
        {
            InitializeComponent();

            Conexao conex = new Conexao();
            conex.Conectar();
            BindingSource Binding = new BindingSource();
            pessoaDataGridView.AutoGenerateColumns = true;
            String query = "SELECT * FROM US_PESSOA";
            Binding.DataSource = conex.DataTable(query);
            pessoaDataGridView.DataSource = Binding;
            pessoaDataGridView.AllowUserToResizeRows = false;
            conex.Desconectar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PessoaListaTela_Load(object sender, EventArgs e)
        {

        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           String teste = pessoaDataGridView.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show(teste);
        }
    }
}
