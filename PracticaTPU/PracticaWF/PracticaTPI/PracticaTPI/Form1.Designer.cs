namespace PracticaTPI
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
            label1 = new Label();
            btnArchivo = new Button();
            btnSoporte = new Button();
            btnConsultas = new Button();
            btnAcercaDe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 0;
            label1.Text = "Viandas saludables";
            // 
            // btnArchivo
            // 
            btnArchivo.Location = new Point(50, 85);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(162, 54);
            btnArchivo.TabIndex = 1;
            btnArchivo.Text = "Archivo";
            btnArchivo.UseVisualStyleBackColor = true;
            // 
            // btnSoporte
            // 
            btnSoporte.Location = new Point(50, 224);
            btnSoporte.Name = "btnSoporte";
            btnSoporte.Size = new Size(162, 54);
            btnSoporte.TabIndex = 2;
            btnSoporte.Text = "Soporte";
            btnSoporte.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            btnConsultas.Location = new Point(406, 85);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(162, 54);
            btnConsultas.TabIndex = 3;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = true;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Location = new Point(406, 224);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(162, 54);
            btnAcercaDe.TabIndex = 4;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 363);
            Controls.Add(btnAcercaDe);
            Controls.Add(btnConsultas);
            Controls.Add(btnSoporte);
            Controls.Add(btnArchivo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnArchivo;
        private Button btnSoporte;
        private Button btnConsultas;
        private Button btnAcercaDe;
    }
}
