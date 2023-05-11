using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Dibujo
{

	public class Circulo
	{
		double grado = (Math.PI * 2) / 360;
		public Color color;
		public Circulo()
		{
		}
		
		public void DibujarCirculo(double Grados, Color color)
		{
			this.color = color;
			GL.Begin(PrimitiveType.Polygon);
			GL.Vertex2(0, 0);
			for(double t = 0*grado; t <= grado*Grados; t += 0.01f)
			{
				GL.Vertex2(Math.Cos(t), Math.Sin(t));
			}
			GL.End();
		}
	}
}
