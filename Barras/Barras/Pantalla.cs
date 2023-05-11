using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Barras
{
    public class Pantalla: GameWindow
    {
        Guias lineas;
        Barra barra;
        double[] valores = new double[1];

        public Pantalla(int ancho, int alto): base(ancho, alto)
        {
            Title = "Barritas Marinela";
            Console.Write("Cuantos datos desea agregar? ");
            valores = new double[int.Parse(Console.ReadLine())];

            Topes();
        }

        private void Topes()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Valor máximo de la barra #{0}: ", i + 1);
                valores[i] = double.Parse(Console.ReadLine());
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            //GL.ClearColor(Color.Black);
            barra = new Barra(valores);
            lineas = new Guias();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //lineas.Eje();
            lineas.Grilla();
            //barra.DibujaBarra();
            SwapBuffers();
        }
    }
}
