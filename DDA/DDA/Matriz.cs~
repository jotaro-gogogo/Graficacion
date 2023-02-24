using System;

namespace DDA
{
    // Pedir punto de inicio y punto final
    public class Matriz
    {
        char[,] matriz;
        Punto inicio;
        Punto final;
        //Pendiente m;

        public Matriz()
        {
            matriz = new char[20, 20];
            inicio = new Punto();
            final = new Punto();
            //m = new Pendiente();

            LlenaMatriz();
            //Puntos();
        }

        private void LlenaMatriz()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                    matriz[i, j] = '-';
            }
        }

        public void MuestraMatriz()
        {
            for (int i = 19; i >= 0; i--)
            {
                Console.Write("{0}\t", i);

                for (int j = 0; j < 20; j++) Console.Write("{0} ", matriz[j, i]);

                Console.WriteLine(); // Automaticamente imprime un salto de linea
            }

            Console.Write("\t");
            for (int j = 0; j < 20; j++) Console.Write("{0} ", j);
        }

        public void DrawLine(Punto punto)
        {
            matriz[punto.X, punto.Y] = 'X';
        }
    }
}
