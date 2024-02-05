using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Lectura : IPrestar
    {
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public string FechaPubli { get; set; }
        public int Volumen { get; set; }
        public int Paginas { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }

        public Lectura(string nombre, string editorial, string fechaPubli, int volumen, int paginas, string autor, string categoria)
        {
            Nombre = nombre;
            Editorial = editorial;
            FechaPubli = fechaPubli;
            Volumen = volumen;
            Paginas = paginas;
            Autor = autor;
            Categoria = categoria;
        }
        public void Prestar()
        {
            Console.WriteLine("El libro ha sido prestado");
        }
        public void Devolver()
        {
            Console.WriteLine("El libro ha sido devuelto");
        }
        public int Retraso(int retraso)
        {
            Console.WriteLine("El libro ha sido devuelto con {0} días de retraso", retraso);
            return retraso > 0 ? 1 : 0;
        }
    }
}