using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace DibujoLibre
{
    public class Cuadrilatero
    {
        Punto p1;
        Punto p2;
        double r, g, b;

        public Cuadrilatero(Punto p1, Punto p2, double r = 1, double g = 1, double b = 1)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public void Draw()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(r, g, b);

            GL.Vertex2(p1.X, p1.Y);
            GL.Vertex2(p2.X, p1.Y);
            GL.Vertex2(p2.X, p2.Y);
            GL.Vertex2(p1.X, p2.Y);

            GL.End();
        }

        public void TriDraw()
        {
            double dist = p2.X - p1.X;
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(r, g, b);

            GL.Vertex2(p1.X, p1.Y);
            GL.Vertex2(p2.X, p1.Y);
            GL.Vertex2(p1.X + (dist / 2), p2.Y);
            GL.Vertex2(p1.X + (dist / 2), p2.Y);

            GL.End();
        }

        public void TrompaDraw()
        {
            double dist = p2.X - p1.X;
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(r, g, b);

            GL.Vertex2(p1.X, p1.Y);
            GL.Vertex2(p2.X, p1.Y);
            GL.Vertex2(p1.X + (dist / 2), p2.Y);
            GL.Vertex2(p1.X, p2.Y);

            GL.End();
        }

        public void SetColor(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
