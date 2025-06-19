namespace BibliotecaSP
{
    partial class FrmAddUsuarios
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
            label1 = new Label();
            panel1 = new Panel();
            lbTitulo = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panelContenido = new Panel();
            btnRoles = new Label();
            btnPantallas = new Label();
            btnSistemas = new Label();
            btnUsuarios = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtID = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboActivo = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold);
            label1.Location = new Point(1083, 2);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 30);
            panel1.TabIndex = 1;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(217, 137);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(205, 24);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "Agregar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 206);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 12;
            label2.Text = "ID Usuario:";
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
            panel2.Location = new Point(481, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 13;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._20250617_2318_Gestión_de_Usuarios_Biblioteca_simple_compose_01jy0qfy15fwxseab79v400gv2;
            pictureBox2.Location = new Point(613, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(501, 484);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(217, 202);
            txtID.MaxLength = 10;
            txtID.Name = "txtID";
            txtID.Size = new Size(74, 23);
            txtID.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 242);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 16;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(217, 238);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(281, 23);
            txtNombre.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 285);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 18;
            label4.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(217, 281);
            txtCorreo.MaxLength = 50;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(281, 23);
            txtCorreo.TabIndex = 19;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(217, 322);
            txtClave.MaxLength = 10;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(281, 23);
            txtClave.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 326);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 20;
            label5.Text = "Clave:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(332, 206);
            label6.Name = "label6";
            label6.Size = new Size(86, 19);
            label6.TabIndex = 22;
            label6.Text = "Activo:";
            // 
            // comboActivo
            // 
            comboActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboActivo.FormattingEnabled = true;
            comboActivo.Items.AddRange(new object[] { "Si", "No" });
            comboActivo.Location = new Point(424, 202);
            comboActivo.Name = "comboActivo";
            comboActivo.Size = new Size(74, 23);
            comboActivo.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(217, 361);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 25;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(387, 361);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 26;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FrmAddUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 517);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboActivo);
            Controls.Add(label6);
            Controls.Add(txtClave);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(lbTitulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lbTitulo;
        private Label label2;
        private Panel panel2;
        private Panel panelContenido;
        private Label btnRoles;
        private Label btnPantallas;
        private Label btnSistemas;
        private Label btnUsuarios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtID;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Label label5;
        private Label label6;
        private ComboBox comboActivo;
        private Button button1;
        private Button button2;
    }
}