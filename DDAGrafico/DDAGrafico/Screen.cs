using System;
//using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace DDAGrafico
{
    public class Screen : GameWindow
    {
        Primitivas circunferencia = new Primitivas();
        Punto p;

        public Screen(int ancho, int alto) : base(ancho, alto)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            //GL.Color3(0, 0, 0);
            p = new Punto(300, 300);

            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0, 600, 0, 600, 1, -1);
                  /* Derecha a izquierda, abajo hacia arriba, perspectiva en Z */
                  /* X            Y            Z */
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            //GL.Clear(ClearBufferMask.AccumBufferBit);
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            circunferencia.Circulo(p, 100);
            SwapBuffers();
        }

        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            p.X = e.X;
            p.Y = 600 - e.Y;
        }
    }
}
