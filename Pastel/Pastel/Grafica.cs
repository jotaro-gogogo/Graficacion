using System;
using System.Collections.Generic;
using System.Linq;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Pastel
{
    public class Grafica
    {
        List<Double> rebanadas = new List<double>();
        private Random r;
        double[] colores = new double[3];

        public Grafica()
        {
            r = new Random();
            Randomizar();
        }

        public double[] Randomizar()
        {
            for (int i = 0; i < 3; i++)
            {
                colores[i] = r.NextDouble();
            }

            return colores;
        }

        public void Porcentajes()
        {
            string res = "s";

            Console.WriteLine("Solo valores del 0 al 100.");
            do
            {
                Console.Write("Ingrese un porcentaje: ");
                rebanadas.Add(double.Parse(Console.ReadLine()) / 100);

                if (rebanadas.Sum() == 1 || rebanadas.Sum() > 1)
                {
                    Console.WriteLine("Ha llegado al 100%.\n Dibujando círculo.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("\nDesea ingresar otro valor? s/n");
                res = Console.ReadLine();
                if (res.Equals("n"))
                    break;


            } while (res.Equals("s"));

            //Circulo();
        }

        public void Circulo()
        {
            GL.PointSize(2f);
            GL.Begin(PrimitiveType.Points);
            GL.Color3(0.6f, 0.6f, 0.6f);

            double tmp = 0;

            for (int i = 0; i < rebanadas.Count(); i++)
            {
                GL.Color3(colores[0], colores[1], colores[2]);
                for (double percent = tmp; percent <= (Math.PI * 2) * rebanadas[i]; percent += 0.001)
                {
                    GL.Vertex2(Math.Cos(percent), Math.Sin(percent));
                }
                tmp = (Math.PI * 2) * rebanadas[i];
            }

            GL.End();
        }
    }
}
