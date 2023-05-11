using System;

namespace Dibujo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Screen window = new Screen(600, 600);
            window.Run();
        }
    }
}