namespace NetCoreAdoNet
{
    partial class Form09CRUDHospital
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
            lstHospitales = new ListBox();
            btnEliminar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCamas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(46, 63);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(186, 229);
            lstHospitales.TabIndex = 1;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(46, 316);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 33);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 44);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Hospital_Cod";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 45);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 45);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(639, 45);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 160);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 7;
            label6.Text = "Num_camas";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(290, 316);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(102, 33);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(430, 316);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 33);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(292, 87);
            txtId.Name = "txtId";
            txtId.Size = new Size(76, 23);
            txtId.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(404, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(519, 87);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(639, 87);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 13;
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(290, 193);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(100, 23);
            txtCamas.TabIndex = 14;
            // 
            // Form09CRUDHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCamas);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CRUDHospital";
            Text = "Form09CRUDHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Button btnEliminar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInsertar;
        private Button btnModificar;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCamas;
    }
}