using NightParty.Classes;
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
    public partial class GerenciamentoPlaylist : Form
    {
        Classes.Usuario usuario = new Classes.Usuario(); //Usuário global

        public GerenciamentoPlaylist(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            Classes.Playlist playlist = new Classes.Playlist(); //Instanciando uma nova playlist
            playlist.IdPlaylist = DateTime.Now.Day; //Id da playlist = Dia de hoje

            dgvPlaylist.DataSource = playlist.Listar(); //Preenchendo o DGV

            Classes.Musica musica = new Classes.Musica(); //Instanciando uma nova musica
            var r = musica.Listar(); //Armazenando a view em uma var.

            foreach (DataRow linha in r.Rows) //Preenchendo o ComboBox com o resultado da view
            {
                cmbMusica.Items.Add(linha.ItemArray[0].ToString() + " - "
                                  + linha.ItemArray[1].ToString());
            }

            //Quantidade mínima e máxima de dias do NumberUpAndDown
            nudDia.Minimum = 1;
            nudDia.Maximum = 31;

            nudDia.Text = DateTime.Now.Day.ToString(); //Valor inicial do NUD = Dia de hoje

            lblDia.Text = DateTime.Today.ToString("dd/MM/yyyy"); //Preenchendo a label com a data atual
        }

        private void pibSair_Click(object sender, EventArgs e) //Botão de sair
        {
            Close();
        }

        private void AtualizarDados() //Método para atualizar os dados
        {
            Classes.Playlist playlist = new Classes.Playlist();

            playlist.IdPlaylist = int.Parse(nudDia.Text); //Id da playlist = valor do NUD

            dgvPlaylist.DataSource = playlist.Listar();

            cmbMusica.ResetText();
            txbMusicaAdd.Clear();
        }

        private void dgvPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvPlaylist.CurrentCell.RowIndex;
            var l = dgvPlaylist.Rows[Selecao];

            //Preenchendo o TXB com o resultado do click
            txbMusicaAdd.Text = l.Cells[0].Value.ToString() + " - " +
                                l.Cells[1].Value.ToString();

            txbMusicaAdd.Enabled = false; //Desabilitando o TXB para não mudar o valor
        }

        private void btnAddMusica_Click(object sender, EventArgs e) //Botão para adicionar música à playlist
        {
            Classes.Playlist playlist = new Classes.Playlist();

            if(cmbMusica.Text == "")
            {
                MessageBox.Show("Escolha uma música", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    //Obtendo os valores
                    playlist.IdPlaylist = DateTime.Now.Day; //Id da playlist = Dia de hoje
                    playlist.IdMusica = int.Parse(cmbMusica.Text.Split('-')[0]); //Id da música = Id no ComboBox

                    //Executando um INSERT na tabela musicaplaylist e outro na tabela playlist no banco de dados
                    if (playlist.NovaMusica() && playlist.AdicionarNaPlaylist())
                    {
                        MessageBox.Show("Música adicionada a playlist!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoverMusicaPl_Click(object sender, EventArgs e)
        {
            Classes.Playlist playlist = new Classes.Playlist();

            if(txbMusicaAdd.Text == "")
            {
                MessageBox.Show("Clique em uma música acima", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Janela de confirmação
                var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    try
                    {
                        playlist.IdPlaylist = DateTime.Now.Day;
                        playlist.IdMusica = int.Parse(txbMusicaAdd.Text.Split('-')[0]);  //Id da música = Id no TextBox

                        //Executando um DELETE na tabela musicaplaylist e outro na tabela playlist no banco de dados
                        if (playlist.ApagarMusica() && playlist.RemoverDaPlaylist())
                        {
                            MessageBox.Show("Música removida da playlist!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AtualizarDados();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu um erro", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
