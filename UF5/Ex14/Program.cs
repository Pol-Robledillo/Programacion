using System;
using System.Collections;
using System.Text.RegularExpressions;
namespace ActividadesUF5
{
    public class Ex14
    {
        public static void Main()
        {
            string phraseNoNum = "This is a test9";
            string phraseMinus = "this is a test9";
            string phraseMayus = "THIS IS A TEST9";
            string phraseMix = "This Is A Test";
            string phraseABB = "This is abb test9";
            string phraseMinus_ = "this is a_ test9";
            List<string> phrases = [phraseNoNum, phraseMinus, phraseMayus, phraseMix, phraseABB, phraseMinus_];

            CheckMayusMinusNums(phrases);
            CheckA(phrases);
            CheckAThenB(phrases);
            CheckUnderscore(phrases);
        }
        public static void CheckUnderscore(List<string> list)
        {
            Regex rgx = new Regex("[a-z][_]");
            foreach (string phrase in list)
            {
                if (rgx.IsMatch(phrase))
                {
                    Console.WriteLine("La frase " + phrase + " contiene una letra minúscula seguida del caracter '_'");
                }
                else
                {
                    Console.WriteLine("La frase " + phrase + " no contiene una letra minúscula seguida del caracter '_'");
                }
            }
        }
        public static void CheckAThenB(List<string> list)
        {
            Regex rgx = new Regex("[aA][bB]{2,}");
            foreach (string phrase in list)
            {
                if (rgx.IsMatch(phrase))
                {
                    Console.WriteLine("La frase " + phrase + " contiene la letra 'a' seguida de o más letras 'b'");
                }
                else
                {
                    Console.WriteLine("La frase " + phrase + " no contiene la letra 'a' seguida de 2 o más letras 'b'");
                }
            }
        }
        public static void CheckA(List<string> list)
        {
            Regex rgx = new Regex("[aA]");
            foreach (string phrase in list)
            {
                if (rgx.IsMatch(phrase))
                {
                    Console.WriteLine("La frase " + phrase + " contiene la letra 'a'");
                }
                else
                {
                    Console.WriteLine("La frase " + phrase + " no contiene la letra 'a'");
                }
            }
        }
        public static void CheckMayusMinusNums(List<string> list)
        {
            Regex rgxMinus = new Regex("[a-z]");
            Regex rgxMayus = new Regex("[A-Z]");
            Regex rgxNum = new Regex("[0-9]");

            foreach (string phrase in list)
            {
                if (rgxMinus.IsMatch(phrase))
                {
                    if (rgxMayus.IsMatch(phrase))
                    {
                        if (rgxNum.IsMatch(phrase))
                        {
                            Console.WriteLine("La frase " + phrase + " contiene mayúsculas, minúsculas y números");
                        }
                        else
                        {
                            Console.WriteLine("La frase " + phrase + " no contiene números");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La frase " + phrase + " no contiene mayúsculas");
                    }
                }
                else
                {
                    Console.WriteLine("La frase " + phrase + " no contiene minúsculas");
                }
            }
        }
    }
}