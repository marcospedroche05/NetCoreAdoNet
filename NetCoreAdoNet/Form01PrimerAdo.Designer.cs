namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnRead = new Button();
            lstApellidos = new ListBox();
            label2 = new Label();
            lstColumnas = new ListBox();
            label3 = new Label();
            lstTipos = new ListBox();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellidos";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(36, 75);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 43);
            btnConectar.TabIndex = 1;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(36, 135);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(87, 48);
            btnDesconectar.TabIndex = 2;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(36, 205);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 42);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(162, 75);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(120, 274);
            lstApellidos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 39);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(315, 75);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(120, 274);
            lstColumnas.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 39);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Tipos dato";
            // 
            // lstTipos
            // 
            lstTipos.FormattingEnabled = true;
            lstTipos.Location = new Point(463, 75);
            lstTipos.Name = "lstTipos";
            lstTipos.Size = new Size(120, 274);
            lstTipos.TabIndex = 8;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(36, 392);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(71, 15);
            lblConexion.TabIndex = 9;
            lblConexion.Text = "lblConexion";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(lblConexion);
            Controls.Add(lstTipos);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(btnRead);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Controls.Add(label1);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnRead;
        private ListBox lstApellidos;
        private Label label2;
        private ListBox lstColumnas;
        private Label label3;
        private ListBox lstTipos;
        private Label lblConexion;
    }
}