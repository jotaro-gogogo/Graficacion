using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Barras
{
    public class Barra
    {
        double[] valores;
        double max;
        double width;
        double helperWidth;

        public Barra(double[] _valores)
        {
            valores = new double[_valores.Length];

            _valores.CopyTo(valores, 0);
            width = 2f / valores.Length;
            //Console.WriteLine("Ancho de barra: " + width);
            helperWidth = width;
            //Console.WriteLine("Ancho de barra Nueva: " + helperWidth);

            GetMaxValue();
            Convertir();
            DibujaBarra();
        }

        private void GetMaxValue()
        {
            max = valores[0];

            for (int i = 1; i < valores.Length; i++)
                if (valores[i] > max)
                    max = valores[i];
            //Console.WriteLine("Valor máximo: " + max);
        }

        private void Convertir()
        {
            //Console.WriteLine("Valores convertidos.");
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] /= max;
                //Console.WriteLine(valores[i]);
            }
        }

        public void DibujaBarra()
        {
            Punto a = new Punto();
            Punto b = new Punto();

            for (int i = 0; i < valores.Length; i++)
            {
                if (i == 0)
                {
                    a.SetPunto(-1, 0);
                    b.SetPunto(helperWidth, valores[i]);
                }
                else
                {
                    a.SetPunto(helperWidth, 0);
                    if (helperWidth <= 2)
                        b.SetPunto(helperWidth + width, valores[i]);
                    else
                        b.SetPunto(Math.Truncate(helperWidth + width), valores[i]);

                    helperWidth += width;
                }

                OnlyQuads(a, b, i);
            }
        }

        private void OnlyQuads(Punto a, Punto b, int color)
        {
            GL.Color3(valores[color], valores[color], valores[color]);
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex2(a.X, a.Y);
            GL.Vertex2(b.X, a.Y);
            GL.Vertex2(b.X, b.Y);
            GL.Vertex2(a.X, b.Y);

            Console.WriteLine("A({0}, {1})\tB({2}, {3})", a.X, a.Y, b.X, b.Y);

            GL.End();
        }
    }
}
