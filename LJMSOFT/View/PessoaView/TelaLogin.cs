using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LJMSOFT.View;
using LJMSOFT.DAL;
using System.Data.SqlClient;
using LJMSOFT.View.PessoaView;

namespace LJMSOFT.View
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaRegistro TelaRegistro = new TelaRegistro();
            TelaRegistro.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PessoaListaTela pessoaListaTela = new PessoaListaTela();
            pessoaListaTela.Show();
        }
    }
}
