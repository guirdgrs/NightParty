using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace NightParty.Views
{
    public partial class GerenciamentoPedidos : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        int NumMesa = 0;

        public GerenciamentoPedidos(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            Classes.Produto comidas = new Classes.Produto();
            dgvComida.DataSource = comidas.ListarComidas();

            Classes.Produto bebidas = new Classes.Produto();
            dgvBebidas.DataSource = bebidas.ListarBebidas();

            //Estabelecendo a qtd max. e min. dos NUD's
            nudQtdProduto.Minimum = 1;
            nudQtdProduto.Maximum = 100;
        }
        public void AtualizarDados()
        {
            Classes.Produto comidas = new Classes.Produto();
            dgvComida.DataSource = comidas.ListarComidas();

            Classes.Produto bebidas = new Classes.Produto();
            dgvBebidas.DataSource = bebidas.ListarBebidas();

            txbProduto.Clear();
            txbIdProduto.Clear();
            txbMesa.Clear();

            grbPedido.Enabled = false;
            grbLancamento.Enabled = true;
        }


        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvBebidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvBebidas.CurrentCell.RowIndex;
            var l = dgvBebidas.Rows[Selecao];

            txbProduto.Text = l.Cells[1].Value.ToString();
            txbIdProduto.Text = l.Cells[0].Value.ToString();
        }

        private void dgvComida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvComida.CurrentCell.RowIndex;
            var l = dgvComida.Rows[Selecao];

            txbProduto.Text = l.Cells[1].Value.ToString();
            txbIdProduto.Text = l.Cells[0].Value.ToString();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txbMesa.Text != "" && txbIdProduto.Text != "")
            {
                grbPedido.Enabled = true;
                grbLancamento.Enabled = false;

                NumMesa = int.Parse(txbMesa.Text);
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Confirmar pedido?", "Aviso!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Classes.Pedido pedido = new Classes.Pedido();

                pedido.NumPedido = int.Parse(txbMesa.Text);
                pedido.IdProduto = int.Parse(txbIdProduto.Text);
                pedido.Quantidade = int.Parse(nudQtdProduto.Text);
                pedido.IdUsuario = usuario.Id;

                if (pedido.NovoPedido())
                {
                    MessageBox.Show("Pedido efetuado!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();

                    var r1 = MessageBox.Show("Deseja adicionar outro produto?", "Aviso!",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r1 == DialogResult.Yes)
                    {
                        txbMesa.Text = NumMesa.ToString();
                    }
                    else
                    {
                        AtualizarDados();
                    }
                }
                else
                {
                    MessageBox.Show("Falha no lançamento!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    AtualizarDados();
                }
            }
        
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }
    }
}
