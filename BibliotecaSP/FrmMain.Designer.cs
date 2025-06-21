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
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panelContenido = new Panel();
            btnRoles = new Label();
            btnSistemas = new Label();
            btnUsuarios = new Label();
            pictureBox1 = new PictureBox();
            panelContenido1 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenido1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 30);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 9);
            label4.Name = "label4";
            label4.Size = new Size(166, 12);
            label4.TabIndex = 48;
            label4.Text = "Seguridad Biblioteca SP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold);
            label1.Location = new Point(1084, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panelContenido);
            panel2.Controls.Add(btnRoles);
            panel2.Controls.Add(btnSistemas);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(10, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 503);
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
            btnRoles.Location = new Point(10, 197);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(157, 19);
            btnRoles.TabIndex = 15;
            btnRoles.Text = "   Roles           ";
            btnRoles.Click += btnRoles_Click;
            btnRoles.MouseEnter += btnRoles_Enter;
            btnRoles.MouseLeave += btnRoles_Leave;
            // 
            // btnSistemas
            // 
            btnSistemas.AutoSize = true;
            btnSistemas.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSistemas.Image = Properties.Resources.enterprise;
            btnSistemas.ImageAlign = ContentAlignment.MiddleLeft;
            btnSistemas.Location = new Point(11, 168);
            btnSistemas.Name = "btnSistemas";
            btnSistemas.Size = new Size(160, 19);
            btnSistemas.TabIndex = 13;
            btnSistemas.Text = "   Sistemas       ";
            btnSistemas.Click += btnSistemas_Click;
            btnSistemas.MouseEnter += btnSistemas_Enter;
            btnSistemas.MouseLeave += btnSistemas_Leave;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.Image = Properties.Resources.agregar_usuario;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(11, 140);
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
            pictureBox1.Image = Properties.Resources._20250619_1951_Fachada_Biblioteca_Pública_simple_compose_01jy5gg6e6fyrtwhkr97qn6tnb;
            pictureBox1.Location = new Point(21, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panelContenido1
            // 
            panelContenido1.BackColor = SystemColors.Control;
            panelContenido1.Controls.Add(pictureBox2);
            panelContenido1.Location = new Point(197, 43);
            panelContenido1.Name = "panelContenido1";
            panelContenido1.Size = new Size(903, 499);
            panelContenido1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panelContenido1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1114, 555);
            panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._20250621_0129_Chica_y_Reloj_Mental_simple_compose_01jy8p6pazfcash0r01ym9f5z0;
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(900, 493);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1114, 556);
            Controls.Add(panel3);
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
            panelContenido1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label btnUsuarios;
        private Label btnRoles;
        private Label btnSistemas;
        private Panel panelContenido;
        private Panel panelContenido1;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox2;
    }
}