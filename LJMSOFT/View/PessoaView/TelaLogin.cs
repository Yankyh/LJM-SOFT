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
            Conexao conex = new Conexao();
            String usuario = textBoxUsuario.Text;
            String senha = textBoxSenha.Text;
            if (conex.VerificaSenha(usuario,senha) == 1)
            {
                MessageBox.Show("entrou");
            }
            else
            {
                MessageBox.Show("Deu ruim! Senha incorreta");
            }



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
