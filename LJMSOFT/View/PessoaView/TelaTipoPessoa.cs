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
using LJMSOFT.DAL;
namespace LJMSOFT.View
{
    public partial class TelaTipoPessoa : Form
    {

        String nomeTipo = "";
        int tipoHandle = TelaRegistro.getTipoHandle();
        static int status = 0;

       
        //Conexao com banco
        static public String conString = "Data Source=DESKTOP-1DAI7PD;Initial Catalog=SGBDSOFT;Integrated Security=True";
        SqlConnection conexaoBanco = new SqlConnection(conString);
        TelaRegistro TelaRegistro = new TelaRegistro();

        public TelaTipoPessoa()
        {
            InitializeComponent();
            gettipoHandle();
          
        }

        public void gettipoHandle()
        {
            // conexaoBanco.Open();
            Conexao conexao = new Conexao();
            conexao.Conectar();
            MessageBox.Show("Entrou");
           
            if (tipoHandle != 0)
            {
                //Preenche o form caso exista um handle

                {
                    String query1 = "SELECT * FROM US_TIPO WHERE HANDLE = '" + tipoHandle + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, conexaoBanco);
                    SqlDataReader reader = cmd1.ExecuteReader();

                    while (reader.Read())
                    {
                        nomeTipo = reader["NOME"].ToString();
                        status = Convert.ToInt32(reader["STATUS"]);
                    }
                    reader.Close();
                    //Alimenta o form
                    nomeBox.Text = nomeTipo;
                    codigoBox.Text = tipoHandle.ToString();

                    //Verifica o status do form
                    if (status == 2)
                    {
                        this.Text = "Tipo - Ag. Modificações";
                    }
                    else
                    {
                        if (status == 3)
                        {
                            this.Text = "Tipo - Ativo";
                            nomeBox.Enabled = false;
                            gravarButton.Text = "Voltar";
                        }
                    }


                }
            }
           // conexao.Desconectar();
                conexaoBanco.Close();

        }

        public int getTipoHandleByName()
        {
            conexaoBanco.Close();
            conexaoBanco.Open();

            String query7 = "SELECT HANDLE FROM US_TIPO WHERE NOME = '" + nomeBox.Text + "'";
            SqlCommand cmd7 = new SqlCommand(query7, conexaoBanco);
            SqlDataReader reader = cmd7.ExecuteReader();

            while (reader.Read())
            {
                tipoHandle = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();

            conexaoBanco.Close();

            return tipoHandle;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void TelaTipoPessoa_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gravarButton_Click(object sender, EventArgs e)
        {

            if (status == 3)
            {
                if (gravarButton.Text == "Voltar")
                {
                    nomeBox.Enabled = true;
                    this.Text = "Tipo - Ag. Modificações";
                    gravarButton.Text = "Liberar";
                    status = 2;
                }
                else
                {
                    conexaoBanco.Open();
                    String query3 = "UPDATE US_TIPO SET STATUS = " + 3 + " WHERE HANDLE = "+tipoHandle+"";
                    MessageBox.Show(query3);
                    SqlCommand cmd3 = new SqlCommand(query3, conexaoBanco);
                    cmd3.ExecuteNonQuery();
                    nomeBox.Enabled = false;
                    this.Text = "Tipo - Ativo";
                    gravarButton.Text = "Voltar";

                    conexaoBanco.Close();
                }
               
            }
            else
            {
                nomeTipo = nomeBox.Text;

                conexaoBanco.Open();

                //Query para dar insert nos dados
                if (nomeTipo != "")
                {
                    int existeHandle = -1;
                    //Verifica se o handle já existe
                    String query5 = "SELECT HANDLE FROM US_TIPO WHERE HANDLE = '" + tipoHandle + "'";
                    SqlCommand cmd5 = new SqlCommand(query5, conexaoBanco);
                    SqlDataReader reader = cmd5.ExecuteReader();

                    while (reader.Read())
                    {
                        existeHandle = Convert.ToInt32(reader["HANDLE"]);
                    }
                    reader.Close();

                    if(existeHandle > 0)
                    {
                        String query6 = "UPDATE US_TIPO SET NOME = '"+nomeTipo+"', STATUS = "+3+" WHERE HANDLE = "+tipoHandle;
                        MessageBox.Show(query6);
                        SqlCommand cmd6 = new SqlCommand(query6, conexaoBanco);
                        cmd6.ExecuteNonQuery();

                        gravarButton.Text = "Voltar";
                        this.Text = "Tipo - Ativo";
                        nomeBox.Enabled = false;
                        status = 3;
                    }
                    else
                    {
                        String query1 = "INSERT INTO US_TIPO (NOME, STATUS) VALUES ('" + nomeTipo + "', '" + 1 + "')";
                        SqlCommand cmd1 = new SqlCommand(query1, conexaoBanco);
                        cmd1.ExecuteNonQuery();
                        this.Text = "Tipo - Cadastrado";
                        gravarButton.Text = "Liberar";
                        MessageBox.Show("Liberado");
                        status = 3;
                        codigoBox.Text = getTipoHandleByName().ToString();
                    }








               
                }
                else
                {
                    MessageBox.Show("Prencha o campo nome");
                }


                conexaoBanco.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

          


        }
    }
}
