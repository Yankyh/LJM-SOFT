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
        Conexao conexao = new Conexao();

        TelaRegistro TelaRegistro = new TelaRegistro();

        public TelaTipoPessoa()
        {
            InitializeComponent();
            gettipoHandle();
          
        }

        public void gettipoHandle()
        {
            conexao.Desconectar();
            conexao.Conectar();
            
           
            if (tipoHandle != 0)
            {
                //Preenche o form caso exista um handle

                {
                    String query1 = "SELECT * FROM US_TIPO WHERE HANDLE = '" + tipoHandle + "'";
                   
                    SqlDataReader reader = conexao.Pesquisa(query1);

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
                        voltarButton.Visible = false;
                        gravarButton.Visible = false;
                    }
                    else
                    {
                        if (status == 3)
                        {
                            this.Text = "Tipo - Ativo";
                            nomeBox.Enabled = false;
                            gravarButton.Visible = false;
                            liberarButton.Visible = false;
                        }
                    }


                }
            }
            else
            {
                this.Text = "Tipo da pessoa";
                voltarButton.Visible = false;
                liberarButton.Visible = false;
            }

                conexao.Desconectar();

        }

        public int getTipoHandleByName()
        {
            conexao.Desconectar();
            conexao.Conectar();
            

            String query7 = "SELECT HANDLE FROM US_TIPO WHERE NOME = '" + nomeBox.Text + "'";
           
            SqlDataReader reader = conexao.Pesquisa(query7);

            while (reader.Read())
            {
                tipoHandle = Convert.ToInt32(reader["HANDLE"]);
            }
            reader.Close();

            conexao.Desconectar();

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
            conexao.Desconectar();
            conexao.Conectar();
            if (status == 3)
            {
                if (gravarButton.Text == "Voltar")
                {
                    nomeBox.Enabled = true;
                    this.Text = "Tipo - Ag. Modificações";
                    gravarButton.Text = "Liberar";
                    status = 2;
                    String query8 = "UPDATE US_TIPO SET STATUS = " + 2 + " WHERE HANDLE = " + tipoHandle + "";
                    conexao.Inserir(query8);
                }
                else
                {
                    
                    String query3 = "UPDATE US_TIPO SET STATUS = " + 3 + " WHERE HANDLE = "+tipoHandle+"";
                    conexao.Inserir(query3);

                    nomeBox.Enabled = false;
                    this.Text = "Tipo - Ativo";
                    gravarButton.Text = "Voltar";

                   
                }
               
            }
            else
            {
                nomeTipo = nomeBox.Text;

             

                //Query para dar insert nos dados
                if (nomeTipo != "")
                {
                    int existeHandle = -1;
                    //Verifica se o handle já existe
                    String query5 = "SELECT HANDLE FROM US_TIPO WHERE HANDLE = '" + tipoHandle + "'";
                    
                    SqlDataReader reader = conexao.Pesquisa(query5);

                    while (reader.Read())
                    {
                        existeHandle = Convert.ToInt32(reader["HANDLE"]);
                    }
                    reader.Close();

                    if(existeHandle > 0)
                    {
                        String query6 = "UPDATE US_TIPO SET NOME = '"+nomeTipo+"', STATUS = "+3+" WHERE HANDLE = "+tipoHandle;

                        conexao.Inserir(query6);

                        gravarButton.Text = "Voltar";
                        this.Text = "Tipo - Ativo";
                        nomeBox.Enabled = false;
                        status = 3;
                    }
                    else
                    {
                        String query1 = "INSERT INTO US_TIPO (NOME, STATUS) VALUES ('" + nomeTipo + "', '" + 1 + "')";
                        conexao.Inserir(query1);

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


                conexao.Desconectar();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

          


        }

        private void liberarButton_Click(object sender, EventArgs e)
        {


            String query3 = "UPDATE US_TIPO SET STATUS = " + 3 + " WHERE HANDLE = " + tipoHandle + "";
            conexao.Inserir(query3);

            nomeBox.Enabled = false;
            this.Text = "Tipo - Ativo";
            gravarButton.Visible = false;


        }
    }
}
