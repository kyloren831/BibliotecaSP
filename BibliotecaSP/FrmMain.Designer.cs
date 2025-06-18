namespace BibliotecaSP
{
    partial class FrmMain
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panelContenido = new Panel();
            btnRoles = new Label();
            btnPantallas = new Label();
            btnSistemas = new Label();
            btnUsuarios = new Label();
            pictureBox1 = new PictureBox();
            panelContenido1 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 30);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold);
            label1.Location = new Point(986, 2);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(panelContenido);
            panel2.Controls.Add(btnRoles);
            panel2.Controls.Add(btnPantallas);
            panel2.Controls.Add(btnSistemas);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 486);
            panel2.TabIndex = 1;
            // 
            // panelContenido
            // 
            panelContenido.Location = new Point(181, 7);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(631, 438);
            panelContenido.TabIndex = 2;
            // 
            // btnRoles
            // 
            btnRoles.AutoSize = true;
            btnRoles.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoles.Image = Properties.Resources.equipo;
            btnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoles.Location = new Point(12, 206);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(157, 19);
            btnRoles.TabIndex = 15;
            btnRoles.Text = "   Roles           ";
            btnRoles.MouseEnter += btnRoles_Enter;
            btnRoles.MouseLeave += btnRoles_Leave;
            // 
            // btnPantallas
            // 
            btnPantallas.AutoSize = true;
            btnPantallas.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPantallas.Image = Properties.Resources.sistemas;
            btnPantallas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPantallas.Location = new Point(10, 178);
            btnPantallas.Name = "btnPantallas";
            btnPantallas.Size = new Size(161, 19);
            btnPantallas.TabIndex = 14;
            btnPantallas.Text = "   Pantallas       ";
            btnPantallas.MouseEnter += btnPantallas_Enter;
            btnPantallas.MouseLeave += btnPantallas_Leave;
            // 
            // btnSistemas
            // 
            btnSistemas.AutoSize = true;
            btnSistemas.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSistemas.Image = Properties.Resources.enterprise;
            btnSistemas.ImageAlign = ContentAlignment.MiddleLeft;
            btnSistemas.Location = new Point(10, 149);
            btnSistemas.Name = "btnSistemas";
            btnSistemas.Size = new Size(160, 19);
            btnSistemas.TabIndex = 13;
            btnSistemas.Text = "   Sistemas       ";
            btnSistemas.MouseEnter += btnSistemas_Enter;
            btnSistemas.MouseLeave += btnSistemas_Leave;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.Image = Properties.Resources.agregar_usuario;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(10, 121);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(157, 19);
            btnUsuarios.TabIndex = 12;
            btnUsuarios.Text = "   Usuarios       ";
            btnUsuarios.Click += btnUsuarios_Click;
            btnUsuarios.MouseEnter += btnUsuarios_Enter;
            btnUsuarios.MouseLeave += btnUsuarios_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.biblioteca_publica;
            pictureBox1.Location = new Point(48, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panelContenido1
            // 
            panelContenido1.BackColor = SystemColors.AppWorkspace;
            panelContenido1.Location = new Point(199, 52);
            panelContenido1.Name = "panelContenido1";
            panelContenido1.Size = new Size(805, 448);
            panelContenido1.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 516);
            Controls.Add(panelContenido1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label btnUsuarios;
        private Label btnRoles;
        private Label btnPantallas;
        private Label btnSistemas;
        private Panel panelContenido;
        private Panel panelContenido1;
    }
}