using System;
namespace Cuadratica
{
    public class Linea
    {
        Matriz matrix = new Matriz();

        public Linea()
        {
        }

        public void Calcular()
        {
            Punto punto = new Punto();
            int y;

            for (int x = 0; x < 20; x++)
            {
                y = x * x;

                punto.X = x;
                punto.Y = y;
                Console.WriteLine("X: {0}\tY: {1}", x, punto.Y);
                if (y <= 20)
                {
                    matrix.DrawDot(punto);
                }
            }

            matrix.MuestraMatriz();
        }
    }
}
