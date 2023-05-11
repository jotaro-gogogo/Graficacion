using System;
using OpenTK.Graphics.OpenGL;

namespace DDAGrafico
{
    public class Primitivas
    {
        public Primitivas()
        {
        }

        public void Circulo(Punto a, int radio)
        {
            GL.Begin(PrimitiveType.LineLoop);

            for (double i = 0; i < Math.PI*2; i += 0.01)
            {
                GL.Vertex2(a.X + Math.Cos(i) * radio, a.Y + Math.Sin(i) * radio);
            }

            GL.End();
        }
    }
}
