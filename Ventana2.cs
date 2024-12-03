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
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            Ventana3 ventana3 = new Ventana3();
            ventana3.Show();
        }
    }
}
