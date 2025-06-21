namespace BibliotecaSP
{
    partial class FrmRoles
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
            dataGridRoles = new DataGridView();
            MenuRoles = new ContextMenuStrip(components);
            btnEditarRol = new ToolStripMenuItem();
            btnEliminarRol = new ToolStripMenuItem();
            btnAddUser = new Button();
            lbTitulo = new Label();
            panel1 = new Panel();
            dataGridPermisos = new DataGridView();
            MenuPermisos = new ContextMenuStrip(components);
            btnEditarPermisos = new ToolStripMenuItem();
            btnEliminarPermisos = new ToolStripMenuItem();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).BeginInit();
            MenuRoles.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPermisos).BeginInit();
            MenuPermisos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridRoles
            // 
            dataGridRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRoles.ContextMenuStrip = MenuRoles;
            dataGridRoles.Location = new Point(15, 77);
            dataGridRoles.Name = "dataGridRoles";
            dataGridRoles.Size = new Size(244, 139);
            dataGridRoles.TabIndex = 17;
            dataGridRoles.CellClick += dataGridRoles_CellClick;
            // 
            // MenuRoles
            // 
            MenuRoles.Items.AddRange(new ToolStripItem[] { btnEditarRol, btnEliminarRol });
            MenuRoles.Name = "MenuRoles";
            MenuRoles.Size = new Size(138, 48);
            // 
            // btnEditarRol
            // 
            btnEditarRol.Name = "btnEditarRol";
            btnEditarRol.Size = new Size(137, 22);
            btnEditarRol.Text = "Editar Rol";
            btnEditarRol.Click += btnEditarRol_Click;
            // 
            // btnEliminarRol
            // 
            btnEliminarRol.Name = "btnEliminarRol";
            btnEliminarRol.Size = new Size(137, 22);
            btnEliminarRol.Text = "Eliminar Rol";
            btnEliminarRol.Click += btnEliminarRol_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(255, 255, 192);
            btnAddUser.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.Image = Properties.Resources.mas;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(15, 38);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(114, 33);
            btnAddUser.TabIndex = 16;
            btnAddUser.Text = "Agregar Rol";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(15, 11);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(218, 24);
            lbTitulo.TabIndex = 15;
            lbTitulo.Text = "Gestion de Roles";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridRoles);
            panel1.Controls.Add(lbTitulo);
            panel1.Controls.Add(btnAddUser);
            panel1.Location = new Point(20, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 233);
            panel1.TabIndex = 18;
            // 
            // dataGridPermisos
            // 
            dataGridPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPermisos.ContextMenuStrip = MenuPermisos;
            dataGridPermisos.Location = new Point(14, 75);
            dataGridPermisos.Name = "dataGridPermisos";
            dataGridPermisos.Size = new Size(724, 139);
            dataGridPermisos.TabIndex = 19;
            // 
            // MenuPermisos
            // 
            MenuPermisos.Items.AddRange(new ToolStripItem[] { btnEditarPermisos, btnEliminarPermisos });
            MenuPermisos.Name = "MenuPermisos";
            MenuPermisos.Size = new Size(169, 48);
            // 
            // btnEditarPermisos
            // 
            btnEditarPermisos.Name = "btnEditarPermisos";
            btnEditarPermisos.Size = new Size(168, 22);
            btnEditarPermisos.Text = "Editar Permisos";
            btnEditarPermisos.Click += btnEditarPermisos_Click;
            // 
            // btnEliminarPermisos
            // 
            btnEliminarPermisos.Name = "btnEliminarPermisos";
            btnEliminarPermisos.Size = new Size(168, 22);
            btnEliminarPermisos.Text = "Eliminar Permisos";
            btnEliminarPermisos.Click += btnEliminarPermisos_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridPermisos);
            panel2.Location = new Point(20, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 234);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 18;
            label1.Text = "Permisos";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.mas;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(14, 36);
            button1.Name = "button1";
            button1.Size = new Size(140, 33);
            button1.TabIndex = 19;
            button1.Text = "AsignarPermiso";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20250619_1755_Hands_with_Vintage_Book_simple_compose_01jy59vh2fe74tmzr7xabst5q6;
            pictureBox1.Location = new Point(333, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(33, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(801, 494);
            panel3.TabIndex = 22;
            panel3.Paint += panel3_Paint;
            // 
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 509);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRoles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRoles";
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).EndInit();
            MenuRoles.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPermisos).EndInit();
            MenuPermisos.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridRoles;
        private Button btnAddUser;
        private Label lbTitulo;
        private Panel panel1;
        private DataGridView dataGridPermisos;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private ContextMenuStrip MenuRoles;
        private ToolStripMenuItem btnEditarRol;
        private ToolStripMenuItem btnEliminarRol;
        private ContextMenuStrip MenuPermisos;
        private ToolStripMenuItem btnEditarPermisos;
        private ToolStripMenuItem btnEliminarPermisos;
    }
}