using System;
using EjerciciosOOP;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Que quieres introducir? \n1. Llibre \n2. Revista \n3. Diari");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Introduce el nombre del libro");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Introduce la editorial del libro");
                    string editorial = Console.ReadLine();
                    Console.WriteLine("Introduce la fecha de publicacion del libro");
                    string fechaPubli = Console.ReadLine();
                    Console.WriteLine("Introduce el volumen del libro");
                    int volumen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el numero de paginas del libro");
                    int paginas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el autor del libro");
                    string autor = Console.ReadLine();
                    Console.WriteLine("Introduce la categoria del libro");
                    string categoria = Console.ReadLine();
                    Libro libro = new Libro(nombre, editorial, fechaPubli, volumen, paginas, autor, categoria);
                    Console.WriteLine("Nombre: " + libro.Nombre + "\nEditorial: " + libro.Editorial + "\nFecha de publicacion: " + libro.FechaPubli + "\nVolumen: " + libro.Volumen + "\nPaginas: " + libro.Paginas + "\nAutor: " + libro.Autor + "\nCategoria: " + libro.Categoria);
                    Console.WriteLine("Que quieres hacer? \n1. Prestar \n2. Devolver \n3. Informar de un retraso");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            libro.Prestar();
                            break;
                        case 2:
                            libro.Devolver();
                            break;
                        case 3:
                            Console.WriteLine("Introduce el numero de dias de retraso");
                            int retraso = Convert.ToInt32(Console.ReadLine());
                            libro.Retraso(retraso);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Introduce el nombre de la revista");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduce la editorial de la revista");
                    editorial = Console.ReadLine();
                    Console.WriteLine("Introduce la fecha de publicacion de la revista");
                    fechaPubli = Console.ReadLine();
                    Console.WriteLine("Introduce el volumen de la revista");
                    volumen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el numero de paginas de la revista");
                    paginas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el autor de la revista");
                    autor = Console.ReadLine();
                    Console.WriteLine("Introduce la categoria de la revista");
                    categoria = Console.ReadLine();
                    Revista revista = new Revista(nombre, editorial, fechaPubli, volumen, paginas, autor, categoria);
                    Console.WriteLine("Nombre: " + revista.Nombre + "\nEditorial: " + revista.Editorial + "\nFecha de publicacion: " + revista.FechaPubli + "\nVolumen: " + revista.Volumen + "\nPaginas: " + revista.Paginas + "\nAutor: " + revista.Autor + "\nCategoria: " + revista.Categoria);
                    Console.WriteLine("Que quieres hacer? \n1. Prestar \n2. Devolver \n3. Informar de un retraso");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            revista.Prestar();
                            break;
                        case 2:
                            revista.Devolver();
                            break;
                        case 3:
                            Console.WriteLine("Introduce el numero de dias de retraso");
                            int retraso = Convert.ToInt32(Console.ReadLine());
                            revista.Retraso(retraso);
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Introduce el nombre del diario");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduce la editorial del diario");
                    editorial = Console.ReadLine();
                    Console.WriteLine("Introduce la fecha de publicacion del diario");
                    fechaPubli = Console.ReadLine();
                    Console.WriteLine("Introduce el volumen del diario");
                    volumen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el numero de paginas del diario");
                    paginas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el autor del diario");
                    autor = Console.ReadLine();
                    Console.WriteLine("Introduce la categoria del diario");
                    categoria = Console.ReadLine();
                    Diario diario = new Diario(nombre, editorial, fechaPubli, volumen, paginas, autor, categoria);
                    Console.WriteLine("Nombre: " + diario.Nombre + "\nEditorial: " + diario.Editorial + "\nFecha de publicacion: " + diario.FechaPubli + "\nVolumen: " + diario.Volumen + "\nPaginas: " + diario.Paginas + "\nAutor: " + diario.Autor + "\nCategoria: " + diario.Categoria);
                    Console.WriteLine("Que quieres hacer? \n1. Prestar \n2. Devolver \n3. Informar de un retraso");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            diario.Prestar();
                            break;
                        case 2:
                            diario.Devolver();
                            break;
                        case 3:
                            Console.WriteLine("Introduce el numero de dias de retraso");
                            int retraso = Convert.ToInt32(Console.ReadLine());
                            diario.Retraso(retraso);
                            break;
                    }
                    break;
            }
        }
    }
}