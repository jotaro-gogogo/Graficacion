using System;
using System.Globalization;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Pantalla
{
    public class Geometrias
    {
        Extras random;

        public Geometrias()
        {
            random = new Extras();
        }

        public void Linea(Punto inicio, Punto fin)
        {
            GL.Color3(0.5f, 0.8f, 1f);
            GL.Begin(PrimitiveType.Lines);
            /*
             * Usando puntos la linea jamás se dibujó
             * for(double x=inicio.X; x<fin.X; x += 0.001f) 
            {
                GL.Vertex2(x, (10*x)+2);
            }*/
            GL.Vertex2(inicio.X, inicio.Y);
            GL.Vertex2(fin.X, fin.Y);
            GL.End();
        }

        public void Circulo()
        {
            GL.Begin(PrimitiveType.Points);
            for (double i=-1; i<=1; i += 0.001f) 
            {
                GL.Vertex2(i, Math.Sqrt (1 - i * i));
            }
            GL.End();
        }

        public void CirculoParametrico(double[] percent)
        {
            /*
             * Convertir los porcentajes a grados e ir sumando 
             * para que cada nuevo trazo llegue hasta el final.
             * 
             * [°01][°02][°03][°04][°05][°06]
             * for (0 -> percent.length())--¬
             *      vertex2(  ¿¿¿ Math.Cos(¿¿??), Math.Sin(¿¿??) ???   )    
             *      porque ya está convertido a radianes ¿no?            
            */

            double[] colores = random.Randomizar();
            GL.PointSize(3f);
            GL.Begin(PrimitiveType.Points);

            for (int i = 0; i < percent.Length; i++)
            {
                double tmp = 0;

                for (double t = tmp; t <= (Math.PI * 2) * percent[i]; t += 0.001f)
                {
                    GL.Color3(colores[0], colores[1], colores[2]);
                    GL.Vertex2(Math.Cos(t), Math.Sin(t));
                }

                tmp = (Math.PI * 2) * percent[i];
            }

            GL.End();
        }

        public void Barra(Punto a, Punto b)
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(a.X, a.Y);
            GL.Vertex2(b.X, a.Y);
            GL.Vertex2(b.X, b.Y);
            GL.Vertex2(a.X, b.Y);
            GL.End();
        }
    }
}

