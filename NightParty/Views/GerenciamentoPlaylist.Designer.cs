namespace NightParty.Views
{
    partial class GerenciamentoPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoPlaylist));
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbAddMusicaPlaylist = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRemoverMusicaPl = new System.Windows.Forms.Button();
            this.cmbArtista = new System.Windows.Forms.ComboBox();
            this.btnAddMusica = new System.Windows.Forms.Button();
            this.txbNomeNovo = new System.Windows.Forms.TextBox();
            this.lblAddArtista = new System.Windows.Forms.Label();
            this.lblAddNome = new System.Windows.Forms.Label();
            this.grbEditarMusicaPlaylist = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbArtistaEdi = new System.Windows.Forms.ComboBox();
            this.btnEditarMusica = new System.Windows.Forms.Button();
            this.txbMusicaEdi = new System.Windows.Forms.TextBox();
            this.lblArtistaEdi = new System.Windows.Forms.Label();
            this.lblMusicaEdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.grbAddMusicaPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbEditarMusicaPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pibSair
            // 
            this.pibSair.BackColor = System.Drawing.Color.Transparent;
            this.pibSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(811, 13);
            this.pibSair.Margin = new System.Windows.Forms.Padding(4);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(39, 42);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 22;
            this.pibSair.TabStop = false;
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.AllowUserToAddRows = false;
            this.dgvPlaylist.AllowUserToDeleteRows = false;
            this.dgvPlaylist.AllowUserToResizeColumns = false;
            this.dgvPlaylist.AllowUserToResizeRows = false;
            this.dgvPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Location = new System.Drawing.Point(103, 84);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.Size = new System.Drawing.Size(664, 275);
            this.dgvPlaylist.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(272, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(325, 40);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "     Playlist do Dia     ";
            // 
            // grbAddMusicaPlaylist
            // 
            this.grbAddMusicaPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.grbAddMusicaPlaylist.Controls.Add(this.pictureBox2);
            this.grbAddMusicaPlaylist.Controls.Add(this.btnRemoverMusicaPl);
            this.grbAddMusicaPlaylist.Controls.Add(this.cmbArtista);
            this.grbAddMusicaPlaylist.Controls.Add(this.btnAddMusica);
            this.grbAddMusicaPlaylist.Controls.Add(this.txbNomeNovo);
            this.grbAddMusicaPlaylist.Controls.Add(this.lblAddArtista);
            this.grbAddMusicaPlaylist.Controls.Add(this.lblAddNome);
            this.grbAddMusicaPlaylist.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddMusicaPlaylist.ForeColor = System.Drawing.Color.White;
            this.grbAddMusicaPlaylist.Location = new System.Drawing.Point(36, 381);
            this.grbAddMusicaPlaylist.Name = "grbAddMusicaPlaylist";
            this.grbAddMusicaPlaylist.Size = new System.Drawing.Size(358, 214);
            this.grbAddMusicaPlaylist.TabIndex = 25;
            this.grbAddMusicaPlaylist.TabStop = false;
            this.grbAddMusicaPlaylist.Text = "Adicionar / Remover";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnRemoverMusicaPl
            // 
            this.btnRemoverMusicaPl.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoverMusicaPl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverMusicaPl.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverMusicaPl.Location = new System.Drawing.Point(25, 170);
            this.btnRemoverMusicaPl.Name = "btnRemoverMusicaPl";
            this.btnRemoverMusicaPl.Size = new System.Drawing.Size(306, 31);
            this.btnRemoverMusicaPl.TabIndex = 19;
            this.btnRemoverMusicaPl.Text = "Remover";
            this.btnRemoverMusicaPl.UseVisualStyleBackColor = false;
            // 
            // cmbArtista
            // 
            this.cmbArtista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtista.FormattingEnabled = true;
            this.cmbArtista.Location = new System.Drawing.Point(114, 84);
            this.cmbArtista.Name = "cmbArtista";
            this.cmbArtista.Size = new System.Drawing.Size(217, 27);
            this.cmbArtista.TabIndex = 18;
            // 
            // btnAddMusica
            // 
            this.btnAddMusica.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddMusica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMusica.ForeColor = System.Drawing.Color.Black;
            this.btnAddMusica.Location = new System.Drawing.Point(25, 133);
            this.btnAddMusica.Name = "btnAddMusica";
            this.btnAddMusica.Size = new System.Drawing.Size(306, 31);
            this.btnAddMusica.TabIndex = 6;
            this.btnAddMusica.Text = "Adicionar";
            this.btnAddMusica.UseVisualStyleBackColor = false;
            // 
            // txbNomeNovo
            // 
            this.txbNomeNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeNovo.Location = new System.Drawing.Point(114, 51);
            this.txbNomeNovo.Name = "txbNomeNovo";
            this.txbNomeNovo.Size = new System.Drawing.Size(217, 27);
            this.txbNomeNovo.TabIndex = 2;
            // 
            // lblAddArtista
            // 
            this.lblAddArtista.AutoSize = true;
            this.lblAddArtista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddArtista.Location = new System.Drawing.Point(21, 84);
            this.lblAddArtista.Name = "lblAddArtista";
            this.lblAddArtista.Size = new System.Drawing.Size(90, 23);
            this.lblAddArtista.TabIndex = 1;
            this.lblAddArtista.Text = "Artista(s)";
            // 
            // lblAddNome
            // 
            this.lblAddNome.AutoSize = true;
            this.lblAddNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNome.Location = new System.Drawing.Point(21, 51);
            this.lblAddNome.Name = "lblAddNome";
            this.lblAddNome.Size = new System.Drawing.Size(66, 23);
            this.lblAddNome.TabIndex = 0;
            this.lblAddNome.Text = "Nome";
            // 
            // grbEditarMusicaPlaylist
            // 
            this.grbEditarMusicaPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.grbEditarMusicaPlaylist.Controls.Add(this.pictureBox3);
            this.grbEditarMusicaPlaylist.Controls.Add(this.cmbArtistaEdi);
            this.grbEditarMusicaPlaylist.Controls.Add(this.btnEditarMusica);
            this.grbEditarMusicaPlaylist.Controls.Add(this.txbMusicaEdi);
            this.grbEditarMusicaPlaylist.Controls.Add(this.lblArtistaEdi);
            this.grbEditarMusicaPlaylist.Controls.Add(this.lblMusicaEdi);
            this.grbEditarMusicaPlaylist.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditarMusicaPlaylist.ForeColor = System.Drawing.Color.White;
            this.grbEditarMusicaPlaylist.Location = new System.Drawing.Point(468, 381);
            this.grbEditarMusicaPlaylist.Name = "grbEditarMusicaPlaylist";
            this.grbEditarMusicaPlaylist.Size = new System.Drawing.Size(358, 214);
            this.grbEditarMusicaPlaylist.TabIndex = 26;
            this.grbEditarMusicaPlaylist.TabStop = false;
            this.grbEditarMusicaPlaylist.Text = "Editar";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // cmbArtistaEdi
            // 
            this.cmbArtistaEdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtistaEdi.FormattingEnabled = true;
            this.cmbArtistaEdi.Location = new System.Drawing.Point(114, 97);
            this.cmbArtistaEdi.Name = "cmbArtistaEdi";
            this.cmbArtistaEdi.Size = new System.Drawing.Size(217, 27);
            this.cmbArtistaEdi.TabIndex = 18;
            // 
            // btnEditarMusica
            // 
            this.btnEditarMusica.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditarMusica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMusica.ForeColor = System.Drawing.Color.Black;
            this.btnEditarMusica.Location = new System.Drawing.Point(25, 154);
            this.btnEditarMusica.Name = "btnEditarMusica";
            this.btnEditarMusica.Size = new System.Drawing.Size(306, 31);
            this.btnEditarMusica.TabIndex = 6;
            this.btnEditarMusica.Text = "Editar";
            this.btnEditarMusica.UseVisualStyleBackColor = false;
            // 
            // txbMusicaEdi
            // 
            this.txbMusicaEdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMusicaEdi.Location = new System.Drawing.Point(114, 64);
            this.txbMusicaEdi.Name = "txbMusicaEdi";
            this.txbMusicaEdi.Size = new System.Drawing.Size(217, 27);
            this.txbMusicaEdi.TabIndex = 2;
            // 
            // lblArtistaEdi
            // 
            this.lblArtistaEdi.AutoSize = true;
            this.lblArtistaEdi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistaEdi.Location = new System.Drawing.Point(21, 97);
            this.lblArtistaEdi.Name = "lblArtistaEdi";
            this.lblArtistaEdi.Size = new System.Drawing.Size(90, 23);
            this.lblArtistaEdi.TabIndex = 1;
            this.lblArtistaEdi.Text = "Artista(s)";
            // 
            // lblMusicaEdi
            // 
            this.lblMusicaEdi.AutoSize = true;
            this.lblMusicaEdi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicaEdi.Location = new System.Drawing.Point(21, 64);
            this.lblMusicaEdi.Name = "lblMusicaEdi";
            this.lblMusicaEdi.Size = new System.Drawing.Size(66, 23);
            this.lblMusicaEdi.TabIndex = 0;
            this.lblMusicaEdi.Text = "Nome";
            // 
            // GerenciamentoPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 663);
            this.Controls.Add(this.grbEditarMusicaPlaylist);
            this.Controls.Add(this.grbAddMusicaPlaylist);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.pibSair);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenciamentoPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.grbAddMusicaPlaylist.ResumeLayout(false);
            this.grbAddMusicaPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbEditarMusicaPlaylist.ResumeLayout(false);
            this.grbEditarMusicaPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbAddMusicaPlaylist;
        private System.Windows.Forms.Button btnRemoverMusicaPl;
        private System.Windows.Forms.ComboBox cmbArtista;
        private System.Windows.Forms.Button btnAddMusica;
        private System.Windows.Forms.TextBox txbNomeNovo;
        private System.Windows.Forms.Label lblAddArtista;
        private System.Windows.Forms.Label lblAddNome;
        private System.Windows.Forms.GroupBox grbEditarMusicaPlaylist;
        private System.Windows.Forms.ComboBox cmbArtistaEdi;
        private System.Windows.Forms.Button btnEditarMusica;
        private System.Windows.Forms.TextBox txbMusicaEdi;
        private System.Windows.Forms.Label lblArtistaEdi;
        private System.Windows.Forms.Label lblMusicaEdi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}