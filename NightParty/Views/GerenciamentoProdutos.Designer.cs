namespace NightParty.Views
{
    partial class GerenciamentoProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbAddProduto = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbPrecoAdd = new System.Windows.Forms.TextBox();
            this.lblAddPreco = new System.Windows.Forms.Label();
            this.pibP2 = new System.Windows.Forms.PictureBox();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.txbAddProduto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAddNome = new System.Windows.Forms.Label();
            this.grbEditarProduto = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txbPrecoEdi = new System.Windows.Forms.TextBox();
            this.lblPrecoEdi = new System.Windows.Forms.Label();
            this.cmbCategoriaEdi = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbProdutoEdi = new System.Windows.Forms.TextBox();
            this.lblCategoriaEdi = new System.Windows.Forms.Label();
            this.lblProdutoEdi = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCategoria = new System.Windows.Forms.GroupBox();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.txbAddCategoria = new System.Windows.Forms.TextBox();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.lblAddCategoria = new System.Windows.Forms.Label();
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbAddProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibP2)).BeginInit();
            this.grbEditarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Location = new System.Drawing.Point(151, 88);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(533, 269);
            this.dgvProdutos.TabIndex = 5;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbAddProduto
            // 
            this.grbAddProduto.BackColor = System.Drawing.Color.Transparent;
            this.grbAddProduto.Controls.Add(this.pictureBox1);
            this.grbAddProduto.Controls.Add(this.txbPrecoAdd);
            this.grbAddProduto.Controls.Add(this.lblAddPreco);
            this.grbAddProduto.Controls.Add(this.pibP2);
            this.grbAddProduto.Controls.Add(this.btnRemoverProduto);
            this.grbAddProduto.Controls.Add(this.cmbCategoria);
            this.grbAddProduto.Controls.Add(this.btnAddProduto);
            this.grbAddProduto.Controls.Add(this.txbAddProduto);
            this.grbAddProduto.Controls.Add(this.lblCategoria);
            this.grbAddProduto.Controls.Add(this.lblAddNome);
            this.grbAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddProduto.ForeColor = System.Drawing.Color.White;
            this.grbAddProduto.Location = new System.Drawing.Point(75, 363);
            this.grbAddProduto.Name = "grbAddProduto";
            this.grbAddProduto.Size = new System.Drawing.Size(394, 238);
            this.grbAddProduto.TabIndex = 26;
            this.grbAddProduto.TabStop = false;
            this.grbAddProduto.Text = "Adicionar / Remover";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txbPrecoAdd
            // 
            this.txbPrecoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoAdd.Location = new System.Drawing.Point(149, 116);
            this.txbPrecoAdd.Name = "txbPrecoAdd";
            this.txbPrecoAdd.Size = new System.Drawing.Size(144, 26);
            this.txbPrecoAdd.TabIndex = 21;
            // 
            // lblAddPreco
            // 
            this.lblAddPreco.AutoSize = true;
            this.lblAddPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPreco.Location = new System.Drawing.Point(21, 116);
            this.lblAddPreco.Name = "lblAddPreco";
            this.lblAddPreco.Size = new System.Drawing.Size(65, 24);
            this.lblAddPreco.TabIndex = 20;
            this.lblAddPreco.Text = "Preço";
            // 
            // pibP2
            // 
            this.pibP2.BackColor = System.Drawing.Color.Transparent;
            this.pibP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibP2.Image = ((System.Drawing.Image)(resources.GetObject("pibP2.Image")));
            this.pibP2.Location = new System.Drawing.Point(295, 0);
            this.pibP2.Name = "pibP2";
            this.pibP2.Size = new System.Drawing.Size(34, 29);
            this.pibP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibP2.TabIndex = 22;
            this.pibP2.TabStop = false;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoverProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverProduto.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverProduto.Location = new System.Drawing.Point(25, 197);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(341, 31);
            this.btnRemoverProduto.TabIndex = 19;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = false;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(149, 84);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(217, 28);
            this.cmbCategoria.TabIndex = 18;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduto.Location = new System.Drawing.Point(25, 160);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(341, 31);
            this.btnAddProduto.TabIndex = 6;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // txbAddProduto
            // 
            this.txbAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddProduto.Location = new System.Drawing.Point(149, 51);
            this.txbAddProduto.Name = "txbAddProduto";
            this.txbAddProduto.Size = new System.Drawing.Size(217, 26);
            this.txbAddProduto.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(21, 84);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(99, 24);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblAddNome
            // 
            this.lblAddNome.AutoSize = true;
            this.lblAddNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNome.Location = new System.Drawing.Point(21, 51);
            this.lblAddNome.Name = "lblAddNome";
            this.lblAddNome.Size = new System.Drawing.Size(66, 24);
            this.lblAddNome.TabIndex = 0;
            this.lblAddNome.Text = "Nome";
            // 
            // grbEditarProduto
            // 
            this.grbEditarProduto.BackColor = System.Drawing.Color.Transparent;
            this.grbEditarProduto.Controls.Add(this.pictureBox3);
            this.grbEditarProduto.Controls.Add(this.txbPrecoEdi);
            this.grbEditarProduto.Controls.Add(this.lblPrecoEdi);
            this.grbEditarProduto.Controls.Add(this.cmbCategoriaEdi);
            this.grbEditarProduto.Controls.Add(this.btnEditar);
            this.grbEditarProduto.Controls.Add(this.txbProdutoEdi);
            this.grbEditarProduto.Controls.Add(this.lblCategoriaEdi);
            this.grbEditarProduto.Controls.Add(this.lblProdutoEdi);
            this.grbEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditarProduto.ForeColor = System.Drawing.Color.White;
            this.grbEditarProduto.Location = new System.Drawing.Point(561, 363);
            this.grbEditarProduto.Name = "grbEditarProduto";
            this.grbEditarProduto.Size = new System.Drawing.Size(394, 201);
            this.grbEditarProduto.TabIndex = 27;
            this.grbEditarProduto.TabStop = false;
            this.grbEditarProduto.Text = "Editar";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(108, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // txbPrecoEdi
            // 
            this.txbPrecoEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoEdi.Location = new System.Drawing.Point(149, 116);
            this.txbPrecoEdi.Name = "txbPrecoEdi";
            this.txbPrecoEdi.Size = new System.Drawing.Size(144, 26);
            this.txbPrecoEdi.TabIndex = 21;
            // 
            // lblPrecoEdi
            // 
            this.lblPrecoEdi.AutoSize = true;
            this.lblPrecoEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEdi.Location = new System.Drawing.Point(24, 116);
            this.lblPrecoEdi.Name = "lblPrecoEdi";
            this.lblPrecoEdi.Size = new System.Drawing.Size(65, 24);
            this.lblPrecoEdi.TabIndex = 20;
            this.lblPrecoEdi.Text = "Preço";
            // 
            // cmbCategoriaEdi
            // 
            this.cmbCategoriaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaEdi.FormattingEnabled = true;
            this.cmbCategoriaEdi.Location = new System.Drawing.Point(149, 84);
            this.cmbCategoriaEdi.Name = "cmbCategoriaEdi";
            this.cmbCategoriaEdi.Size = new System.Drawing.Size(217, 28);
            this.cmbCategoriaEdi.TabIndex = 18;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(28, 160);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(341, 31);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbProdutoEdi
            // 
            this.txbProdutoEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutoEdi.Location = new System.Drawing.Point(149, 51);
            this.txbProdutoEdi.Name = "txbProdutoEdi";
            this.txbProdutoEdi.Size = new System.Drawing.Size(217, 26);
            this.txbProdutoEdi.TabIndex = 2;
            // 
            // lblCategoriaEdi
            // 
            this.lblCategoriaEdi.AutoSize = true;
            this.lblCategoriaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEdi.Location = new System.Drawing.Point(21, 84);
            this.lblCategoriaEdi.Name = "lblCategoriaEdi";
            this.lblCategoriaEdi.Size = new System.Drawing.Size(99, 24);
            this.lblCategoriaEdi.TabIndex = 1;
            this.lblCategoriaEdi.Text = "Categoria";
            // 
            // lblProdutoEdi
            // 
            this.lblProdutoEdi.AutoSize = true;
            this.lblProdutoEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoEdi.Location = new System.Drawing.Point(21, 51);
            this.lblProdutoEdi.Name = "lblProdutoEdi";
            this.lblProdutoEdi.Size = new System.Drawing.Size(66, 24);
            this.lblProdutoEdi.TabIndex = 0;
            this.lblProdutoEdi.Text = "Nome";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(404, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 39);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "     Produtos     ";
            // 
            // grbCategoria
            // 
            this.grbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.grbCategoria.Controls.Add(this.btnEditarCategoria);
            this.grbCategoria.Controls.Add(this.btnRemoverCategoria);
            this.grbCategoria.Controls.Add(this.txbAddCategoria);
            this.grbCategoria.Controls.Add(this.btnAddCategoria);
            this.grbCategoria.Controls.Add(this.lblAddCategoria);
            this.grbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCategoria.ForeColor = System.Drawing.Color.White;
            this.grbCategoria.Location = new System.Drawing.Point(75, 607);
            this.grbCategoria.Name = "grbCategoria";
            this.grbCategoria.Size = new System.Drawing.Size(880, 147);
            this.grbCategoria.TabIndex = 27;
            this.grbCategoria.TabStop = false;
            this.grbCategoria.Text = "Categorias";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnEditarCategoria.Location = new System.Drawing.Point(463, 100);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(341, 31);
            this.btnEditarCategoria.TabIndex = 29;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoverCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverCategoria.Location = new System.Drawing.Point(463, 63);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(341, 31);
            this.btnRemoverCategoria.TabIndex = 25;
            this.btnRemoverCategoria.Text = "Remover";
            this.btnRemoverCategoria.UseVisualStyleBackColor = false;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // txbAddCategoria
            // 
            this.txbAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddCategoria.Location = new System.Drawing.Point(93, 63);
            this.txbAddCategoria.Name = "txbAddCategoria";
            this.txbAddCategoria.Size = new System.Drawing.Size(273, 26);
            this.txbAddCategoria.TabIndex = 24;
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAddCategoria.Location = new System.Drawing.Point(463, 26);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(341, 31);
            this.btnAddCategoria.TabIndex = 24;
            this.btnAddCategoria.Text = "Adicionar";
            this.btnAddCategoria.UseVisualStyleBackColor = false;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // lblAddCategoria
            // 
            this.lblAddCategoria.AutoSize = true;
            this.lblAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategoria.Location = new System.Drawing.Point(21, 63);
            this.lblAddCategoria.Name = "lblAddCategoria";
            this.lblAddCategoria.Size = new System.Drawing.Size(66, 24);
            this.lblAddCategoria.TabIndex = 0;
            this.lblAddCategoria.Text = "Nome";
            // 
            // pibSair
            // 
            this.pibSair.BackColor = System.Drawing.Color.Transparent;
            this.pibSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(967, 24);
            this.pibSair.Margin = new System.Windows.Forms.Padding(4);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(39, 42);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 29;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategorias.Location = new System.Drawing.Point(690, 88);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(219, 269);
            this.dgvCategorias.TabIndex = 30;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 766);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.pibSair);
            this.Controls.Add(this.grbCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbEditarProduto);
            this.Controls.Add(this.grbAddProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenciamentoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbAddProduto.ResumeLayout(false);
            this.grbAddProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibP2)).EndInit();
            this.grbEditarProduto.ResumeLayout(false);
            this.grbEditarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grbCategoria.ResumeLayout(false);
            this.grbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbAddProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.TextBox txbAddProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAddNome;
        private System.Windows.Forms.TextBox txbPrecoAdd;
        private System.Windows.Forms.Label lblAddPreco;
        private System.Windows.Forms.GroupBox grbEditarProduto;
        private System.Windows.Forms.TextBox txbPrecoEdi;
        private System.Windows.Forms.Label lblPrecoEdi;
        private System.Windows.Forms.ComboBox cmbCategoriaEdi;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbProdutoEdi;
        private System.Windows.Forms.Label lblCategoriaEdi;
        private System.Windows.Forms.Label lblProdutoEdi;
        private System.Windows.Forms.PictureBox pibP2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnRemoverCategoria;
        private System.Windows.Forms.TextBox txbAddCategoria;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.Label lblAddCategoria;
        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}