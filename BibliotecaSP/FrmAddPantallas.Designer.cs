namespace BibliotecaSP
{
    partial class FrmAddPantallas
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
            panel2 = new Panel();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lbVentana = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtID);
            panel2.Location = new Point(63, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 107);
            panel2.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 70);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 31;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 66);
            txtNombre.MaxLength = 10;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 23);
            txtNombre.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 21);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 28;
            label2.Text = "ID Pantalla:";
            // 
            // txtID
            // 
            txtID.Location = new Point(178, 17);
            txtID.MaxLength = 10;
            txtID.Name = "txtID";
            txtID.Size = new Size(74, 23);
            txtID.TabIndex = 30;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(239, 231);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 37;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnConfirmar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 231);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 36;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._20250619_1953_Bibliotecario_en_Computadora_simple_compose_01jy5gjgche41b3eraw4fd23g31;
            pictureBox2.Location = new Point(0, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(433, 311);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(lbVentana);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 30);
            panel1.TabIndex = 34;
            // 
            // lbVentana
            // 
            lbVentana.AutoSize = true;
            lbVentana.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVentana.Location = new Point(12, 9);
            lbVentana.Name = "lbVentana";
            lbVentana.Size = new Size(110, 12);
            lbVentana.TabIndex = 48;
            lbVentana.Text = "Agregar Sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold);
            label1.Location = new Point(405, 2);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // FrmAddPantallas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 330);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddPantallas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddPantallas";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtID;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lbVentana;
        private Label label1;
    }
}