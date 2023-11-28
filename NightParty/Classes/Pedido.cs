using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightParty.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public int NumPedido { get; set; }
        public int IdUsuario { get; set; }
        public int IdProduto {  get; set; }
        public int Quantidade { get; set; }
        public int Status { get; set; }
        public DateTime Data { get; set; }

        public bool NovoPedido()
        {
            string comando = "INSERT INTO pedidos (numpedido, idusuario, idproduto, quantidade ) " +
                             "VALUES (@num_pedido, @id_Usuario, @id_Produto, @quantidade) ";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_pedido", NumPedido);
            cmd.Parameters.AddWithValue("@id_Usuario", IdUsuario);
            cmd.Parameters.AddWithValue("@id_Produto", IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);

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

        public DataTable Buscar()
        {
            string comando = "SELECT * FROM view_pedidos WHERE NumeroDaMesa = @num_pedido";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_pedido", NumPedido);

            cmd.Prepare();

            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);

            return tabela;
        }

        public bool Atualizar()
        {
            string comando = "UPDATE pedidos SET status = 0 " +
                             "WHERE numpedido = @num_pedido AND status = 1";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_pedido", NumPedido);

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
