using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Pantalla
{
	public class Punto
	{
		double x;
		double y;

		public Punto()
		{
			x = y = 0;
		}

		public Punto(double xi, double yi)
		{
			x = xi;
			y = yi;
		}

		public double X
		{
			get { return x; }
			set { x = value; }
		}

		public double Y
		{
			get { return y; }
			set { y = value; }
		}

		public void Draw()
		{
            GL.Color3(0.6f, 0.5f, 1f);
            GL.PointSize(18);
            GL.Begin(PrimitiveType.Points);
            GL.Vertex2(x, y);
			GL.End();
		}
	}
}

