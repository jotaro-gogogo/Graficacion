using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace DibujoLibre
{
    public class Pantalla: GameWindow
    {
        // Sol
        Punto pSol = new Punto(0, 600);
        Poligono sol;

        // Polígonos de nube
        Punto pIzquierda = new Punto(500, 500);
        Punto pCentro = new Punto(600, 520);
        Punto pDerecha = new Punto(700, 500);
        Poligono nubeIzquierda;
        Poligono nubeCentro;
        Poligono nubeDerecha;
        // Base de la nube
        Punto pRect1 = new Punto(500, 450);
        Punto pRect2 = new Punto(700, 530);
        Cuadrilatero nubeBase;

        // Montañas
        Punto pMount1 = new Punto(900, 320);
        Punto pNieve1 = new Punto(900, 500);
        Poligono mount1;
        Poligono nieve1;
        Punto pMount2 = new Punto(1100, 320);
        Punto pNieve2 = new Punto(1100, 500);
        Poligono mount2;
        Poligono nieve2;
        Punto pMount3 = new Punto(1000, 310);
        Poligono mount3;
        Punto pMount4 = new Punto(1170, 330);
        Poligono mount4;

        // Lok0motora
        Punto pLoko1 = new Punto(800, 80);
        Punto pLoko2 = new Punto(1100, 280);
        Cuadrilatero lokomotora;

        Punto pVagon1 = new Punto(440, 80);
        Punto pVagon2 = new Punto(760, 280);
        Cuadrilatero vagon;
        // Pasajeros y ventanas

        Punto pCabus1 = new Punto(100, 80);
        Punto pCabus2 = new Punto(400, 280);
        Cuadrilatero cabus;
        // Pasajeros y ventanas

        // Trompa de lok0motora
        Punto pTrompa1 = new Punto(1100, 80);
        Punto pTrompa2 = new Punto(1190, 220);
        Cuadrilatero trompa;

        // Caseta de conductor
        Punto pCaseta1 = new Punto(820, 280);
        Punto pCaseta2 = new Punto(950, 330);
        Cuadrilatero caseta;
        Punto pTecho1 = new Punto(810, 330);
        Punto pTecho2 = new Punto(960, 390);
        Cuadrilatero techo;
        Punto pVentana1 = new Punto(910, 310);
        Punto pVentana2 = new Punto(950, 330);
        Cuadrilatero ventana;

        // Chimenea
        Punto pCaseta2_1 = new Punto(1000, 280);
        Punto pCaseta2_2 = new Punto(1070, 330);
        Cuadrilatero caseta2;
        Punto pTecho2_1 = new Punto(990, 330);
        Punto pTecho2_2 = new Punto(1080, 360);
        Cuadrilatero techo2;

        // Uniones de los vagones
        Punto pUnion1_1 = new Punto(760, 90);
        Punto pUnion1_2 = new Punto(800, 120);
        Cuadrilatero union1;
        Punto pUnion2_1 = new Punto(400, 90);
        Punto pUnion2_2 = new Punto(440, 120);
        Cuadrilatero union2;
        Punto pUnionF_1 = new Punto(40, 90);
        Punto pUnionF_2 = new Punto(100, 120);
        Cuadrilatero unionFinal;

        // Remolque de cabus
        Punto pBaseRem1 = new Punto(50, 120);
        Punto pBaseRem2 = new Punto(70, 130);
        Cuadrilatero baseRemolque;
        Punto pRem = new Punto(60, 140);
        Poligono remolque;

        double r, g, b;

        public Pantalla(int ancho, int alto): base(ancho, alto)
        {
            Title = "Lok0motora";
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.SkyBlue);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0, 1200, 0, 600, -1, 1);

            sol = new Poligono(pSol, 64, 200, 1, 1, 0);

            nubeIzquierda = new Poligono(pIzquierda, 32, 50);
            nubeCentro = new Poligono(pCentro, 32, 70);
            nubeDerecha = new Poligono(pDerecha, 32, 50);
            nubeBase = new Cuadrilatero(pRect1, pRect2);

            mount1 = new Poligono(pMount1, 3, 220, 0, 0.5, 0);
            nieve1 = new Poligono(pNieve1, 3, 40);
            mount2 = new Poligono(pMount2, 3, 220, 0.3450, 0.1764, 0.05490);
            nieve2 = new Poligono(pNieve2, 3, 40);
            mount3 = new Poligono(pMount3, 3, 180, 0, 0.3, 0);
            mount4 = new Poligono(pMount4, 3, 180, 0.3843, 0.3843, 0.3843);

            r = g = b = 0.03529;
            lokomotora = new Cuadrilatero(pLoko1, pLoko2, r, g, b);
            trompa = new Cuadrilatero(pTrompa1, pTrompa2, 1, 0, 0);
            caseta = new Cuadrilatero(pCaseta1, pCaseta2, r, g, b);
            techo = new Cuadrilatero(pTecho1, pTecho2, 1, 0, 0);
            ventana = new Cuadrilatero(pVentana1, pVentana2);
            caseta2 = new Cuadrilatero(pCaseta2_1, pCaseta2_2, r, g, b);
            techo2 = new Cuadrilatero(pTecho2_1, pTecho2_2, r, g, b);
            vagon = new Cuadrilatero(pVagon1, pVagon2, r, g, b);
            cabus = new Cuadrilatero(pCabus1, pCabus2, r, g, b);

            r = g = b = 0.6823;
            union1 = new Cuadrilatero(pUnion1_1, pUnion1_2, r, g, b);
            union2 = new Cuadrilatero(pUnion2_1, pUnion2_2, r, g, b);
            unionFinal = new Cuadrilatero(pUnionF_1, pUnionF_2, r, g, b);

            r = g = b = 0.1490;
            baseRemolque = new Cuadrilatero(pBaseRem1, pBaseRem2, r, g, b);
            remolque = new Poligono(pRem, 16, 15, r, g, b);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            sol.Draw();

            nubeIzquierda.Draw();
            nubeCentro.Draw();
            nubeDerecha.Draw();
            nubeBase.Draw();

            mount3.Draw();
            mount4.Draw();
            mount1.Draw();
            nieve1.Draw();
            mount2.Draw();
            nieve2.Draw();

            lokomotora.Draw();
            trompa.TrompaDraw();
            caseta.Draw();
            techo.TriDraw();
            ventana.Draw();
            caseta2.Draw();
            techo2.TriDraw();

            vagon.Draw();
            cabus.Draw();

            union1.Draw();
            union2.Draw();
            unionFinal.Draw();
            baseRemolque.Draw();
            remolque.Draw();

            SwapBuffers();
        }
    }
}
