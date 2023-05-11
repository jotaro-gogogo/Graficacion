using System;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Dibujo
{
	public class Poligono
	{
    	public Punto[] puntos;
    	public Color color;

    	public Poligono(Punto[] puntos, Color color)
    	{
        	this.puntos = puntos;
        	this.color = color;
   	 	}

        public void Draw()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(color);
            foreach (Punto punto in puntos)
            {
                GL.Vertex2(punto.x, punto.y);
            }
            GL.End();
        }
    }
}
