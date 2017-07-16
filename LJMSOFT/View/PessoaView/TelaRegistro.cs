﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LJMSOFT.Mod;
using LJMSOFT.DAL;
using System.Data.SqlClient;

namespace LJMSOFT.View
{
    public partial class TelaRegistro : Form
    {
        private String apelido = "", razaoSocial = "", cpfCnpj = "", telefone = "", celular = "", email = "", tipo = "";
        private String ramoAtividade = "", setorAtividade = "", categoriaAtividade = "", descricao = "";
        String existeRazaoSocial = "", existeCpfCnpj = "", existeApelido = "";
        public static int tipoHandle = 0, pessoaHandle = 0;
    

        //conexao com banco
        Conexao conexao = new Conexao();

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


            conexao.Conectar();
            //Limpa a combo box
            tipoCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT NOME FROM US_TIPO";
            
            SqlDataReader reader = conexao.Pesquisa(query1);


            while (reader.Read())
            {
                tipoCombo.Items.Add((reader["NOME"].ToString()));
            }

            reader.Close();
            conexao.Desconectar();

        }

        private void keyDownf3RamoAtividade(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
              

            }
        }

        private void keyDownf3SetorAtividade(object sender, KeyEventArgs e)
        {

        }

        private void keyDownf3CategoriaAtividade(object sender, EventArgs e)
        {

        }

        private void tipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoCombo_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void tipoCombo_DropDownClosed(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Verifica se o combobox está vazio e atribui handle = 0
            tipoHandle = 0;
            Object selectedItem = tipoCombo.SelectedItem;
            if (selectedItem == null)
            {
                tipo = null;
            }
            else
            {
                tipo = selectedItem.ToString();
            }

            if (tipo != null)
            {
                
                String query1 = "SELECT HANDLE FROM US_TIPO WHERE NOME = '" + tipo + "'";

                SqlDataReader reader = conexao.Pesquisa(query1);

                while (reader.Read())
                {
                    tipoHandle = Convert.ToInt32(reader["HANDLE"].ToString());
                    
                }
                reader.Close();
            }

            conexao.Desconectar();


        }

        private void tipoCombo_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }

        private void TelaRegistro_Activated(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource Binding = new BindingSource();
            dataGridViewEndereco.AutoGenerateColumns = true;
            dataGridViewEndereco.DataSource = getData("SELECT NOME,CLSASE,LEVEL WHERE");
            dataGridViewEndereco.DataSource = Binding;
        }

        //Passa o tipo
        public static int getTipoHandle()
        {
            
            return tipoHandle;
             
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
                TelaTipoPessoa.ShowDialog();
                
            }
           
        }
  
     
        private void complementoTab_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GRAVAR

            conexao.Conectar();

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
                
                SqlDataReader reader = conexao.Pesquisa(query1);

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

                                    existeRazaoSocial = "1";
                                    existeCpfCnpj = "1";
                                    existeApelido = "1";

                                    //Verifica se já existe alguém com esses dados no banco
                                    String query1 = "SELECT RAZAOSOCIAL FROM US_USUARIO WHERE RAZAOSOCIAL = '" + razaoSocial + "'";
                                    String query2 = "SELECT CPFCNPJ FROM US_USUARIO WHERE CPFCNPJ = '" + cpfCnpj + "'";
                                    String query3 = "SELECT APELIDO FROM US_USUARIO WHERE APELIDO = '"+apelido+"'";
                                    SqlDataReader reader1 = conexao.Pesquisa(query1);


                                    while (reader1.Read())
                                    {
                                        existeRazaoSocial = reader1["RAZAOSOCIAL"].ToString();
                                    }

                                    reader1.Close();
                                    SqlDataReader reader2 = conexao.Pesquisa(query2);

                                    while (reader2.Read())
                                    {
                                        existeCpfCnpj = reader2["CPFCNPJ"].ToString();
                                    }

                                    reader2.Close();
                                    SqlDataReader reader3 = conexao.Pesquisa(query3);

                                    while (reader3.Read())
                                    {
                                        existeApelido = reader3["APELIDO"].ToString();
                                    }
                                    reader3.Close();






                                  
                                    //Se retornar vazio é pq não tem nenhum usuário com esses dados
                                    if (existeRazaoSocial == "1")
                                    {
                                        if(existeCpfCnpj == "1")
                                        {
                                            if(existeApelido == "1")
                                            {
                                                
                                                //Query para dar insert nos dados
                                                String query4 = "INSERT INTO US_USUARIO (APELIDO, RAZAOSOCIAL, TIPO, CPFCNPJ, TELEFONE, CELULAR, EMAIL) VALUES ('" + apelido + "', '" + razaoSocial + "', '" + tipoHandle + "', '" + cpfCnpj + "', " + "'" + telefone + "', '" + celular + "', '" + email + "')";
                                                conexao.Inserir(query4);
                                                

                                                //Verifica o complemento pertencente a essa pessoa
                                                String query5 = "SELECT HANDLE FROM US_USUARIO WHERE CPFCNPJ = '" + cpfCnpj + "'";
                                                SqlDataReader reader5 = conexao.Pesquisa(query5);
                                                while (reader5.Read())
                                                {
                                                    pessoaHandle = Convert.ToInt32(reader5["HANDLE"]);
                                                }
                                                reader5.Close();

                                                //Salva o complemento correspondente a pessoa
                                                String query6 = "INSERT INTO US_COMPLEMENTO (PESSOA, RAMOATIVIDADE, SETORATIVIDADE, CATEGORIAATIVIDADE, DESCRICAO) VALUES ('"+pessoaHandle+"', '"+ramoAtividade+ "', '" + setorAtividade + "', '" + categoriaAtividade + "', '" + descricao + "')";
                                                conexao.Inserir(query6);
                                                MessageBox.Show("Cadastrado");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Já existe um usuário com este apelido cadastrado");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Já existe um usuário com este cpf ou cnpj cadastrado");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Já existe um usuário com está razão social cadastrada");
                                        existeRazaoSocial = "";
                                        existeCpfCnpj = "";
                                        existeApelido = "";
                                    }


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


            conexao.Desconectar();

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
            
        }
    }

    
}
