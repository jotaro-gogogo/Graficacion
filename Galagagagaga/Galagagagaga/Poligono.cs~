using System;
using OpenTK.Graphics.OpenGL;

namespace Galagagagaga
{
    public class Poligono
    {
        public Punto centro = new Punto();
        readonly int lados;
        readonly double radio;
        readonly double pasos;
        double r, g, b;

        public Poligono(Punto centro, int lados, double radio, double r = 1, double g = 1, double b = 1)
        {
            this.centro.X = centro.X;
            this.centro.Y = centro.Y;
            this.lados = lados;
            this.radio = radio;
            pasos = Math.PI * 2 / lados;

            this.r = r;
            this.g = g;
            this.b = b;
        }

        public void SetPoligono(Punto centro)
        {
            this.centro.X = centro.X;
            this.centro.Y = centro.Y;
        }

        public void Draw()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(r, g, b);

            for (double t = Math.PI / 2; t <= 2 * Math.PI + Math.PI / 2; t += pasos)
            {
                GL.Vertex2(centro.X + radio * Math.Cos(t), centro.Y + radio * Math.Sin(t));
            }

            GL.End();
        }

        public Punto GetCoord()
        {
            return centro;
        }

        public double GetRadio()
        {
            return radio;
        }

        public void SetColor(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
