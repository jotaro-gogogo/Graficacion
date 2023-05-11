using System;
namespace Galagagagaga
{
    public class Punto
    {
        public Punto()
        {
            X = Y = 0;
        }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
