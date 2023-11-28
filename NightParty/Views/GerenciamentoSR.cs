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
using static System.Windows.Forms.LinkLabel;

namespace NightParty.Views
{
    public partial class GerenciamentoSR : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        int IdArtistaSelecionado = 0;
        int IdMusicaSelecionado = 0;

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
            grbEditar.Enabled = true;
            txbArtistaEdi.Enabled = false;
            txbMusicaEdi.Enabled = true;
            cmbArtistasEdi.Enabled = true;

            txbArtistaEdi.Clear();

            int Selecao = dgvMusicas.CurrentCell.RowIndex;
            var l = dgvMusicas.Rows[Selecao];

            txbMusicaEdi.Text = l.Cells[0].Value.ToString() + " - " +
                                l.Cells[1].Value.ToString();

            cmbArtistasEdi.Text = l.Cells[2].Value.ToString() + " - " +
                                     l.Cells[3].Value.ToString();

            IdMusicaSelecionado = (int)l.Cells[0].Value;
        }

        private void dgvArtistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grbEditar.Enabled = true;
            txbArtistaEdi.Enabled = true;
            txbMusicaEdi.Enabled = false;
            cmbArtistasEdi.Enabled = false;

            txbMusicaEdi.Clear();
            cmbArtistasEdi.ResetText();

            int Selecao = dgvArtistas.CurrentCell.RowIndex;
            var l = dgvArtistas.Rows[Selecao];

            txbArtistaEdi.Text = l.Cells[0].Value.ToString() + " - " + 
                                 l.Cells[1].Value.ToString();

            IdArtistaSelecionado = (int)l.Cells[0].Value;
        }

        private void btnMusicaAdd_Click(object sender, EventArgs e)
        {
            Classes.Musica musica = new Classes.Musica();

            try
            {
                musica.Nome = txbMusicaAdd.Text;
                musica.IdArtista = int.Parse(cmbArtistas.Text.Split('-')[0]);
                musica.IdUsuario = usuario.Id;

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
                musica.Id = IdMusicaSelecionado;

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

            if (txbArtistaEdi.Text == "")
            {
                musica.Id = IdMusicaSelecionado;
                musica.Nome = txbMusicaEdi.Text.Split('-')[1];
                musica.IdArtista = int.Parse(cmbArtistasEdi.Text.Split('-')[0]);
                musica.IdUsuario = usuario.Id;

                if (musica.Editar())
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
            else if(txbArtistaEdi.Text != "")
            {
                artista.Id = IdArtistaSelecionado;
                artista.Nome = txbArtistaEdi.Text.Split('-')[1];

                if (artista.Editar())
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
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoPlaylist janela = new GerenciamentoPlaylist(usuario);
            janela.Show();
        }

        private void btnArtistaRmv_Click(object sender, EventArgs e)
        {
            Classes.Artista artista = new Classes.Artista();

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                try
                {
                    artista.Id = IdArtistaSelecionado;

                    if (artista.Apagar())
                    {
                        MessageBox.Show("Artista removido(a) da playlist!", "Sucesso",
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
