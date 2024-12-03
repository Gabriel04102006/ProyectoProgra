using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Progra
{
    public partial class VentanaNO : Form
    {
        private Timer timer;
        public VentanaNO()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 3000; // dura 6 segundos
            timer.Tick += Timer_Tick; // Asignar evento
            timer.Start(); // Iniciar el temporizador
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Detener el temporizador
            this.Close(); // Cerrar la ventana
        }
    }
}
