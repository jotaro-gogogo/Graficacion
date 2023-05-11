using System;

namespace Cuadratica
{
    // Pedir punto de inicio y punto final
    public class Matriz
    {
        char[,] matriz;
        Punto inicio;
        Punto final;

        public Matriz()
        {
            matriz = new char[20, 20];
            inicio = new Punto();
            final = new Punto();

            LlenaMatriz();
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
                for (int j = 0; j < 20; j++) Console.Write("{0} ", matriz[j, i]);
                Console.WriteLine(); // Automaticamente imprime un salto de linea
            }
        }

        public void DrawDot(Punto punto)
        {
            matriz[punto.X, punto.Y] = 'X';
        }
    }
}
