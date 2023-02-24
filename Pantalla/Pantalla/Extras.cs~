using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Pantalla
{
    public class Extras
    {
        // Ingredientes del pastel:
        int rebanadas = 0;
        double valor; // Convirtiendo el entero a valor decimal equivalente al porcentaje
        double[] porcentajes; // Lista de los porcentajes

        private Random r;

        public Extras()
        {
            r = new Random();
        }

        public void Grilla()
        {
            GL.LineWidth(1);
            for (double y=-1f; y<1f; y += 0.1f) 
            {
                for(double x=-1f; x<1f; x += 0.1f) 
                {
                    GL.Begin (PrimitiveType.Lines);
                    GL.Color3(0.4f, 0.4f, 0.4f);
                    GL.Vertex2 (-1, x);
                    GL.Vertex2 (1, x);
                    GL.Vertex2 (y, -1);
                    GL.Vertex2 (y, 1);
                    GL.End ();
                }
            }
        }

        public void Ejes()
        {
            GL.LineWidth(4);
            GL.Begin (PrimitiveType.Lines);
            GL.Color3(0.8f, 0.8f, 0.8f);
            GL.Vertex2(0, 1);
            GL.Vertex2(0, -1);
            GL.Vertex2(-1, 0);
            GL.Vertex2(1, 0);
            GL.End ();
        }

        public double[] Rebanadas()
        {
            Console.Write("Cuantos valores desea ingresar?: ");
            rebanadas = int.Parse(Console.ReadLine());
            porcentajes = new double[rebanadas];

            for (int i = 0; i < rebanadas; i++)
            {
                Console.WriteLine($"Ingrese el porcentaje de la rebanada No. {i + 1}.");
                Console.Write("(Solo valores del 0 al 100): ");
                valor = double.Parse(Console.ReadLine()) / 100f; // Convirtiendo a porcentaje
                valor = ((Math.PI * 2) * valor) * 180 / Math.PI; // Convirtiendo de radianes a grados
                porcentajes[i] = valor;
            }

            return porcentajes;
        }

        public double[] Randomizar()
        {
            /*
             * Asigna tres valores aleatorios a un
             * arreglo que seran usados como valores
             * para los colores de la linea del circulo.
            */

            double[] colores = new double[3];

            for (int i = 0; i < 3; i++)
            {
                colores[i] = r.NextDouble();
            }

            return colores;
        }
    }
}

