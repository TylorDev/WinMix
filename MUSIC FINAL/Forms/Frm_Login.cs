using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Para usar os comandos  de BD do  MYSQL


namespace MUSIC_FINAL.Forms
{
    public partial class Frm_Login : Base
    {

        Frm_Acesso acesso;


        //Criando Método Público  para Consultar se o Usuario já existe
        public void Consultar_Nome()
        {
            //Instanciar o objeto banco da clase Banco
            Banco banco = new Banco();
            banco.Conectar();

            //Criando uma variavel string (SELECT) para guardar o comando do BD
            string sql = "SELECT * FROM  tb_cadastro WHERE nome=@nome AND senha=@senha";
            //Instanciando o objeto cmd que permite a execução SQL
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao) ;

            //As variáveis recebem os dados digitados e verifica se o nome e a senha estão cadastrados
            cmd.Parameters.AddWithValue("@nome", Variaveis.nome);
            cmd.Parameters.AddWithValue("@senha", Variaveis.senha);
            //fazendo a leitura ba Tabela do Bd para localizar o nome e a senha
            MySqlDataReader reader = cmd.ExecuteReader();
  
            //Condição  se o nome a senha foram encontrados
            if (reader.Read())
            {
                //Mensagem  de Confirmaçao
                MessageBox.Show("Login Feito com Sucesso!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Abrir a Tela das Músicas   
                Variaveis.frm_Player.Show();
                Hide();
            }
            else
            {
 
                MessageBox.Show("Usuário Não Cadastrado!! ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Nome.Clear();
                Txt_Nome.Focus();
                Txt_Senha.Clear();
            
            }
            banco.Desconectar();
        }
        public Frm_Login(Frm_Acesso frm)
        {
            acesso = frm;
            InitializeComponent();
          
        }

        private void label1_OnClick(object sender, EventArgs e)
        {
            Frm_Cadastro frm_cadastro = new Frm_Cadastro(acesso);
            frm_cadastro.Show();
            this.Close();

        }

        private void label2_OnClick(object sender, EventArgs e)
        {
            Frm_Seguranca frm_cadastro = new Frm_Seguranca(acesso);
            frm_cadastro.Show();
            Close();
            
        }

        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                MessageBox.Show("Por favor digite apenas letras.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {



                if (Txt_Nome.Text.Length > 2)
                {
                  
                    Txt_Senha.Enabled = true;
                    Txt_Senha.Focus();
                }
                else
                {
                    MessageBox.Show("Digite pelo menos 3 letras", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
            }
        }

        private void Txt_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                if (Txt_Senha.Text.Length > 7)
                {
                  
                   
                    Btn_Entrar.Visible = true;
                    Btn_Entrar.Focus();

                }
                else
                {
                    MessageBox.Show("Digite pelo menos 8 caracteres", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            InitializeWebBackground("http://localhost:5173/#cadastro", sender, e);
            Variaveis.BackgroundForm.Show();
        }

        private void Btn_Entrar_OnClick(object sender, EventArgs e)
        {
            Variaveis.nome = Txt_Nome.Text;
            Variaveis.senha = Txt_Senha.Text;
            Consultar_Nome(); //Usando o Método que busca o nome e a Senha na Tabela do BD;
        }

        private void button1_OnClick(object sender, EventArgs e)
        {
            acesso.Show();
            this.Close();
        }
    }
}
