namespace Proyecto_Progra
{
    partial class VentanaNO
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
            this.lbMensaje = new System.Windows.Forms.Label();
            this.lbMensaje1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(27, 181);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(692, 37);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "¡Gracias por usar nuestro sistema de matrículas!";
            // 
            // lbMensaje1
            // 
            this.lbMensaje1.AutoSize = true;
            this.lbMensaje1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje1.Location = new System.Drawing.Point(92, 159);
            this.lbMensaje1.Name = "lbMensaje1";
            this.lbMensaje1.Size = new System.Drawing.Size(414, 44);
            this.lbMensaje1.TabIndex = 0;
            this.lbMensaje1.Text = "¡Gracias, vuelva pronto!";
            // 
            // VentanaNO
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(504, 330);
            this.Controls.Add(this.lbMensaje1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "VentanaNO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label lbMensaje1;
    }
}