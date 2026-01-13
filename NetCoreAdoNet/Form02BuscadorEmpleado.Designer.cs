namespace NetCoreAdoNet
{
    partial class Form02BuscadorEmpleado
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
            txtSalario = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            lstEmpleado = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 38);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(56, 56);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(230, 23);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(56, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(230, 39);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar empleados";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 157);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleado
            // 
            lstEmpleado.FormattingEnabled = true;
            lstEmpleado.Location = new Point(56, 175);
            lstEmpleado.Name = "lstEmpleado";
            lstEmpleado.Size = new Size(230, 229);
            lstEmpleado.TabIndex = 4;
            // 
            // Form02BuscadorEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 450);
            Controls.Add(lstEmpleado);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleado";
            Text = "Form02BuscadorEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscar;
        private Label label2;
        private ListBox lstEmpleado;
    }
}