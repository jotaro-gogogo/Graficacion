using System;
using OpenTK.Graphics.OpenGL;

namespace Dibujo
{
    public class UVector
    {
        int componenteX;
        int componenteY;
        double magnitud;
        double MagnitudColor;

        float colorR;
        float colorG;
        float colorB;

        float colorRA;
        float colorGA;
        float colorBA;

        float colorRB;
        float colorGB;
        float colorBB;

        public UVector()
        {
            componenteX = componenteY = 0;
            magnitud = 0;
        }

        public void CalcularComponentes(Punto A, Punto B)
        {
            componenteX = B.x - A.x;
            componenteY = B.y - A.y;
            magnitud = Math.Sqrt(componenteX * componenteX + componenteY * componenteY);
        }

        public double Magnitud
        {
            get { return magnitud; }
        }

        public void ColorVector(float cRA,float cGA,float cBA, float cRB, float cGB,float cBB)
        {
            colorRA = cRA;
            colorGA = cGA;
            colorBA = cBA;

            colorRB = cRB;
            colorGB = cGB;
            colorBB = cBB;

            colorR = colorRB - colorRA;
            colorG = colorGB - colorGA;
            colorB = colorBB - colorBA;

            MagnitudColor =  Math.Sqrt(
                colorR * colorR +
                colorG * colorG +
                colorB * colorB );
            //Console.WriteLine("{0}, {1}, {2}", colorR, colorG, colorB);
        }

        public void Draw(Punto A)
        {
            double univecx = componenteX / magnitud;
            double univecy = componenteY / magnitud;

            double colR = Math.Abs(colorR / MagnitudColor);
            double colG = Math.Abs(colorG / MagnitudColor);
            double colB = Math.Abs(colorB / MagnitudColor);

            GL.Begin(PrimitiveType.Points);
            for (double alpha = 0; alpha<= 1; alpha+=0.015)
            {
                GL.Color3(colorRA + alpha*(colorRB-colorRA), colorGA + alpha*(colorGB - colorGA), colorBA + alpha*(colorBB - colorBA));
                //Console.WriteLine("{0}, {1}, {2}",alpha * colR, alpha * colG, alpha * colB);
                GL.Vertex2(A.x + alpha * componenteX,A.y + alpha * componenteY);
            }
            GL.End();
        }
    }
}