using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LJMSOFT.Mod;
using System.Data.SqlClient;

namespace LJMSOFT.View
{
    public partial class TelaRegistro : Form
    {
        private String apelido = "", razaoSocial = "", cpfCnpj = "", telefone = "", celular = "", email = "", tipo = "";
        private int tipoHandle = 0;

        //Conexao com banco
        static public String conString = "Data Source=DESKTOP-1DAI7PD;Initial Catalog=SGBDSOFT;Integrated Security=True";
        SqlConnection conexaoBanco = new SqlConnection(conString);

        BancoDeDados BancoDeDados = new BancoDeDados();

        public TelaRegistro()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

   
        
        
        //COMBOBOX TIPO
        private void listarTipo(object sender, EventArgs e)
        {

            conexaoBanco.Open();

            //Limpa a combo box
            tipoCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT NOME FROM US_TIPO";
            SqlCommand cmd1 = new SqlCommand(query1, conexaoBanco);
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                tipoCombo.Items.Add((reader["NOME"].ToString()));
            }

            reader.Close();

            conexaoBanco.Close();
        }

        private void tipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void celularBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void keyPressf3(object sender, KeyEventArgs e)
        {
           
        }

        private void keyPressedf3(object sender, KeyPressEventArgs e)
        {
           
        }

        private void keyPressf3Tipo(object sender, KeyPressEventArgs e)
        {

         
        }

        private void keyDownf3Tipo(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.F3)
            {
                TelaTipoPessoa TelaTipoPessoa = new TelaTipoPessoa();
                TelaTipoPessoa.Show();
            }
           
        }

        private void complementoTab_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GRAVAR

            conexaoBanco.Open();

            //Busca os dados do formulário
            apelido = apelidoBox.Text;
            razaoSocial = razaoSocialBox.Text;
            cpfCnpj = cpfCnpjBox.Text;
            telefone = telefoneBox.Text;
            celular = celularBox.Text;
            email = emailBox.Text;
            //Transforma o item selecionado em um objeto e depois uma string
            Object selectedItem = tipoCombo.SelectedItem;
            if(selectedItem == null)
            {

            }
            else
            {
                tipo = selectedItem.ToString();
            }
           
            
            

            
            //Verifica o handle do tipo
            if(tipo != "")
            {
                String query1 = "SELECT HANDLE FROM US_TIPO WHERE NOME = '" + tipo + "'";
                SqlCommand cmd1 = new SqlCommand(query1,conexaoBanco);
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    tipoHandle = Convert.ToInt32(reader["HANDLE"].ToString());
                }
                reader.Close();
            }



            //Validações para cadastrar
            


         

            if(apelido != "")
            {
                if(razaoSocial != "")
                {
                    if(tipo != "")
                    {
                        if(cpfCnpj != "")
                        {
                            if(celular != "")
                            {
                                if (email != ""){
                                    //Query para dar insert nos dados
                                    String query2 = "INSERT INTO US_USUARIO (APELIDO, RAZAOSOCIAL, TIPO, CPFCNPJ, TELEFONE, CELULAR, EMAIL) VALUES ('" + apelido + "', '" + razaoSocial + "', '" + tipoHandle + "', '" + cpfCnpj + "', " + "'" + telefone + "', '" + celular + "', '" + email + "')";
                                    // MessageBox.Show(query2);
                                    SqlCommand cmd2 = new SqlCommand(query2, conexaoBanco);
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("Cadastrado");
                                }
                                else
                                {
                                    MessageBox.Show("Preencha o campo e-mail");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Preencha o campo celular");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha o campo Cpf/Cnpj");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione o Tipo");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo Razão Social");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Apelido");
            }
                  

            conexaoBanco.Close();

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaRegistro_Load(object sender, EventArgs e)
        {
            ////////fasdasdsa
            MessageBox.Show("dsa");
        }
    }

    
}
