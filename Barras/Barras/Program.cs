﻿using System;

namespace Barras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pantalla screen = new Pantalla(600, 600);

            screen.Run();
        }
    }
}