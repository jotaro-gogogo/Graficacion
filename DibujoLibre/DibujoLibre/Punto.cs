using System;
namespace DibujoLibre
{
    public class Punto
    {
        int x;
        int y;

        public Punto()
        {
            x = y = 0;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
