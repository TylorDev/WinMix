
using MySql.Data.MySqlClient; //Atinvando os Comandos do MySQL
using System;
using System.Windows.Forms;

namespace MUSIC_FINAL.Forms
{
    public partial class Frm_Seguranca : Base
    {
        Frm_Acesso acesso;
        //Criar Método publico para Consultar o nome no cadastro
        public void Consultar_Nome()
        {
            //Instanciando o objeto banco da Classe Banco
            Banco banco = new Banco();
            //usando o objeto banco para cessar o Metodo conectar da classe banco
            banco.Conectar();
            //Criando uma variavel string para armezenar o comando do BD(SELECT) para achar o nome cadastrado na tabela
            string sql = "SELECT * FROM tb_cadastro WHERE nome=@nome";
            //Instanciar o objeto cmd que permite a execução do comando do sql
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            //A variavel recebe o nome digitado e envia para a coluna da tabela
            cmd.Parameters.AddWithValue("@nome", Variaveis.nome);
            
                //Executando a leitura no BD para achar o nome
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //A variavel id esta recebendo o id do usuario encontrado na na Tabela do BD
                    Variaveis.id = reader.GetInt32(0);
                    Txt_Nome.Enabled = false;
                    MessageBox.Show("Ola, " + Variaveis.nome + " digite a  sua nova senha!!!", "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_NovaSenha.Enabled = true;
                    //Digitação nova senha
                    Txt_NovaSenha.Focus();
                }
                else //Se o nomme do usuario não for encontrado
                {
                MessageBox.Show("O Usuario: " + Variaveis.nome + "não encontrado", "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            
                                            

           

            //Condiçao se o usuario foi encontrado

            banco.Desconectar();



        }
       //Criando o metodo  Trocar  Senha 
       public void Trocar_Senha()
        {
            //Estrutura de tratamento de Erros
            try
            {
                //Instanciando o objeto Banco da clase Banco
                Banco banco = new Banco();
                //Usando o objeto banco para usar o Metodo Conectar da Clase Banco

                banco.Conectar();

                //Criar variavel string para usar o comando do bd (UPDATE) para trocar a senha
                string sql = "UPDATE tb_cadastro SET senha=@senha  WHERE id=@id";

                //Instanciando o objeto cmd para executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

                //As variaveis recebe, os dados digitados e enviam para as colunas da Tabela do BD
                cmd.Parameters.AddWithValue("@senha", Variaveis.senha);
                cmd.Parameters.AddWithValue("@id", Variaveis.id);
                //Executando todos os comandos do sql
                cmd.ExecuteNonQuery();
                //Fechando o BD
                banco.Desconectar();
                //Mensagem de Confirmação
                MessageBox.Show(Variaveis.nome + ",sua nova senha foi atualizada com Sucesso!!!", "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                Frm_Login login = new Frm_Login(acesso);
                login.Show();
                Hide();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                MessageBox.Show( Variaveis.nome + "erro ao trocar sua senha", "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Frm_Seguranca(Frm_Acesso frm)
        {
            acesso = frm;
            InitializeComponent();
        }

        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                MessageBox.Show("Por favor digite apenas letras.","Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {



                if (Txt_Nome.Text.Length > 2)
                {
                    Variaveis.nome = Txt_Nome.Text;
                    Consultar_Nome();

                }
                else
                {
                    MessageBox.Show("Digite pelo menos 3 letras", "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
            }
        }


        private void Txt_NovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                if (Txt_NovaSenha.Text.Length > 7)
                {
                    
                    Variaveis.senha = Txt_NovaSenha.Text;
                    Txt_ConfirmarSenha.Enabled = true;
                    Txt_ConfirmarSenha.Focus();
                    

                }
                else
                {
                    MessageBox.Show("Digite pelo menos 8 caracteres","Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
            }
        }

        private void Txt_ConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                if (Txt_ConfirmarSenha.Text == Txt_NovaSenha.Text)
                {
            
                    Variaveis.senha = Txt_ConfirmarSenha.Text;
                    Txt_NovaSenha.Enabled = false;
                    Txt_ConfirmarSenha.Enabled = false;
                    Btn_Salvar.Visible = true;
                }
                else
                {
                    MessageBox.Show("As senhas não são iguais, tente novamente.", "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_ConfirmarSenha.Clear();
                    Txt_ConfirmarSenha.Enabled = false;
                    Txt_NovaSenha.Clear();
                    Txt_NovaSenha.Focus ();
                    Btn_Salvar.Visible = false;
                            
                }

                e.Handled = true;
            }
        }

        private void Frm_Seguranca_Load(object sender, EventArgs e)
        {
            InitializeWebBackground("http://localhost:5173/#cadastro", sender, e);
        }

        private void Btn_Salvar_OnClick(object sender, EventArgs e)
        {
            //Usando o Método Trocar Senha
            Trocar_Senha();
        }

        private void button1_OnClick(object sender, EventArgs e)
        {
            acesso.Show();
            this.Close();
        }
    }
}
