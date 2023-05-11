using System;
using System.Collections.Generic;

namespace Galagagagaga
{
    public class Collider
    {
        public Collider()
        {
        }

        public void ChecarColision(List<Poligono> listaBalas, List<Poligono> listaEnemigos)
        {
            List<int> tempEnemigos = new List<int>();
            List<int> tempBalas = new List<int>();

            foreach (Poligono enemigo in listaEnemigos)
            {
                foreach (var bala in listaBalas)
                {
                    double diferenciaX = enemigo.GetCoord().X - bala.GetCoord().X;
                    double diferenciaY = enemigo.GetCoord().Y - bala.GetCoord().Y;
                    double distancia = Math.Sqrt(diferenciaX * diferenciaX + diferenciaY * diferenciaY);

                    if (distancia < enemigo.GetRadio() + bala.GetRadio())
                    {
                        Console.WriteLine("COLISION!!!!");
                        tempEnemigos.Add(listaEnemigos.IndexOf(enemigo));
                        tempBalas.Add(listaBalas.IndexOf(bala));
                    }
                }
            }

            foreach (var item in tempBalas)
            {
                listaBalas.RemoveAt(item);
            }

            foreach (var item in tempEnemigos)
            {
                listaEnemigos.RemoveAt(item);
            }
        }
    }
}
