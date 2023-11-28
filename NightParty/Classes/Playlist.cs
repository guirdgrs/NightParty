using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightParty.Classes
{
    public class Playlist
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdArtista { get; set; }
        public int IdMusica { get; set; }
        public int IdPlaylist { get; set; }

        public DataTable Listar()
        {
            string comando = "SELECT * FROM view_playlist WHERE IDPlaylist = @id_playlist";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_playlist", IdPlaylist);

            cmd.Prepare();

            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);

            return tabela;
        }

        public bool NovaMusica()
        {
            string comando = "INSERT INTO musicaplaylist (idmusica, idplaylist) " +
                             "VALUES (@id_Musica, @id_Playlist)";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_Musica", IdMusica);
            cmd.Parameters.AddWithValue("@id_Playlist", IdPlaylist);

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

        public bool ApagarMusica()
        {
            string comando = "DELETE FROM musicaplaylist WHERE idmusica = @id_Musica " +
                            "AND idplaylist = @id_Playlist";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_Musica", IdMusica);
            cmd.Parameters.AddWithValue("@id_Playlist", IdPlaylist);
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

        public bool AdicionarNaPlaylist()
        {
            string comando = "INSERT INTO playlist(idplaylist, idmusica) " +
                             "VALUES (@id_Playlist, @id_Musica)";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_Playlist", IdPlaylist);
            cmd.Parameters.AddWithValue("@id_Musica", IdMusica);

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
        public bool RemoverDaPlaylist()
        {
            string comando = "DELETE FROM playlist WHERE idmusica = @id_Musica " +
                "AND idplaylist = @id_Playlist";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_Playlist", IdPlaylist);
            cmd.Parameters.AddWithValue("@id_Musica", IdMusica);

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
