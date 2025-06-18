namespace BibliotecaSP
{
    partial class FrmPermisoUsuario
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
            btnConfirmar = new Button();
            button1 = new Button();
            lbTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            comboIdPantalla = new ComboBox();
            comboIdUsuario = new ComboBox();
            lbInsertar = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            checkConsultar = new CheckBox();
            checkBorrar = new CheckBox();
            checkModificar = new CheckBox();
            checkInsertar = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 30);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold);
            label1.Location = new Point(486, 2);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(255, 255, 192);
            btnConfirmar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(277, 337);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(111, 38);
            btnConfirmar.TabIndex = 28;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(107, 337);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 27;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(136, 53);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(218, 24);
            lbTitulo.TabIndex = 29;
            lbTitulo.Text = "Agregar Permisos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 30;
            label2.Text = "ID Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(242, 118);
            label3.Name = "label3";
            label3.Size = new Size(141, 19);
            label3.TabIndex = 32;
            label3.Text = "ID Pantalla:";
            // 
            // comboIdPantalla
            // 
            comboIdPantalla.DropDownStyle = ComboBoxStyle.DropDownList;
            comboIdPantalla.FormattingEnabled = true;
            comboIdPantalla.Location = new Point(389, 114);
            comboIdPantalla.Name = "comboIdPantalla";
            comboIdPantalla.Size = new Size(74, 23);
            comboIdPantalla.TabIndex = 33;
            // 
            // comboIdUsuario
            // 
            comboIdUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboIdUsuario.FormattingEnabled = true;
            comboIdUsuario.Location = new Point(144, 114);
            comboIdUsuario.Name = "comboIdUsuario";
            comboIdUsuario.Size = new Size(74, 23);
            comboIdUsuario.TabIndex = 34;
            // 
            // lbInsertar
            // 
            lbInsertar.AutoSize = true;
            lbInsertar.Font = new Font("SimSun", 12F, FontStyle.Bold);
            lbInsertar.Location = new Point(22, 11);
            lbInsertar.Name = "lbInsertar";
            lbInsertar.Size = new Size(79, 16);
            lbInsertar.TabIndex = 35;
            lbInsertar.Text = "Insertar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 46);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 36;
            label4.Text = "Modificar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label5.Location = new Point(22, 79);
            label5.Name = "label5";
            label5.Size = new Size(106, 16);
            label5.TabIndex = 37;
            label5.Text = "Borrar     ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label6.Location = new Point(22, 112);
            label6.Name = "label6";
            label6.Size = new Size(88, 16);
            label6.TabIndex = 38;
            label6.Text = "Consultar";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(checkConsultar);
            panel2.Controls.Add(checkBorrar);
            panel2.Controls.Add(checkModificar);
            panel2.Controls.Add(checkInsertar);
            panel2.Controls.Add(lbInsertar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(101, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 144);
            panel2.TabIndex = 39;
            // 
            // checkConsultar
            // 
            checkConsultar.AutoSize = true;
            checkConsultar.Location = new Point(174, 109);
            checkConsultar.Name = "checkConsultar";
            checkConsultar.Size = new Size(83, 19);
            checkConsultar.TabIndex = 42;
            checkConsultar.Text = "checkBox4";
            checkConsultar.UseVisualStyleBackColor = true;
            // 
            // checkBorrar
            // 
            checkBorrar.AutoSize = true;
            checkBorrar.Location = new Point(174, 76);
            checkBorrar.Name = "checkBorrar";
            checkBorrar.Size = new Size(83, 19);
            checkBorrar.TabIndex = 41;
            checkBorrar.Text = "checkBox3";
            checkBorrar.UseVisualStyleBackColor = true;
            // 
            // checkModificar
            // 
            checkModificar.AutoSize = true;
            checkModificar.Location = new Point(174, 43);
            checkModificar.Name = "checkModificar";
            checkModificar.Size = new Size(83, 19);
            checkModificar.TabIndex = 40;
            checkModificar.Text = "checkBox2";
            checkModificar.UseVisualStyleBackColor = true;
            // 
            // checkInsertar
            // 
            checkInsertar.AutoSize = true;
            checkInsertar.Location = new Point(174, 12);
            checkInsertar.Name = "checkInsertar";
            checkInsertar.Size = new Size(83, 19);
            checkInsertar.TabIndex = 39;
            checkInsertar.Text = "checkBox1";
            checkInsertar.UseVisualStyleBackColor = true;
            // 
            // FrmPermisoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 404);
            Controls.Add(panel2);
            Controls.Add(comboIdUsuario);
            Controls.Add(comboIdPantalla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbTitulo);
            Controls.Add(btnConfirmar);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPermisoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPermisoUsuario";
            Load += FrmPermisoUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnConfirmar;
        private Button button1;
        private Label lbTitulo;
        private Label label2;
        private Label label3;
        private ComboBox comboIdPantalla;
        private ComboBox comboIdUsuario;
        private Label lbInsertar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private CheckBox checkConsultar;
        private CheckBox checkBorrar;
        private CheckBox checkModificar;
        private CheckBox checkInsertar;
    }
}