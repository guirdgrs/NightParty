﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightParty.Classes
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public DataTable Logar()
        {
            string comando = "SELECT id,nome_completo, email, senha" +
                " FROM usuarios WHERE email = @email AND senha = @senha";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@email", Email);

            var hashsenha = EasyEncryption.SHA.ComputeSHA1Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);

            cmd.Prepare();
            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);

            return tabela;
        }

        public DataTable ListarTudo()
        {
            string comando = "SELECT id, nome_completo, email FROM usuarios";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();

            DataTable tabela = new DataTable();


            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);

            return tabela;
        }

        public bool Novo()
        {
            string comando = "INSERT INTO usuarios (nome_completo, email, senha) " +
                             "VALUES (@nome_completo, @email, @senha)";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@email", Email);


            var hashsenha = EasyEncryption.SHA.ComputeSHA1Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool Apagar()
        {
            string comando = "DELETE FROM usuarios WHERE id = @id";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool Editar()
        {
            string comando = "UPDATE usuarios SET nome_completo = @nome_completo, email = @email, " +
                             "senha = @senha WHERE id = @id";

            if (Senha == "")
            {
                comando = "UPDATE usuarios SET nome_completo = @nome_completo, email = @email WHERE id = @id";
            }

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@email", Email);

            var hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
