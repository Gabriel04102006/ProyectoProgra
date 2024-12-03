namespace Proyecto_Progra
{
    partial class Ventana1
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
            this.lbCursos = new System.Windows.Forms.Label();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCursos
            // 
            this.lbCursos.AutoSize = true;
            this.lbCursos.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCursos.Location = new System.Drawing.Point(28, 34);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(463, 36);
            this.lbCursos.TabIndex = 0;
            this.lbCursos.Text = "Eliga los cursos de su preferencia:";
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSiguiente1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiguiente1.Location = new System.Drawing.Point(562, 355);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(198, 61);
            this.btnSiguiente1.TabIndex = 8;
            this.btnSiguiente1.Text = "Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = false;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.btnSiguiente1);
            this.Controls.Add(this.lbCursos);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Ventana1";
            this.Text = "Ventana1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCursos;
        private System.Windows.Forms.Button btnSiguiente1;
    }
}