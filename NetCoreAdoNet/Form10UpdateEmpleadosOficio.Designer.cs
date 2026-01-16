namespace NetCoreAdoNet
{
    partial class Form10UpdateEmpleadosOficio
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            lblSuma = new Label();
            lblMedia = new Label();
            lblMaximo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 46);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(42, 73);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(136, 229);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 46);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(202, 73);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(137, 229);
            lstEmpleados.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 46);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(357, 73);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 5;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(357, 114);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(100, 31);
            btnIncrementar.TabIndex = 6;
            btnIncrementar.Text = "Subir salarios";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(42, 344);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(87, 15);
            lblSuma.TabIndex = 7;
            lblSuma.Text = "lblSumaSalarial";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(42, 374);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(90, 15);
            lblMedia.TabIndex = 8;
            lblMedia.Text = "lblMediaSalarial";
            // 
            // lblMaximo
            // 
            lblMaximo.AutoSize = true;
            lblMaximo.Location = new Point(42, 403);
            lblMaximo.Name = "lblMaximo";
            lblMaximo.Size = new Size(99, 15);
            lblMaximo.TabIndex = 9;
            lblMaximo.Text = "lblMaximoSalario";
            // 
            // Form10UpdateEmpleadosOficio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 450);
            Controls.Add(lblMaximo);
            Controls.Add(lblMedia);
            Controls.Add(lblSuma);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficio";
            Text = "Form10UpdateEmpleadosOficio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label lblSuma;
        private Label lblMedia;
        private Label lblMaximo;
    }
}