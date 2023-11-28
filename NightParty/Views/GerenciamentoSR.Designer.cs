namespace NightParty.Views
{
    partial class GerenciamentoSR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoSR));
            this.dgvArtistas = new System.Windows.Forms.DataGridView();
            this.dgvMusicas = new System.Windows.Forms.DataGridView();
            this.grbAddMusica = new System.Windows.Forms.GroupBox();
            this.btnMusicaRmv = new System.Windows.Forms.Button();
            this.cmbArtistas = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMusicaAdd = new System.Windows.Forms.Button();
            this.txbMusicaAdd = new System.Windows.Forms.TextBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblNomeNovo = new System.Windows.Forms.Label();
            this.grbAddArtista = new System.Windows.Forms.GroupBox();
            this.btnArtistaRmv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnArtistaAdd = new System.Windows.Forms.Button();
            this.txbArtistaAdd = new System.Windows.Forms.TextBox();
            this.lblNovoArtista = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbArtistasEdi = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txbArtistaEdi = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txbMusicaEdi = new System.Windows.Forms.TextBox();
            this.lblArtistaEdi = new System.Windows.Forms.Label();
            this.lblMusicaEdi = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPlaylist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).BeginInit();
            this.grbAddMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbAddArtista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtistas
            // 
            this.dgvArtistas.AllowUserToAddRows = false;
            this.dgvArtistas.AllowUserToDeleteRows = false;
            this.dgvArtistas.AllowUserToResizeColumns = false;
            this.dgvArtistas.AllowUserToResizeRows = false;
            this.dgvArtistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtistas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArtistas.Location = new System.Drawing.Point(510, 62);
            this.dgvArtistas.Name = "dgvArtistas";
            this.dgvArtistas.Size = new System.Drawing.Size(277, 207);
            this.dgvArtistas.TabIndex = 6;
            this.dgvArtistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtistas_CellClick);
            // 
            // dgvMusicas
            // 
            this.dgvMusicas.AllowUserToAddRows = false;
            this.dgvMusicas.AllowUserToDeleteRows = false;
            this.dgvMusicas.AllowUserToResizeColumns = false;
            this.dgvMusicas.AllowUserToResizeRows = false;
            this.dgvMusicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusicas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMusicas.Location = new System.Drawing.Point(12, 62);
            this.dgvMusicas.Name = "dgvMusicas";
            this.dgvMusicas.Size = new System.Drawing.Size(475, 207);
            this.dgvMusicas.TabIndex = 5;
            this.dgvMusicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusicas_CellClick);
            // 
            // grbAddMusica
            // 
            this.grbAddMusica.BackColor = System.Drawing.Color.Transparent;
            this.grbAddMusica.Controls.Add(this.btnMusicaRmv);
            this.grbAddMusica.Controls.Add(this.cmbArtistas);
            this.grbAddMusica.Controls.Add(this.pictureBox2);
            this.grbAddMusica.Controls.Add(this.btnMusicaAdd);
            this.grbAddMusica.Controls.Add(this.txbMusicaAdd);
            this.grbAddMusica.Controls.Add(this.lblArtista);
            this.grbAddMusica.Controls.Add(this.lblNomeNovo);
            this.grbAddMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddMusica.ForeColor = System.Drawing.Color.White;
            this.grbAddMusica.Location = new System.Drawing.Point(12, 275);
            this.grbAddMusica.Name = "grbAddMusica";
            this.grbAddMusica.Size = new System.Drawing.Size(475, 214);
            this.grbAddMusica.TabIndex = 7;
            this.grbAddMusica.TabStop = false;
            this.grbAddMusica.Text = "Música";
            // 
            // btnMusicaRmv
            // 
            this.btnMusicaRmv.BackColor = System.Drawing.Color.IndianRed;
            this.btnMusicaRmv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusicaRmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicaRmv.ForeColor = System.Drawing.Color.Black;
            this.btnMusicaRmv.Location = new System.Drawing.Point(25, 170);
            this.btnMusicaRmv.Name = "btnMusicaRmv";
            this.btnMusicaRmv.Size = new System.Drawing.Size(403, 31);
            this.btnMusicaRmv.TabIndex = 19;
            this.btnMusicaRmv.Text = "Remover";
            this.btnMusicaRmv.UseVisualStyleBackColor = false;
            this.btnMusicaRmv.Click += new System.EventHandler(this.btnMusicaRmv_Click);
            // 
            // cmbArtistas
            // 
            this.cmbArtistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtistas.FormattingEnabled = true;
            this.cmbArtistas.Location = new System.Drawing.Point(114, 84);
            this.cmbArtistas.Name = "cmbArtistas";
            this.cmbArtistas.Size = new System.Drawing.Size(314, 28);
            this.cmbArtistas.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnMusicaAdd
            // 
            this.btnMusicaAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnMusicaAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusicaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicaAdd.ForeColor = System.Drawing.Color.Black;
            this.btnMusicaAdd.Location = new System.Drawing.Point(25, 133);
            this.btnMusicaAdd.Name = "btnMusicaAdd";
            this.btnMusicaAdd.Size = new System.Drawing.Size(403, 31);
            this.btnMusicaAdd.TabIndex = 6;
            this.btnMusicaAdd.Text = "Adicionar";
            this.btnMusicaAdd.UseVisualStyleBackColor = false;
            this.btnMusicaAdd.Click += new System.EventHandler(this.btnMusicaAdd_Click);
            // 
            // txbMusicaAdd
            // 
            this.txbMusicaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMusicaAdd.Location = new System.Drawing.Point(114, 51);
            this.txbMusicaAdd.Name = "txbMusicaAdd";
            this.txbMusicaAdd.Size = new System.Drawing.Size(314, 26);
            this.txbMusicaAdd.TabIndex = 2;
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.Location = new System.Drawing.Point(21, 84);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(91, 24);
            this.lblArtista.TabIndex = 1;
            this.lblArtista.Text = "Artista(s)";
            // 
            // lblNomeNovo
            // 
            this.lblNomeNovo.AutoSize = true;
            this.lblNomeNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeNovo.Location = new System.Drawing.Point(21, 51);
            this.lblNomeNovo.Name = "lblNomeNovo";
            this.lblNomeNovo.Size = new System.Drawing.Size(66, 24);
            this.lblNomeNovo.TabIndex = 0;
            this.lblNomeNovo.Text = "Nome";
            // 
            // grbAddArtista
            // 
            this.grbAddArtista.BackColor = System.Drawing.Color.Transparent;
            this.grbAddArtista.Controls.Add(this.btnArtistaRmv);
            this.grbAddArtista.Controls.Add(this.pictureBox1);
            this.grbAddArtista.Controls.Add(this.btnArtistaAdd);
            this.grbAddArtista.Controls.Add(this.txbArtistaAdd);
            this.grbAddArtista.Controls.Add(this.lblNovoArtista);
            this.grbAddArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddArtista.ForeColor = System.Drawing.Color.White;
            this.grbAddArtista.Location = new System.Drawing.Point(510, 275);
            this.grbAddArtista.Name = "grbAddArtista";
            this.grbAddArtista.Size = new System.Drawing.Size(277, 214);
            this.grbAddArtista.TabIndex = 19;
            this.grbAddArtista.TabStop = false;
            this.grbAddArtista.Text = "Artista";
            // 
            // btnArtistaRmv
            // 
            this.btnArtistaRmv.BackColor = System.Drawing.Color.IndianRed;
            this.btnArtistaRmv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtistaRmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtistaRmv.ForeColor = System.Drawing.Color.Black;
            this.btnArtistaRmv.Location = new System.Drawing.Point(10, 170);
            this.btnArtistaRmv.Name = "btnArtistaRmv";
            this.btnArtistaRmv.Size = new System.Drawing.Size(244, 31);
            this.btnArtistaRmv.TabIndex = 20;
            this.btnArtistaRmv.Text = "Remover";
            this.btnArtistaRmv.UseVisualStyleBackColor = false;
            this.btnArtistaRmv.Click += new System.EventHandler(this.btnArtistaRmv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnArtistaAdd
            // 
            this.btnArtistaAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnArtistaAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtistaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtistaAdd.ForeColor = System.Drawing.Color.Black;
            this.btnArtistaAdd.Location = new System.Drawing.Point(10, 133);
            this.btnArtistaAdd.Name = "btnArtistaAdd";
            this.btnArtistaAdd.Size = new System.Drawing.Size(244, 31);
            this.btnArtistaAdd.TabIndex = 6;
            this.btnArtistaAdd.Text = "Adicionar";
            this.btnArtistaAdd.UseVisualStyleBackColor = false;
            this.btnArtistaAdd.Click += new System.EventHandler(this.btnArtistaAdd_Click);
            // 
            // txbArtistaAdd
            // 
            this.txbArtistaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArtistaAdd.Location = new System.Drawing.Point(87, 69);
            this.txbArtistaAdd.Name = "txbArtistaAdd";
            this.txbArtistaAdd.Size = new System.Drawing.Size(155, 26);
            this.txbArtistaAdd.TabIndex = 2;
            // 
            // lblNovoArtista
            // 
            this.lblNovoArtista.AutoSize = true;
            this.lblNovoArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoArtista.Location = new System.Drawing.Point(6, 69);
            this.lblNovoArtista.Name = "lblNovoArtista";
            this.lblNovoArtista.Size = new System.Drawing.Size(66, 24);
            this.lblNovoArtista.TabIndex = 0;
            this.lblNovoArtista.Text = "Nome";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.Transparent;
            this.grbEditar.Controls.Add(this.cmbArtistasEdi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.pictureBox5);
            this.grbEditar.Controls.Add(this.txbArtistaEdi);
            this.grbEditar.Controls.Add(this.pictureBox3);
            this.grbEditar.Controls.Add(this.txbMusicaEdi);
            this.grbEditar.Controls.Add(this.lblArtistaEdi);
            this.grbEditar.Controls.Add(this.lblMusicaEdi);
            this.grbEditar.Controls.Add(this.pictureBox4);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.ForeColor = System.Drawing.Color.White;
            this.grbEditar.Location = new System.Drawing.Point(12, 517);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(550, 177);
            this.grbEditar.TabIndex = 20;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar Informações";
            // 
            // cmbArtistasEdi
            // 
            this.cmbArtistasEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtistasEdi.FormattingEnabled = true;
            this.cmbArtistasEdi.Location = new System.Drawing.Point(308, 51);
            this.cmbArtistasEdi.Name = "cmbArtistasEdi";
            this.cmbArtistasEdi.Size = new System.Drawing.Size(186, 28);
            this.cmbArtistasEdi.TabIndex = 20;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(50, 125);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(444, 31);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(308, 88);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // txbArtistaEdi
            // 
            this.txbArtistaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArtistaEdi.Location = new System.Drawing.Point(114, 88);
            this.txbArtistaEdi.Name = "txbArtistaEdi";
            this.txbArtistaEdi.Size = new System.Drawing.Size(185, 26);
            this.txbArtistaEdi.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(250, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // txbMusicaEdi
            // 
            this.txbMusicaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMusicaEdi.Location = new System.Drawing.Point(114, 51);
            this.txbMusicaEdi.Name = "txbMusicaEdi";
            this.txbMusicaEdi.Size = new System.Drawing.Size(185, 26);
            this.txbMusicaEdi.TabIndex = 2;
            // 
            // lblArtistaEdi
            // 
            this.lblArtistaEdi.AutoSize = true;
            this.lblArtistaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistaEdi.Location = new System.Drawing.Point(7, 84);
            this.lblArtistaEdi.Name = "lblArtistaEdi";
            this.lblArtistaEdi.Size = new System.Drawing.Size(91, 24);
            this.lblArtistaEdi.TabIndex = 1;
            this.lblArtistaEdi.Text = "Artista(s)";
            // 
            // lblMusicaEdi
            // 
            this.lblMusicaEdi.AutoSize = true;
            this.lblMusicaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicaEdi.Location = new System.Drawing.Point(21, 51);
            this.lblMusicaEdi.Name = "lblMusicaEdi";
            this.lblMusicaEdi.Size = new System.Drawing.Size(76, 24);
            this.lblMusicaEdi.TabIndex = 0;
            this.lblMusicaEdi.Text = "Música";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(500, 52);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pibSair
            // 
            this.pibSair.BackColor = System.Drawing.Color.Transparent;
            this.pibSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(774, 12);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(41, 40);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 21;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(262, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 39);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "     Song Request     ";
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Ivory;
            this.btnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.BackgroundImage")));
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.Black;
            this.btnPlaylist.Location = new System.Drawing.Point(597, 568);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(205, 81);
            this.btnPlaylist.TabIndex = 20;
            this.btnPlaylist.Text = "Playlist do dia";
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // GerenciamentoSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 714);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibSair);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbAddArtista);
            this.Controls.Add(this.grbAddMusica);
            this.Controls.Add(this.dgvArtistas);
            this.Controls.Add(this.dgvMusicas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenciamentoSR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SongRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).EndInit();
            this.grbAddMusica.ResumeLayout(false);
            this.grbAddMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbAddArtista.ResumeLayout(false);
            this.grbAddArtista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtistas;
        private System.Windows.Forms.DataGridView dgvMusicas;
        private System.Windows.Forms.GroupBox grbAddMusica;
        private System.Windows.Forms.Button btnMusicaRmv;
        private System.Windows.Forms.ComboBox cmbArtistas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMusicaAdd;
        private System.Windows.Forms.TextBox txbMusicaAdd;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblNomeNovo;
        private System.Windows.Forms.GroupBox grbAddArtista;
        private System.Windows.Forms.Button btnArtistaRmv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnArtistaAdd;
        private System.Windows.Forms.TextBox txbArtistaAdd;
        private System.Windows.Forms.Label lblNovoArtista;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txbArtistaEdi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txbMusicaEdi;
        private System.Windows.Forms.Label lblArtistaEdi;
        private System.Windows.Forms.Label lblMusicaEdi;
        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.ComboBox cmbArtistasEdi;
    }
}