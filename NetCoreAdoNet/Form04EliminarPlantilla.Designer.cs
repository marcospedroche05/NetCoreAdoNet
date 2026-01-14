namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            btnEliminar = new Button();
            label2 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 42);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(52, 78);
            txtId.Name = "txtId";
            txtId.Size = new Size(108, 23);
            txtId.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(52, 120);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 61);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Plantilla";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 40);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Plantilla:";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(237, 78);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(163, 184);
            lstPlantilla.TabIndex = 4;
            lstPlantilla.SelectedIndexChanged += lstPlantilla_SelectedIndexChanged;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 349);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnEliminar;
        private Label label2;
        private ListBox lstPlantilla;
    }
}