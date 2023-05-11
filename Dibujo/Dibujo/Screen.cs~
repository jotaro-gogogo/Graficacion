using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Dibujo
{
    public class Screen :  GameWindow
    {
    	
    	Poligono[] poligonos =
    	{
    							//izquierda superior || derecha superior || derecha inferior || izquierda inferior || a elegir || color
        	new Poligono(new Punto[] { new Punto(0, 0), new Punto(600, 0), new Punto(600, 25), new Punto(0, 25) }, Color.PeachPuff),
        	new Poligono(new Punto[] { new Punto(0, 25), new Punto(600, 25), new Punto(600, 50), new Punto(0, 50) }, Color.Coral),
        	new Poligono(new Punto[] { new Punto(0, 50), new Punto(600, 50), new Punto(600, 100),  new Punto(0, 100) }, Color.Blue),
        	//tiburon (triangulo)
        	new Poligono(new Punto[] { new Punto(100, 55), new Punto(150, 55), new Punto(125, 170) }, Color.DarkBlue),
        	//nube1
        	new Poligono(new Punto[] { new Punto(450, 450), new Punto(600, 450), new Punto(600, 580), new Punto(450, 580), new Punto(380, 500), new Punto(450, 450) }, Color.LightGray),
        	//palmera
        	new Poligono(new Punto[] { new Punto(550, 10), new Punto(600, 10), new Punto(600, 500), new Punto(550, 500) }, Color.DarkGoldenrod),
        	new Poligono(new Punto[] { new Punto(550, 500), new Punto(600, 500), new Punto(500, 550), new Punto(420, 550), new Punto(370, 420) }, Color.Green),
        	new Poligono(new Punto[] { new Punto(550, 500), new Punto(600, 350), new Punto(600, 555), new Punto(555, 555), new Punto(600, 350) }, Color.Green),
        	//nube2
        	new Poligono(new Punto[] { new Punto(50, 300), new Punto(200, 300), new Punto(260, 380), new Punto(200, 460), new Punto(50, 460), new Punto(25, 380), new Punto(50, 300) }, Color.LightGray),
    	};
    	
        Punto A = new Punto(0, 100);
        Punto B = new Punto(0, 600);
        UVector vec = new UVector();
        Circulo S = new Circulo();

        public Screen(int ancho, int alto) : base(ancho, alto)
        {
            Title = "Dibujo";
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0,600, 0, 600, -1,1);
            //Console.WriteLine("Magnitud : " + vec.Magnitud);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            vec.ColorVector(1f,0.6f,0.01f, 0.01f,0.4f,0.9f); // A || B establecer el color del vector
            vec.CalcularComponentes(A, B);
        }

       protected override void OnRenderFrame(FrameEventArgs e)
		{
    		GL.Clear(ClearBufferMask.ColorBufferBit);

    		int n = 1; // número de veces que se repetirá el vector

    		for (int i = 0; i < n; i++)
    		{
        		Punto start = new Punto(i * 5, 100); // posición inicial del vector
        		Punto end = new Punto(i * 5, 600); // posición final del vector

        		start.Draw();
        		end.Draw();
        		vec.Draw(start);
    		}
    		
    		foreach (Poligono poligono in poligonos)
    		{
                /*GL.Begin(PrimitiveType.Polygon);
        		GL.Color3(poligono.color);
        		foreach (Punto punto in poligono.puntos)
       	 		{
            		GL.Vertex2(punto.x, punto.y);
        		}
        		GL.End();*/

                poligono.Draw();
    		}
    		
    		//S.DibujarCirculo(360, Color.OrangeRed);

   			SwapBuffers();
		}
    }
}