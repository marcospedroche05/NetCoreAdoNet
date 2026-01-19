namespace NetCoreAdoNet
{
    partial class Form13ParametrosSalida
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
            cmbDepartamentos = new ComboBox();
            label2 = new Label();
            btnMostrar = new Button();
            label3 = new Label();
            txtSumasalarial = new TextBox();
            txtMediaSalarial = new TextBox();
            txtPersonas = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(40, 69);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(121, 23);
            cmbDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 41);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(40, 109);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(121, 45);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 180);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Suma salarial";
            // 
            // txtSumasalarial
            // 
            txtSumasalarial.Location = new Point(40, 208);
            txtSumasalarial.Name = "txtSumasalarial";
            txtSumasalarial.Size = new Size(121, 23);
            txtSumasalarial.TabIndex = 5;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(40, 282);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(121, 23);
            txtMediaSalarial.TabIndex = 6;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(40, 357);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(121, 23);
            txtPersonas.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 255);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 8;
            label4.Text = "Media salarial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 329);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Pesonas";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(223, 69);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(166, 304);
            lstEmpleados.TabIndex = 10;
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPersonas);
            Controls.Add(txtMediaSalarial);
            Controls.Add(txtSumasalarial);
            Controls.Add(label3);
            Controls.Add(btnMostrar);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label2;
        private Button btnMostrar;
        private Label label3;
        private TextBox txtSumasalarial;
        private TextBox txtMediaSalarial;
        private TextBox txtPersonas;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
    }
}