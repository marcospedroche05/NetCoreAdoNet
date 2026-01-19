namespace NetCoreAdoNet
{
    partial class Form12MensajeServidor
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
            txtId = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            btnNuevoDept = new Button();
            label4 = new Label();
            lblServidor = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(39, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 117);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(39, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 206);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(39, 245);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 5;
            // 
            // btnNuevoDept
            // 
            btnNuevoDept.Location = new Point(39, 294);
            btnNuevoDept.Name = "btnNuevoDept";
            btnNuevoDept.Size = new Size(100, 40);
            btnNuevoDept.TabIndex = 6;
            btnNuevoDept.Text = "Nuevo departamento";
            btnNuevoDept.UseVisualStyleBackColor = true;
            btnNuevoDept.Click += btnNuevoDept_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 36);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Departamentos";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.ForeColor = Color.Blue;
            lblServidor.Location = new Point(39, 389);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(63, 15);
            lblServidor.TabIndex = 8;
            lblServidor.Text = "lblServidor";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(242, 72);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(372, 304);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form12MensajeServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(lstDepartamentos);
            Controls.Add(lblServidor);
            Controls.Add(label4);
            Controls.Add(btnNuevoDept);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form12MensajeServidor";
            Text = "Form12MensajeServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Button btnNuevoDept;
        private Label label4;
        private Label lblServidor;
        private ListBox lstDepartamentos;
    }
}