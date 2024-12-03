using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra
{
    internal class Usuario
    {
        private int id;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string numTelefono;
        private string cedula;
        private string correo;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string NumTelefono { get => numTelefono; set => numTelefono = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Correo { get => correo; set => correo = value; }
        public int NuevoID { get; }
        public int ID { get; internal set; }

        public Usuario(int id, string nombre, string correo, string cedula, string apellido1, string apellido2) 
        
        {
            id = Id;
            nombre = Nombre;
            correo = Correo;
            cedula = Cedula;
            apellido1 = Apellido1;
            apellido2 = Apellido2;
        }

        public Usuario(int nuevoID, string nombre, string correo)
        {
            this.ID     = nuevoID;
            this.nombre = nombre;
            this.correo = correo;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, primer apellido {Apellido1}, segundo apellido {Apellido2}, Correo: {Correo}, Cedula: {Cedula}";
        }
    }

    
   
}
