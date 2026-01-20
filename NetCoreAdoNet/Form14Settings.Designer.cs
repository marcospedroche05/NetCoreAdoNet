namespace NetCoreAdoNet
{
    partial class Form14Settings
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
            btnLeerSettings = new Button();
            lblConexion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLeerHelper = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLeerSettings
            // 
            btnLeerSettings.Location = new Point(35, 35);
            btnLeerSettings.Name = "btnLeerSettings";
            btnLeerSettings.Size = new Size(155, 44);
            btnLeerSettings.TabIndex = 0;
            btnLeerSettings.Text = "Leer Settings";
            btnLeerSettings.UseVisualStyleBackColor = true;
            btnLeerSettings.Click += btnLeerSettings_Click;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(35, 103);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(71, 15);
            lblConexion.TabIndex = 1;
            lblConexion.Text = "lblConexion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(237, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnLeerHelper
            // 
            btnLeerHelper.Location = new Point(237, 35);
            btnLeerHelper.Name = "btnLeerHelper";
            btnLeerHelper.Size = new Size(158, 44);
            btnLeerHelper.TabIndex = 4;
            btnLeerHelper.Text = "Leer helper conf";
            btnLeerHelper.UseVisualStyleBackColor = true;
            btnLeerHelper.Click += btnLeerHelper_Click;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 537);
            Controls.Add(btnLeerHelper);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblConexion);
            Controls.Add(btnLeerSettings);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerSettings;
        private Label lblConexion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLeerHelper;
    }
}