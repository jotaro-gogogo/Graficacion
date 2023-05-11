using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Pantalla
{
	public class Pantalla: GameWindow
	{
		Extras estras;
        Extras rebanadas;
		Punto uno;
		Punto dos;
		Geometrias linea;
        Geometrias circulo;
        Geometrias marinela;

        double a, b, c, d, j, k;

        public Pantalla(int ancho, int alto): base(ancho, alto)
		{
			Title = "Grafica Lok0chon4";
		}

        protected override void OnLoad(EventArgs e)
		{
			GL.ClearColor(Color.Black);
			estras = new Extras();
            rebanadas = new Extras();
			uno = new Punto(0.5f, 0.5f);
			dos = new Punto(-0.9f, -0.9f);
			linea = new Geometrias();
            circulo = new Geometrias();
            marinela = new Geometrias();

            //porcentajes = rebanadas.Rebanadas();
		}

		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
		}

		protected override void OnRenderFrame(FrameEventArgs e)
		{
			//estras.Grilla();
            //estras.Ejes();
            //uno.Draw();
            //dos.Draw();
            //circulo.CirculoParametrico();
            circulo.Curva(a, b, c, d, j, k);
            //linea.Linea(uno, dos);
            //marinela.Barra(uno, dos);
			SwapBuffers();
		}

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            k += 2;
            j += 3;
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            a = e.X;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    a++;
                    break;
                case 'b':
                    b++;
                    break;
                case 'c':
                    c++;
                    break;
                case 'd':
                    d++;
                    break;
                case 'A':
                    a--;
                    break;
                case 'B':
                    b--;
                    break;
                case 'C':
                    c--;
                    break;
                case 'D':
                    d--;
                    break;
                default:
                    break;
            }
        }
    }
}

