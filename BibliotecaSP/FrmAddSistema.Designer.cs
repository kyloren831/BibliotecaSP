namespace BibliotecaSP
{
    partial class FrmAddSistema
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
            btnConfirmar = new Button();
            button1 = new Button();
            txtID = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            lbEtiqueta = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            txtRuta = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(255, 255, 192);
            btnConfirmar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(276, 323);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(111, 38);
            btnConfirmar.TabIndex = 32;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(106, 323);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 31;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(162, 42);
            txtID.MaxLength = 10;
            txtID.Name = "txtID";
            txtID.Size = new Size(74, 23);
            txtID.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._20250619_0129_Bibliothèque_Universitaire_Ambiance_simple_compose_01jy3hbk8wfqmbpbwdqk7z0d4j;
            pictureBox2.Location = new Point(0, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(502, 371);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 46);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 28;
            label2.Text = "ID Sistema:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(lbEtiqueta);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 30);
            panel1.TabIndex = 27;
            // 
            // lbEtiqueta
            // 
            lbEtiqueta.AutoSize = true;
            lbEtiqueta.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEtiqueta.Location = new Point(12, 9);
            lbEtiqueta.Name = "lbEtiqueta";
            lbEtiqueta.Size = new Size(110, 12);
            lbEtiqueta.TabIndex = 48;
            lbEtiqueta.Text = "Agregar Sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold);
            label1.Location = new Point(473, 2);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtRuta);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtID);
            panel2.Location = new Point(106, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 204);
            panel2.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 147);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 33;
            label4.Text = "Ruta";
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(106, 143);
            txtRuta.MaxLength = 10;
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(130, 23);
            txtRuta.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 95);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 31;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 91);
            txtNombre.MaxLength = 10;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 32;
            // 
            // FrmAddSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 399);
            Controls.Add(panel2);
            Controls.Add(btnConfirmar);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddSistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfirmar;
        private Button button1;
        private TextBox txtID;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Label lbEtiqueta;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private TextBox txtRuta;
        private Label label3;
        private TextBox txtNombre;
    }
}