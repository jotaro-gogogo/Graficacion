using System;
namespace DDA
{
    public class Linea
    {
        Matriz matrix = new Matriz();
        Punto a = new Punto();
        Punto b = new Punto();

        double dx;
        double dy;
        double pasos;
        double xInc;
        double yInc;

        public Linea()
        {
            dx = dy = 1;
            xInc = yInc = pasos = dx;
        }

        public void Calcular(Punto a, Punto b)
        {
            Punto coordenada = new Punto();
            double x = Convert.ToDouble(a.X);
            double y = Convert.ToDouble(a.Y);

            dx = Math.Abs(b.X - a.X);
            dy = Math.Abs(b.Y - a.Y);

            Console.WriteLine("Dx: {0}  Dy: {1}\n", dx, dy);

            if (dx == 0 || dy == 0) pasos = 1;
            else
            {
                if (dx > dy) pasos = dx;
                else pasos = dy;
            }

            Console.WriteLine("Pasos: {0}\n", pasos);

            xInc = dx / pasos;
            yInc = dy / pasos;
            Console.WriteLine("Incremento en X: {0}\nIncremento en Y: {1}\n", xInc, yInc);

            for (int i = 0; i < pasos; i++)
            {
                x += xInc;
                y += yInc;

                coordenada.X = Convert.ToInt32(Math.Round(x));
                coordenada.Y = Convert.ToInt32(Math.Round(y));

                Console.WriteLine("X: {0}  Y: {1}", coordenada.X, coordenada.Y);

                matrix.DrawLine(coordenada);
            }
            Console.WriteLine();
            matrix.MuestraMatriz();
        }
    }
}
