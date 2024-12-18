using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Para usar comandos de Forms
using MySql.Data.MySqlClient; // Para usar a linguagem de Banco de Dados na programação do C#.

namespace MUSIC_FINAL
{
     public class Banco //Deixando a Clase Banco publica
    {

        //Criando a string de conexão  com a localizão do banco de dados
        string bd = "SERVER=localhost;USER=root;DATABASE=bd_usuarios";
        //Criando Conexão
        public MySqlConnection conexao;
        //Criando o Método de conectar(Abrir o BD)
        public void Conectar()
        {
            //Usando  a Escructura de Tratamento de Erros

            try // Tentativa de Execuçao do Código Dar Certo 
            {
                //Instanciando o objeto para fazer conexção com o nosso banco de dados.
                conexao = new MySqlConnection(bd);
                //Abrir o Banco de Dados
                conexao.Open();
        
                        
                
            }
            catch (Exception e) //Caso de Erro na Tentativa do Try
            {
                //Messagem de Erro de Tentativa de Conexão com o Bd
                MessageBox.Show(e.Message);
            }
         
        }
        //Criando o Método Desconectar (Fechar o BD)
        public void Desconectar()
        {
            try
            {    //Instanciando o objeto para fazer conexção com o nosso banco de dados.
                conexao = new MySqlConnection(bd);
                //fechando o Bando de Dados
                conexao.Close();

                //MessageBox.Show("Succes 2");


                if (conexao == null) {

                    MessageBox.Show("Err");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
    }
}
