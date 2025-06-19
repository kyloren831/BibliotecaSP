namespace BibliotecaSP
{
    partial class FrmUsuarios
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
            lbTitulo = new Label();
            dataGridUsuarios = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            btnAddUser = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridPermisos = new DataGridView();
            dataGridRoles = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txtFiltro = new TextBox();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPermisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(0, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(257, 24);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Gestion de Usuarios";
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.ContextMenuStrip = contextMenuStrip1;
            dataGridUsuarios.Location = new Point(0, 85);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.Size = new Size(635, 172);
            dataGridUsuarios.TabIndex = 1;
            dataGridUsuarios.CellClick += girUsrs_CellClick;
            dataGridUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            contextMenuStrip1.Text = "Editar";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AccessibleName = "btnEditarUsuario";
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(117, 22);
            toolStripMenuItem1.Text = "Editar";
            toolStripMenuItem1.Click += btnEditar_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.AccessibleName = "btnEliminarUsuario";
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(117, 22);
            toolStripMenuItem2.Text = "Eliminar";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(255, 255, 192);
            btnAddUser.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.Image = Properties.Resources.mas;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(491, 46);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(144, 33);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Agregar Usuario";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 269);
            label1.Name = "label1";
            label1.Size = new Size(196, 19);
            label1.TabIndex = 11;
            label1.Text = "Permisos Directos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(678, 52);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 12;
            label2.Text = "Roles";
            // 
            // dataGridPermisos
            // 
            dataGridPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPermisos.Location = new Point(0, 302);
            dataGridPermisos.Name = "dataGridPermisos";
            dataGridPermisos.Size = new Size(635, 150);
            dataGridPermisos.TabIndex = 13;
            // 
            // dataGridRoles
            // 
            dataGridRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRoles.Location = new Point(679, 85);
            dataGridRoles.Name = "dataGridRoles";
            dataGridRoles.Size = new Size(227, 367);
            dataGridRoles.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.mas;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(748, 46);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.mas;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(202, 263);
            button2.Name = "button2";
            button2.Size = new Size(33, 34);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(0, 51);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(257, 23);
            txtFiltro.TabIndex = 17;
            txtFiltro.Text = "Buscar por correo o por nombre";
            txtFiltro.Click += btnFiltro_Click;
            txtFiltro.TextChanged += textBox1_TextChanged;
            txtFiltro.Leave += btnFiltrar_Leave;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(906, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(txtFiltro);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridRoles);
            Controls.Add(dataGridPermisos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddUser);
            Controls.Add(dataGridUsuarios);
            Controls.Add(lbTitulo);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPermisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private DataGridView dataGridUsuarios;
        private Button btnAddUser;
        private Label label1;
        private Label label2;
        private DataGridView dataGridPermisos;
        private DataGridView dataGridRoles;
        private Button button1;
        private Button button2;
        private TextBox txtFiltro;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}