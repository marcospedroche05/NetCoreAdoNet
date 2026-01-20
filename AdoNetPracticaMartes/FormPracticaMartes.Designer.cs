namespace AdoNetPracticaMartes
{
    partial class FormPracticaMartes
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
            cmbHospitales = new ComboBox();
            label2 = new Label();
            lstEmpleadosHospital = new ListBox();
            btnMostrarDatos = new Button();
            label3 = new Label();
            txtSumaSalarial = new TextBox();
            label4 = new Label();
            txtMediaSalarial = new TextBox();
            label5 = new Label();
            txtPersonas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(43, 66);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(150, 23);
            cmbHospitales.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 34);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados hospital";
            // 
            // lstEmpleadosHospital
            // 
            lstEmpleadosHospital.FormattingEnabled = true;
            lstEmpleadosHospital.Location = new Point(252, 66);
            lstEmpleadosHospital.Name = "lstEmpleadosHospital";
            lstEmpleadosHospital.Size = new Size(287, 349);
            lstEmpleadosHospital.TabIndex = 3;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(43, 119);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(150, 32);
            btnMostrarDatos.TabIndex = 4;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 208);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Suma salarial";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(43, 235);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(120, 23);
            txtSumaSalarial.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 280);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Media salarial";
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(43, 309);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(120, 23);
            txtMediaSalarial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 363);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(43, 393);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(120, 23);
            txtPersonas.TabIndex = 10;
            // 
            // FormPracticaMartes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(txtPersonas);
            Controls.Add(label5);
            Controls.Add(txtMediaSalarial);
            Controls.Add(label4);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label3);
            Controls.Add(btnMostrarDatos);
            Controls.Add(lstEmpleadosHospital);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "FormPracticaMartes";
            Text = "FormPracticaMartes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private ListBox lstEmpleadosHospital;
        private Button btnMostrarDatos;
        private Label label3;
        private TextBox txtSumaSalarial;
        private Label label4;
        private TextBox txtMediaSalarial;
        private Label label5;
        private TextBox txtPersonas;
    }
}