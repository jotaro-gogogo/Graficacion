using System;

namespace DibujoLibre
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pantalla screen = new Pantalla(1200, 600);
            screen.Run();
        }
    }
}
