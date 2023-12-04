using System;
namespace Actividades
{
    public class Ex12
    {
        public static void Main()
        {
            double factura, litros;
            const string MsgInputLitros = "Introdueix els llitres consumits: ";
            const string MsgOutputFactura = "La factura de l'aigua és de {0} euros";

            Console.Write(MsgInputLitros);
            litros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            factura = CalculoFactura(litros);
            Console.WriteLine(MsgOutputFactura, factura);
        }

        public static double CalculoFactura(double litros)
        {
            double factura = 6;
            if (litros > 50)
            {
                factura += (litros - 50) * 0.1;
                if (litros > 200)
                {
                    factura += (litros - 200) * 0.3;
                }
            }
            return factura;
        }
    }
}