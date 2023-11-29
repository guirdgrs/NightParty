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
        Classes.Usuario usuario = new Classes.Usuario(); //Usuário global
        int NumMesa = 0; //Var. para armazenar o número da mesa

        public GerenciamentoPedidos(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            //Preenchendo o DGV com as "Comidas"
            Classes.Produto comidas = new Classes.Produto();
            dgvComida.DataSource = comidas.ListarComidas();

            //Preenchendo o DGV com as "Bebidas"
            Classes.Produto bebidas = new Classes.Produto();
            dgvBebidas.DataSource = bebidas.ListarBebidas();

            //Estabelecendo a qtd max. e min.
            nudQtdProduto.Minimum = 1;
            nudQtdProduto.Maximum = 100;
        }

        public void AtualizarDados() //Método para atualizar o DGV e limpar os campos
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

            nudQtdProduto.Text = "1";
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvBebidas_CellClick(object sender, DataGridViewCellEventArgs e) //View_bebidas
        {
            int Selecao = dgvBebidas.CurrentCell.RowIndex;
            var l = dgvBebidas.Rows[Selecao];

            //Preenchendo os campos com o resultado do "Click" no DGV
            txbProduto.Text = l.Cells[1].Value.ToString();
            txbIdProduto.Text = l.Cells[0].Value.ToString();
        }

        private void dgvComida_CellClick(object sender, DataGridViewCellEventArgs e) //View_comidas
        {
            int Selecao = dgvComida.CurrentCell.RowIndex;
            var l = dgvComida.Rows[Selecao];

            //Preenchendo os campos com o resultado do "Click" no DGV
            txbProduto.Text = l.Cells[1].Value.ToString();
            txbIdProduto.Text = l.Cells[0].Value.ToString();
        }
        private void btnContinuar_Click(object sender, EventArgs e) //Botão para continuar o pedido
        {
            if (txbMesa.Text != "" && txbIdProduto.Text != "") //Condição para não avançar com os campos vazios
            {
                //Ativando os GRB's
                grbPedido.Enabled = true;
                grbLancamento.Enabled = false;

                NumMesa = int.Parse(txbMesa.Text); //Armazenando o número da mesa na var global.
            }
            else //Se botão for clicado sem os campos devidamente preenchidos
            {
                MessageBox.Show("Verifique as informações digitadas",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLancar_Click(object sender, EventArgs e) //Botão para lançar o pedido para o banco de dados
        {
            //Janela de confirmação
            var r = MessageBox.Show("Confirmar pedido?", "Aviso!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Classes.Pedido pedido = new Classes.Pedido();
                try
                {
                    //Obtendos os valores de acordo com os campos
                    pedido.NumPedido = int.Parse(txbMesa.Text);
                    pedido.IdProduto = int.Parse(txbIdProduto.Text);
                    pedido.Quantidade = int.Parse(nudQtdProduto.Text);  
                    pedido.IdUsuario = usuario.Id; //Id do usuário = id do usuário global

                    if (pedido.NovoPedido())
                    {
                        MessageBox.Show("Pedido efetuado!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();

                        //Janela de confirmação para adicionar outro produto a mesma mesa
                        var r1 = MessageBox.Show("Deseja adicionar outro produto?", "Aviso!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (r1 == DialogResult.Yes)
                        {
                            txbMesa.Text = NumMesa.ToString(); //Preenchendo o campo com o valor da var. global
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
                catch
                {
                    MessageBox.Show("Falha no lançamento!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    AtualizarDados();
                }
            }
        
        }
        private void btnCancelar_Click(object sender, EventArgs e) //Botão para cancelar o pedido
        {
            AtualizarDados();
        }
    }
}
