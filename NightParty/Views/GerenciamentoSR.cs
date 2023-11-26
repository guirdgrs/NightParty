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
    public partial class GerenciamentoSR : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();

        public GerenciamentoSR(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            Classes.Musica musica = new Classes.Musica();
            dgvMusicas.DataSource = musica.Listar();

            Classes.Artista artista = new Classes.Artista();
            dgvArtistas.DataSource = artista.Listar();

            var r = artista.Listar();

            foreach (DataRow linha in r.Rows)
            {
                cmbArtistas.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());

                cmbArtistasEdi.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());
            }
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarDados()
        {
            Classes.Musica musica = new Classes.Musica();
            dgvMusicas.DataSource = musica.Listar();

            Classes.Artista artista = new Classes.Artista();
            dgvArtistas.DataSource = artista.Listar();

            txbMusicaAdd.Clear();
            txbArtistaAdd.Clear();
            txbArtistaEdi.Clear();
            txbMusicaEdi.Clear();

            grbEditar.Enabled = false;
        }

        private void dgvMusicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvMusicas.CurrentCell.RowIndex;
            var l = dgvMusicas.Rows[Selecao];

            txbMusicaEdi.Text = l.Cells[0].Value.ToString();
            txbArtistaEdi.Text = l.Cells[1].Value.ToString();
        }

        private void dgvArtistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvArtistas.CurrentCell.RowIndex;
            var l = dgvArtistas.Rows[Selecao];

            txbArtistaEdi.Text = l.Cells[1].Value.ToString();
        }

        private void btnMusicaAdd_Click(object sender, EventArgs e)
        {
            Classes.Musica musica = new Classes.Musica();

            musica.Nome = txbMusicaAdd.Text;
            musica.IdArtista = int.Parse(cmbArtistas.Text.Split('-')[0]);
            musica.IdUsuario = usuario.Id;

            try
            {
                if (musica.Cadastrar())
                {
                    MessageBox.Show("Música adicionada!", "Sucesso",
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

        private void btnArtistaAdd_Click(object sender, EventArgs e)
        {
            Classes.Artista artista = new Classes.Artista();

            artista.Nome = txbArtistaAdd.Text;
            
            try
            {
                if (artista.Adicionar())
                {
                    MessageBox.Show("Artista(s) adicionada(o)!", "Sucesso",
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

        private void btnMusicaRmv_Click(object sender, EventArgs e)
        {
            Classes.Musica musica = new Classes.Musica();
            try
            {
                if (musica.Apagar())
                {
                    MessageBox.Show("Música removida!", "Sucesso",
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Musica musica = new Classes.Musica();
            Classes.Artista artista = new Classes.Artista();

            musica.Nome = txbMusicaEdi.Text;
            musica.IdArtista = int.Parse(cmbArtistasEdi.Text.Split('-')[0]);
            artista.Nome = txbArtistaEdi.Text;

            try
            {
                if (musica.Editar() || artista.Editar())
                {
                    MessageBox.Show("Edição concluída!", "Sucesso",
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

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoPlaylist janela = new GerenciamentoPlaylist();
            janela.Show();
        }
    } 
}
