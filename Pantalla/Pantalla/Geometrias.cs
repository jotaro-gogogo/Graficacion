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

        public void CirculoParametrico()
        {
            GL.PointSize(3f);
            GL.Begin(PrimitiveType.Points);
            for (double t = 0; t <= Math.PI * 2; t += 0.001f)
            {
                GL.Color3(Math.Sin(t), Math.Cos(t), 1);
                GL.Vertex2(Math.Cos(t), Math.Sin(t));
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

        public void Curva(double a, double b, double c, double d, double j, double k)
        {
            GL.Begin(PrimitiveType.Points);
            for (double t = 0; t < 2 * Math.PI; t += 0.001)
            {
                double x = Math.Cos(a * t) - Math.Pow(Math.Cos(b * t), j);
                double y = Math.Sin(c * t) - Math.Pow(Math.Sin(d * t), k);
                GL.Vertex2(x, y);
            }
            GL.End();
        }
    }
}

