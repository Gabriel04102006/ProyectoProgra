namespace Proyecto_Progra
{
    internal class Curso
    {
        public int ID;
        public string nombre;
        public string descripcion;

        public Curso(int ID, string nombre, string descripcion)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}