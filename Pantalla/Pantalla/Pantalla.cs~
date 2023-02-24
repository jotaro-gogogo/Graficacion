using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

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
        double[] porcentajes;

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

            porcentajes = rebanadas.Rebanadas();
		}

		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
		}

		protected override void OnRenderFrame(FrameEventArgs e)
		{
			estras.Grilla();
            estras.Ejes();
            //uno.Draw();
            //dos.Draw();
            circulo.CirculoParametrico(porcentajes);
            //linea.Linea(uno, dos);
            //marinela.Barra(uno, dos);
			SwapBuffers();
		}
	}
}

