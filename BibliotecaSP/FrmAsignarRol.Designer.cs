namespace BibliotecaSP
{
    partial class FrmAsignarRol
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
            lbIdUsuario = new Label();
            comboIdPantalla = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btnConfirmar = new Button();
            btnCancelar_Click = new Button();
            lbIdRol = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 30);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(82, 12);
            label4.TabIndex = 46;
            label4.Text = "Asignar Rol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold);
            label1.Location = new Point(314, 2);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // lbIdUsuario
            // 
            lbIdUsuario.AutoSize = true;
            lbIdUsuario.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdUsuario.Location = new Point(75, 85);
            lbIdUsuario.Name = "lbIdUsuario";
            lbIdUsuario.Size = new Size(67, 13);
            lbIdUsuario.TabIndex = 45;
            lbIdUsuario.Text = "ID Usuario:";
            // 
            // comboIdPantalla
            // 
            comboIdPantalla.DropDownStyle = ComboBoxStyle.DropDownList;
            comboIdPantalla.FormattingEnabled = true;
            comboIdPantalla.Location = new Point(201, 75);
            comboIdPantalla.Name = "comboIdPantalla";
            comboIdPantalla.Size = new Size(114, 23);
            comboIdPantalla.TabIndex = 44;
            comboIdPantalla.SelectedIndexChanged += comboRoles_Changed;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 50);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 43;
            label3.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 42;
            label2.Text = "ID Usuario:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(255, 255, 192);
            btnConfirmar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(201, 142);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(111, 38);
            btnConfirmar.TabIndex = 47;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar_Click
            // 
            btnCancelar_Click.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar_Click.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar_Click.Location = new Point(12, 142);
            btnCancelar_Click.Name = "btnCancelar_Click";
            btnCancelar_Click.Size = new Size(111, 38);
            btnCancelar_Click.TabIndex = 46;
            btnCancelar_Click.Text = "Cancelar";
            btnCancelar_Click.UseVisualStyleBackColor = false;
            btnCancelar_Click.Click += btnCancelar_Click_Click;
            // 
            // lbIdRol
            // 
            lbIdRol.AutoSize = true;
            lbIdRol.Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdRol.Location = new Point(201, 101);
            lbIdRol.Name = "lbIdRol";
            lbIdRol.Size = new Size(34, 13);
            lbIdRol.TabIndex = 48;
            lbIdRol.Text = "idRol";
            // 
            // FrmAsignarRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 192);
            Controls.Add(lbIdRol);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar_Click);
            Controls.Add(lbIdUsuario);
            Controls.Add(comboIdPantalla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAsignarRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAsignarRol";
            Load += FrmAsignarRol_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label lbIdUsuario;
        private ComboBox comboIdPantalla;
        private Label label3;
        private Label label2;
        private Button btnConfirmar;
        private Button btnCancelar_Click;
        private Label lbIdRol;
    }
}