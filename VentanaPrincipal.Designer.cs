namespace Proyecto_Progra
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo1 = new System.Windows.Forms.Label();
            this.lbSaludo = new System.Windows.Forms.Label();
            this.lbPregunta = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo1
            // 
            this.lbTitulo1.AutoSize = true;
            this.lbTitulo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitulo1.Location = new System.Drawing.Point(70, 30);
            this.lbTitulo1.Name = "lbTitulo1";
            this.lbTitulo1.Size = new System.Drawing.Size(510, 80);
            this.lbTitulo1.TabIndex = 2;
            this.lbTitulo1.Text = "Universidad UH";
            // 
            // lbSaludo
            // 
            this.lbSaludo.AutoSize = true;
            this.lbSaludo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaludo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSaludo.Location = new System.Drawing.Point(187, 160);
            this.lbSaludo.Name = "lbSaludo";
            this.lbSaludo.Size = new System.Drawing.Size(205, 40);
            this.lbSaludo.TabIndex = 4;
            this.lbSaludo.Text = "¡Bienvenido!";
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPregunta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPregunta.Location = new System.Drawing.Point(79, 254);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(425, 27);
            this.lbPregunta.TabIndex = 5;
            this.lbPregunta.Text = "¿Deseas matricularte en nuestros cursos?";
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNO.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Location = new System.Drawing.Point(43, 356);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(140, 61);
            this.btnNO.TabIndex = 6;
            this.btnNO.Text = "No";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnSI
            // 
            this.btnSI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSI.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSI.Location = new System.Drawing.Point(415, 356);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(140, 61);
            this.btnSI.TabIndex = 7;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = false;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(653, 518);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.lbSaludo);
            this.Controls.Add(this.lbTitulo1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo1;
        private System.Windows.Forms.Label lbSaludo;
        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnSI;
    }
}

