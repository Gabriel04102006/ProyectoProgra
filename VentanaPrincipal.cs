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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            VentanaNO ventanaNO = new VentanaNO();
            ventanaNO.Show();
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            Ventana1 ventana1 = new Ventana1();
            ventana1.Show();
        }
    }
}
