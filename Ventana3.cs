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
    public partial class Ventana3 : Form
    {
        public Ventana3()
        {
            InitializeComponent();
        }

        private void btnSiguiente3_Click(object sender, EventArgs e)
        {
            Ventana4 ventana4 = new Ventana4();
            ventana4.Show();
        }
    }
}
