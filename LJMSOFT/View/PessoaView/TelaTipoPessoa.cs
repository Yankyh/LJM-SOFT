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
using LJMSOFT.Control;

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

                if (existeHandle > 0)
                {
                    this.Text = "Tipo - Ag. Modificações";
                    status = 2;
                }
                else
                {
                    String query1 = "INSERT INTO US_TIPO (NOME, STATUS) VALUES ('" + nomeTipo + "', '" + 1 + "')";
                    conexao.Inserir(query1);

                    this.Text = "Tipo - Cadastrado";
                    
                    status = 2;
                    codigoBox.Text = getTipoHandleByName().ToString();
                }

                gravarButton.Visible = false;
                liberarButton.Visible = true;
               
                }
                else
                {
                    MessageBox.Show("Prencha o campo nome");
                }


                conexao.Desconectar();
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

          


        }

        private void liberarButton_Click(object sender, EventArgs e)
        {



            if (Controle.EhLiberar() == System.Windows.Forms.DialogResult.Yes){
                conexao.Conectar();

                String query3 = "UPDATE US_TIPO SET STATUS = " + 3 + " WHERE HANDLE = " + tipoHandle + "";
                conexao.Inserir(query3);

                nomeBox.Enabled = false;
                this.Text = "Tipo - Ativo";
                gravarButton.Visible = false;
                liberarButton.Visible = false;
                voltarButton.Visible = true;

                conexao.Desconectar();
            }
        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            conexao.Conectar();

            nomeBox.Enabled = true;
            this.Text = "Tipo - Ag. Modificações";
            gravarButton.Visible = true;
            voltarButton.Visible = false;
            status = 2;
            String query8 = "UPDATE US_TIPO SET STATUS = " + 2 + " WHERE HANDLE = " + tipoHandle + "";
            conexao.Inserir(query8);

            conexao.Desconectar();

        }
    }
}
