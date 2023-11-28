using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightParty.Views
{
    public partial class Caixa : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();

        public Caixa(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            btnEncerrar.BackColor = Color.IndianRed;
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pibPesquisar_Click(object sender, EventArgs e)
        {
            if(txbNumMesa.Text != "")    
            {
                Classes.Pedido pedido = new Classes.Pedido();

                pedido.NumPedido = int.Parse(txbNumMesa.Text);

                var r = pedido.Buscar();

                if(r.Rows.Count > 0)
                {
                    dgvPedidos.DataSource = r;

                    lblTotal.Text = "Total: R$ " + r.Compute("SUM(TotalPedido)", "True").ToString();
                }
                else
                {
                    MessageBox.Show("A mesa não possui itens registrados", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvPedidos.DataSource = null;

                    txbNumMesa.Clear();
                    lblTotal.Text = "Total: R$ 0,00";
                }
            }
            else
            {
                MessageBox.Show("Número da mesa não encontrada","Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbPagamento.Checked;

            if (btnEncerrar.Enabled)
            {
                btnEncerrar.BackColor = Color.LightGreen;
            }
            else
            {
                btnEncerrar.BackColor = Color.IndianRed;
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Classes.Pedido pedido = new Classes.Pedido();
            pedido.NumPedido = int.Parse(txbNumMesa.Text);

            try
            {
                var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (pedido.Atualizar())
                    {
                        MessageBox.Show("Pedido encerrado", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txbNumMesa.Clear();
                        dgvPedidos.DataSource = null;

                        lblTotal.Text = "Total: R$";
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
