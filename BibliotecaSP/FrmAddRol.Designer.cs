namespace BibliotecaSP
{
    partial class FrmAddRol
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
            lbVentana = new Label();
            label1 = new Label();
            btnConfirmar = new Button();
            btnCancelar_Click = new Button();
            label3 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbVentana);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 30);
            panel1.TabIndex = 48;
            // 
            // lbVentana
            // 
            lbVentana.AutoSize = true;
            lbVentana.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVentana.Location = new Point(3, 8);
            lbVentana.Name = "lbVentana";
            lbVentana.Size = new Size(68, 12);
            lbVentana.TabIndex = 46;
            lbVentana.Text = "Crear Rol";
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
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(255, 255, 192);
            btnConfirmar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(200, 141);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(111, 38);
            btnConfirmar.TabIndex = 51;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar_Click
            // 
            btnCancelar_Click.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar_Click.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar_Click.Location = new Point(11, 141);
            btnCancelar_Click.Name = "btnCancelar_Click";
            btnCancelar_Click.Size = new Size(111, 38);
            btnCancelar_Click.TabIndex = 50;
            btnCancelar_Click.Text = "Cancelar";
            btnCancelar_Click.UseVisualStyleBackColor = false;
            btnCancelar_Click.Click += btnCancelar_Click_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 51);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 49;
            label3.Text = "ID Rol:";
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 52);
            txtId.MaxLength = 50;
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 52;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 95);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 95);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 53;
            label2.Text = "Nombre:";
            // 
            // FrmAddRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 192);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(panel1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar_Click);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddRol";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbVentana;
        private Label label1;
        private Button btnConfirmar;
        private Button btnCancelar_Click;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label2;
    }
}