using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra
{
    internal class Administrador
    {
        private int id;
        private string nombre;
        private string Apellido1;
        private string Apellido2;
        private string NumTelefono;
        private string Cedula;
        private string Correo;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido11 { get => Apellido1; set => Apellido1 = value; }
        public string Apellido21 { get => Apellido2; set => Apellido2 = value; }
        public string NumTelefono1 { get => NumTelefono; set => NumTelefono = value; }
        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
    }
}
