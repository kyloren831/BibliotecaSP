namespace BibliotecaSP
{
    partial class FrmSistemas
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
            components = new System.ComponentModel.Container();
            txtFiltro = new TextBox();
            btnAddSistema = new Button();
            dataGridSistemas = new DataGridView();
            MenuSistemas = new ContextMenuStrip(components);
            EditarSistema = new ToolStripMenuItem();
            EliminarSistema = new ToolStripMenuItem();
            lbTitulo = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridPantallas = new DataGridView();
            MenuPantallas = new ContextMenuStrip(components);
            btnEditarPantalla = new ToolStripMenuItem();
            btnEliminarPantalla = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridSistemas).BeginInit();
            MenuSistemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPantallas).BeginInit();
            MenuPantallas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(12, 35);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(257, 23);
            txtFiltro.TabIndex = 21;
            txtFiltro.Text = "Buscar por Nombre o ID";
            // 
            // btnAddSistema
            // 
            btnAddSistema.BackColor = Color.FromArgb(255, 255, 192);
            btnAddSistema.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSistema.Image = Properties.Resources.mas;
            btnAddSistema.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSistema.Location = new Point(304, 29);
            btnAddSistema.Name = "btnAddSistema";
            btnAddSistema.Size = new Size(144, 33);
            btnAddSistema.TabIndex = 20;
            btnAddSistema.Text = "Agregar Sistema";
            btnAddSistema.TextAlign = ContentAlignment.MiddleRight;
            btnAddSistema.UseVisualStyleBackColor = false;
            btnAddSistema.Click += btnAddSistema_Click;
            // 
            // dataGridSistemas
            // 
            dataGridSistemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSistemas.ContextMenuStrip = MenuSistemas;
            dataGridSistemas.Location = new Point(12, 71);
            dataGridSistemas.Name = "dataGridSistemas";
            dataGridSistemas.Size = new Size(436, 172);
            dataGridSistemas.TabIndex = 19;
            dataGridSistemas.CellClick += dataGridSistemas_CellClick;
            dataGridSistemas.CellContentClick += dataGridSistemas_CellContentClick;
            // 
            // MenuSistemas
            // 
            MenuSistemas.Items.AddRange(new ToolStripItem[] { EditarSistema, EliminarSistema });
            MenuSistemas.Name = "MenuSistemas";
            MenuSistemas.Size = new Size(162, 48);
            // 
            // EditarSistema
            // 
            EditarSistema.Name = "EditarSistema";
            EditarSistema.Size = new Size(161, 22);
            EditarSistema.Text = "Editar Sistema";
            EditarSistema.Click += EditarSistema_Click;
            // 
            // EliminarSistema
            // 
            EliminarSistema.Name = "EliminarSistema";
            EliminarSistema.Size = new Size(161, 22);
            EliminarSistema.Text = "Eliminar Sistema";
            EliminarSistema.Click += EliminarSistema_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.Black;
            lbTitulo.Location = new Point(12, 8);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(257, 24);
            lbTitulo.TabIndex = 18;
            lbTitulo.Text = "Gestion de Sistemas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 26;
            textBox1.Text = "Buscar por Nombre o ID";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.mas;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(304, 268);
            button1.Name = "button1";
            button1.Size = new Size(144, 33);
            button1.TabIndex = 25;
            button1.Text = "Agregar Pantalla";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPantallas_Click;
            // 
            // dataGridPantallas
            // 
            dataGridPantallas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPantallas.ContextMenuStrip = MenuPantallas;
            dataGridPantallas.Location = new Point(12, 307);
            dataGridPantallas.Name = "dataGridPantallas";
            dataGridPantallas.Size = new Size(436, 172);
            dataGridPantallas.TabIndex = 24;
            // 
            // MenuPantallas
            // 
            MenuPantallas.Items.AddRange(new ToolStripItem[] { btnEditarPantalla, btnEliminarPantalla });
            MenuPantallas.Name = "MenuPantallas";
            MenuPantallas.Size = new Size(163, 48);
            // 
            // btnEditarPantalla
            // 
            btnEditarPantalla.Name = "btnEditarPantalla";
            btnEditarPantalla.Size = new Size(162, 22);
            btnEditarPantalla.Text = "Editar Pantalla";
            btnEditarPantalla.Click += btnEditarPantalla_Click;
            // 
            // btnEliminarPantalla
            // 
            btnEliminarPantalla.Name = "btnEliminarPantalla";
            btnEliminarPantalla.Size = new Size(162, 22);
            btnEliminarPantalla.Text = "Eliminar Pantalla";
            btnEliminarPantalla.Click += btnEliminarPantalla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 246);
            label1.Name = "label1";
            label1.Size = new Size(270, 24);
            label1.TabIndex = 23;
            label1.Text = "Gestion de Pantallas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20250619_1936_Bok_simple_compose_01jy5fnx3rfv9rgf209ay5hrb4;
            pictureBox1.Location = new Point(505, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // FrmSistemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(898, 473);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridPantallas);
            Controls.Add(label1);
            Controls.Add(txtFiltro);
            Controls.Add(btnAddSistema);
            Controls.Add(dataGridSistemas);
            Controls.Add(lbTitulo);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSistemas";
            Text = "FrmSistemas";
            Load += FrmSistemas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSistemas).EndInit();
            MenuSistemas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPantallas).EndInit();
            MenuPantallas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFiltro;
        private Button btnAddSistema;
        private DataGridView dataGridSistemas;
        private Label lbTitulo;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridPantallas;
        private Label label1;
        private PictureBox pictureBox1;
        private ContextMenuStrip MenuSistemas;
        private ToolStripMenuItem EditarSistema;
        private ToolStripMenuItem EliminarSistema;
        private ContextMenuStrip MenuPantallas;
        private ToolStripMenuItem btnEditarPantalla;
        private ToolStripMenuItem btnEliminarPantalla;
    }
}