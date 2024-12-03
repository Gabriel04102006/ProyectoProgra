namespace Proyecto_Progra
{
    partial class Ventana2
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
            this.lbHorario = new System.Windows.Forms.Label();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(25, 42);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(421, 36);
            this.lbHorario.TabIndex = 1;
            this.lbHorario.Text = "Eliga el horario de preferencia:";
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSiguiente2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiguiente2.Location = new System.Drawing.Point(564, 353);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(198, 61);
            this.btnSiguiente2.TabIndex = 9;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = false;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiguiente2);
            this.Controls.Add(this.lbHorario);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Button btnSiguiente2;
    }
}