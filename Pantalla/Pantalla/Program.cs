using System;
using System.Drawing;

namespace Pantalla
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Pantalla ventana = new Pantalla (600, 600);
			ventana.Run();
		}
	}
}
