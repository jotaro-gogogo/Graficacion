using System;
using System.Drawing;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Pastel
{
    public class Pantalla: GameWindow
    {
        Grafica pastel;

        public Pantalla(int ancho, int alto): base(ancho, alto)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.Black);
            pastel = new Grafica();
            pastel.Porcentajes();
        }


        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            pastel.Circulo();
            SwapBuffers();
        }
    }
}
