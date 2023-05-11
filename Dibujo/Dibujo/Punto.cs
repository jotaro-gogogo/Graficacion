using System;
using OpenTK.Graphics.OpenGL;

namespace Dibujo
{
    public class Punto
    {
        int puntox;
        int puntoy;
        public Punto()
        {
            puntox = puntoy = 0;
        }

        public Punto(int CoordenadaX, int CoordenadaY)
        {
            puntox = CoordenadaX;
            puntoy = CoordenadaY;
        }

        public int x
        {
            set { puntox = value; }
            get { return puntox; }
        }

        public int y
        {
            set { puntoy = value; }
            get { return puntoy; }
        }

        public void Set(int CoordenadaX, int CoordenadaY)
        {
            puntox = CoordenadaX;
            puntoy = CoordenadaY;
        }

        public void Draw()
        {
            GL.PointSize(10);
            GL.Begin(PrimitiveType.Points);
            GL.Vertex2(puntox, puntoy);
            GL.End();
        }
    }
}