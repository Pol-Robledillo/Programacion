using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml;
namespace ActividadesUF5
{
    public class PruebaXML
    {
        public static void Main()
        {
            string file = @"..\..\..\files\pokemon.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            foreach (XmlNode pokemon in doc.DocumentElement.ChildNodes)
            {
                if (pokemon.SelectSingleNode("types").InnerText.Contains("fire"))
                {
                    foreach (XmlNode info in pokemon.ChildNodes)
                    {
                        Console.WriteLine(info.Name + ": " + info.InnerText);
                    }
                }
            }
        }
    }
}