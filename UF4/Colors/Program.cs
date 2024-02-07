using System;
using EjerciciosOOP;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Color negro = new Color();
            Color rojo = new Color("Rojo", 250, 0, 0);
            Triangulo triangulo = new Triangulo(3, 3, 3, 4, 5, rojo, negro);
            Color verde = new Color("Verde", 0, 0, 255);
            Cuadrado cuadrado = new Cuadrado(4, 4, verde, negro);
            Color azul = new Color("Azul", 0, 255, 0);
            Circulo circulo = new Circulo(1, 3, azul, negro);

            Console.WriteLine("El area del triangulo es: " + triangulo.GetArea());
            Console.WriteLine("El area del circulo es: " + circulo.GetArea());
            Console.WriteLine("El area del cuadrado es: " + cuadrado.GetArea());

            var randColor = Color.Random();
            Console.WriteLine(randColor.Nombre + " " + randColor.ShowRGB());
            Console.WriteLine(rojo.GetHex());
        }
    }
}