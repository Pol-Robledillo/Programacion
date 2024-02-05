using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    internal class Libro : Lectura
    {
        public Libro(string nombre, string editorial, string fechaPubli, int volumen, int paginas, string autor, string categoria) : base(nombre, editorial, fechaPubli, volumen, paginas, autor, categoria) { }
    }
}
