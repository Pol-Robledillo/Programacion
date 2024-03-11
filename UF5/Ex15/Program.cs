using System;
using System.Collections;
using System.Text.RegularExpressions;
namespace ActividadesUF5
{
    public class Ex15
    {
        public static void Main()
        {
            string email = "polrobledilloortega@gmail.com";
            Regex regex = new Regex(@"\S+@\S+\.[a-z]");
            if (regex.IsMatch(email))
            {
                Console.WriteLine("El email " + email + " tiene un formato válido");
            }
            else
            {
                Console.WriteLine("El email " + email + " no tiene un formato válido");
            }
        }
    }
}