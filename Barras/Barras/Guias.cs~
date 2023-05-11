using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Barras
{
    public class Guias
    {
        public Guias()
        {
        }

        public void Eje()
        {
            double colour = 1;
            GL.LineWidth(3f);
            GL.Color3(colour, colour, colour);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex2(-1, 0);
            GL.Vertex2(1, 0);
            GL.End();
        }

        public void Grilla()
        {
            GL.Color3(0.4f, 0.4f, 0.4f);
            GL.LineWidth(1f);

            GL.Begin(PrimitiveType.Lines);

            for (double y = 0; y < 1; y += 0.1)
            {
                GL.Vertex2(-1, y);
                GL.Vertex2(1, y);
            }

            GL.End();
        }
    }
}
