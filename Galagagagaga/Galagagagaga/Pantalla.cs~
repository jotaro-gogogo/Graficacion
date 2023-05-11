using System;
using System.Drawing;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Galagagagaga
{
    public class Pantalla: GameWindow
    {
        Extras stars;

        Poligono main;
        Poligono bala;
        Punto pMain = new Punto(300, 30);
        Punto pBala = new Punto(-10, 55);

        Poligono enemigo;
        Punto pEnemigo = new Punto(150, 500);
        Poligono enemigo2;
        Punto pEnemigo2 = new Punto(250, 500);
        Poligono enemigo3;
        Punto pEnemigo3 = new Punto(350, 500);
        Poligono enemigo4;
        Punto pEnemigo4 = new Punto(450, 500);

        Poligono enemigo5;
        Punto pEnemigo5 = new Punto(100, 400);
        Poligono enemigo6;
        Punto pEnemigo6 = new Punto(200, 400);
        Poligono enemigo7;
        Punto pEnemigo7 = new Punto(300, 400);
        Poligono enemigo8;
        Punto pEnemigo8 = new Punto(400, 400);
        Poligono enemigo9;
        Punto pEnemigo9 = new Punto(500, 400);

        private List<Poligono> listaEnemigos = new List<Poligono>();
        private List<Poligono> listaBalas = new List<Poligono>();
        private List<int> listaTemp = new List<int>();

        Collider colisionador = new Collider();

        public Pantalla(int ancho, int alto): base(ancho, alto)
        {
            Title = "Galagagaga";
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0, 600, 0, 600, -1, 1);

            stars = new Extras();
            main = new Poligono(pMain, 3, 25);

            listaEnemigos.Add(enemigo = new Poligono(pEnemigo, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo2 = new Poligono(pEnemigo2, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo3 = new Poligono(pEnemigo3, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo4 = new Poligono(pEnemigo4, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo5 = new Poligono(pEnemigo5, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo6 = new Poligono(pEnemigo6, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo7 = new Poligono(pEnemigo7, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo8 = new Poligono(pEnemigo8, 5, 15, 1, 0, 0.5));
            listaEnemigos.Add(enemigo9 = new Poligono(pEnemigo9, 5, 15, 1, 0, 0.5));
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            main.SetPoligono(pMain);

            foreach (Poligono _enemigo  in listaEnemigos)
            {
                _enemigo.Draw();
            }

            foreach (Poligono _bala in listaBalas)
            {
                _bala.Draw();
                _bala.centro.Y += 10;
            }

            colisionador.ChecarColision(listaBalas, listaEnemigos);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //bgMusic.Play();
            stars.Estrellas();
            main.Draw();
            SwapBuffers();
        }

        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            pMain.X = e.X;
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            pBala.X = e.X;
            pBala.Y = 55;
            listaBalas.Add(bala = new Poligono(pBala, 8, 5, 1, 0, 0));
        }
    }
}
