using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Color
    {
        private const int MinValue = 0;
        private const int MaxValue = 255;
        private const string DefaultName = "No name";
        private const string DefaultColor = "Negro";
        private static int colorsCount = 0;
        public string Nombre { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public Color(string nombre, int r, int g, int b)
        {
            Nombre = nombre;
            R = r;
            G = g;
            B = b;
            colorsCount++;
        }
        public Color(int r, int g, int b) : this(DefaultName, r, g, b) { }
        public Color() : this(DefaultColor, MinValue, MinValue, MinValue) { }
        public string ShowRGB()
        {
            return $"RGB: ({R}, {G}, {B})";
        }
        public string ShowRGB(bool minus)
        {
            return minus ? ShowRGB().ToLower() : ShowRGB();
        }
        public static Color Random()
        {
            return new Color(MyMath.NextInt(MaxValue), MyMath.NextInt(MaxValue), MyMath.NextInt(MaxValue));
        }
        public static int GetColorsCount()
        {
            return colorsCount;
        }
        public string GetHex()
        {
            return $"#{MyMath.IntToHex(R)}{MyMath.IntToHex(G)}{MyMath.IntToHex(B)}";
        }
    }
}
