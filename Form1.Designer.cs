namespace gsalvanescki.CAI.Ej01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDocumento = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblFecha = new Label();
            tbDocumento = new TextBox();
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            tbFecha = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(72, 42);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 0;
            lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(72, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(72, 121);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(72, 160);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(119, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha de Nacimiento";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(219, 39);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(100, 23);
            tbDocumento.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(219, 79);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(219, 118);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(100, 23);
            tbApellido.TabIndex = 6;
            // 
            // tbFecha
            // 
            tbFecha.Location = new Point(219, 157);
            tbFecha.Name = "tbFecha";
            tbFecha.Size = new Size(100, 23);
            tbFecha.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(167, 216);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 251);
            Controls.Add(btnAceptar);
            Controls.Add(tbFecha);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Controls.Add(tbDocumento);
            Controls.Add(lblFecha);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDocumento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Ejercicio01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDocumento;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblFecha;
        private TextBox tbDocumento;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private TextBox tbFecha;
        private Button btnAceptar;
    }
}