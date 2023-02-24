using System;

/*
 * Si en alguna división el numerador o
 * el denominador llegasen a ser cero, por default los pasos serán 1
*/

namespace DDA
{
    public class Pendiente
    {
        Matriz mat;
        public Pendiente()
        {
            mat = new Matriz();
        }

        public void Valores(Punto inicio, Punto final)
        {
            double m;
            int pasos;
            int dy = final.Y - inicio.Y;
            int dx = final.X - inicio.X;

            m = dy / dx;

            if (dx > dy)
                pasos = Math.Abs(dx);
            else
                pasos = Math.Abs(dy);

            Incremento(dx, dy, pasos, inicio);
        }

        private void Incremento(int dx, int dy, int pasos, Punto punto)
        {
            double xInc = dx / pasos;
            double yInc = dy / pasos;
            Punto _punto = new Punto();

            for (int i = 0; i<pasos; i++)
            {
                _punto.X = (int)Math.Round(punto.X + xInc);
                _punto.Y = (int)Math.Round(punto.Y + yInc);

                //mat.DrawLine(_punto);
            }

            mat.MuestraMatriz();
        }
    }
}
