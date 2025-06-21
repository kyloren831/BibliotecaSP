namespace BibliotecaSP
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCorreo = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 452);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20250619_1951_Fachada_Biblioteca_Pública_simple_compose_01jy5gg6e6fyrtwhkr97qn6tnb1;
            pictureBox1.Location = new Point(75, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bliblioteca SP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 150);
            label4.Name = "label4";
            label4.Size = new Size(131, 18);
            label4.TabIndex = 3;
            label4.Text = "Control de permisos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 115);
            label3.Name = "label3";
            label3.Size = new Size(135, 18);
            label3.TabIndex = 2;
            label3.Text = "Registro de Pantallas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 79);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 1;
            label2.Text = "Registro de Sistemas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 46);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(504, 96);
            label5.Name = "label5";
            label5.Size = new Size(163, 32);
            label5.TabIndex = 4;
            label5.Text = "Iniciar Sesion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(443, 153);
            label6.Name = "label6";
            label6.Size = new Size(54, 18);
            label6.TabIndex = 4;
            label6.Text = "Correo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(443, 232);
            label7.Name = "label7";
            label7.Size = new Size(81, 18);
            label7.TabIndex = 5;
            label7.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(447, 188);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(265, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(447, 268);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(265, 23);
            txtPass.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(744, 12);
            button1.Name = "button1";
            button1.Size = new Size(44, 35);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 255, 192);
            btnLogin.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(521, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 38);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Confirmar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCorreo;
        private TextBox txtPass;
        private Button button1;
        private Button btnLogin;
    }
}