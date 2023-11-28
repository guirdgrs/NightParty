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
        Classes.Usuario usuario = new Classes.Usuario();

        public GerenciamentoPlaylist(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            Classes.Playlist playlist = new Classes.Playlist();
            playlist.IdPlaylist = DateTime.Now.Day;
            dgvPlaylist.DataSource = playlist.Listar();

            Classes.Musica musica = new Classes.Musica();
            var r = musica.Listar();

            foreach (DataRow linha in r.Rows)
            {
                cmbMusica.Items.Add(linha.ItemArray[0].ToString() + " - "
                                  + linha.ItemArray[1].ToString());
            }

            nudDia.Minimum = 1;
            nudDia.Maximum = 31;

            nudDia.Text = DateTime.Now.Day.ToString();
            lblDia.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarDados()
        {
            Classes.Playlist playlist = new Classes.Playlist();
            playlist.IdPlaylist = int.Parse(nudDia.Text);
            dgvPlaylist.DataSource = playlist.Listar();

            cmbMusica.ResetText();
            txbMusicaAdd.Clear();
        }

        private void dgvPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvPlaylist.CurrentCell.RowIndex;
            var l = dgvPlaylist.Rows[Selecao];

            txbMusicaAdd.Text = l.Cells[0].Value.ToString() + " - " +
                                l.Cells[1].Value.ToString();

            txbMusicaAdd.Enabled = false;
        }

        private void btnAddMusica_Click(object sender, EventArgs e)
        {
            Classes.Playlist playlist = new Classes.Playlist();

            try
            {
                playlist.IdPlaylist = DateTime.Now.Day;
                playlist.IdMusica = int.Parse(cmbMusica.Text.Split('-')[0]);

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

        private void btnRemoverMusicaPl_Click(object sender, EventArgs e)
        {
            Classes.Playlist playlist = new Classes.Playlist();

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                try
                {
                    playlist.IdPlaylist = DateTime.Now.Day;
                    playlist.IdMusica = int.Parse(txbMusicaAdd.Text.Split('-')[0]);

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
