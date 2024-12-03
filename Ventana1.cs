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
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Ventana2 ventana2 = new Ventana2();
            ventana2.Show();
        }
    }
    
}
