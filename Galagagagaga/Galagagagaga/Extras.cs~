using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Galagagagaga
{
    public class Extras
    {

        public Extras()
        {
        }

        public void Estrellas()
        {
            GL.Color3(1f, 1f, 1f);
            GL.Begin(PrimitiveType.Points);

            for (int i = 25; i < 600; i += 50)
            {
                for (int j = 25; j < 600; j += 50)
                {
                    GL.Vertex2(i, j);
                }
            }

            GL.End();
        }
    }
}
