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
        Classes.Usuario usuario = new Classes.Usuario(); //Usuário global

        public Caixa(Classes.Usuario usuario) //Iniciando apenas com um usuário
        {
            InitializeComponent();

            this.usuario = usuario;

            btnEncerrar.BackColor = Color.IndianRed; //Cor do botão inicia como vermelho
        }

        private void pibSair_Click(object sender, EventArgs e) //Botão para fechar janela
        {
            Close();
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e) //Clicar na CHB de pagamento
        {
            btnEncerrar.Enabled = chbPagamento.Checked; //Status do botão é igual ao da CheckBox

            if (btnEncerrar.Enabled) //Pagamento = true;
            {
                btnEncerrar.BackColor = Color.LightGreen; //Botão verde
            }
            else //Pagamento = false;
            {
                btnEncerrar.BackColor = Color.IndianRed; //Botão vermelho
            }
        }

        private void pibPesquisar_Click(object sender, EventArgs e) //Botão de pesquisa
        {
            if(txbNumMesa.Text != "") //Condição para não pesquisar sem valor digitado
            {
                Classes.Pedido pedido = new Classes.Pedido(); //Instanciando um novo pedido

                pedido.NumPedido = int.Parse(txbNumMesa.Text); //Numero do pedido = txb

                var r = pedido.Buscar(); //Armazenando o resultado(DataTable) em uma var

                if(r.Rows.Count > 0) //Se o resultado for > 0 = Sucesso
                {
                    dgvPedidos.DataSource = r;

                    lblTotal.Text = "Total: R$ " + r.Compute("SUM(TotalPedido)", "True").ToString(); //Mostrando o total na label.
                }
                else //Se o resultado for < 0 = "Erro"
                {
                    MessageBox.Show("A mesa não possui itens registrados", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvPedidos.DataSource = null; //DGV = vazio

                    txbNumMesa.Clear();
                    lblTotal.Text = "Total: R$ 0,00";
                }
            }
            else //Se o número da mesa não for encontrado
            {
                MessageBox.Show("Número da mesa não encontrada","Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e) //Encerrar o pedido
        {
            Classes.Pedido pedido = new Classes.Pedido();

            pedido.NumPedido = int.Parse(txbNumMesa.Text);

            try
            {
                var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (pedido.Atualizar()) //true
                    {
                        MessageBox.Show("Pedido encerrado", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txbNumMesa.Clear();
                        dgvPedidos.DataSource = null;
                        btnEncerrar.Enabled = false;
                        btnEncerrar.BackColor = Color.IndianRed;

                        lblTotal.Text = "Total: R$";
                    }
                    else //false
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
