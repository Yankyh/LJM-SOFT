using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.View
{
    public partial class TelaTipoPessoa : Form
    {

        String nomeTipo = "";

        //Conexao com banco
        static public String conString = "Data Source=DESKTOP-1DAI7PD;Initial Catalog=SGBDSOFT;Integrated Security=True";
        SqlConnection conexaoBanco = new SqlConnection(conString);

        public TelaTipoPessoa()
        {
            InitializeComponent();

            void carregaForm(int Handle)
            {

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            nomeTipo = nomeBox.Text;

            conexaoBanco.Open();

            //Query para dar insert nos dados
            if(nomeTipo != "")
            {
                String query1 = "INSERT INTO US_TIPO (NOME) VALUES ('" + nomeTipo + "')";
                SqlCommand cmd1 = new SqlCommand(query1, conexaoBanco);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Prrencha o campo nome");
            }
          

            conexaoBanco.Close();

        }

        private void TelaTipoPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
