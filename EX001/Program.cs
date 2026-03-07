using System;
namespace CursoBalta
{
	class Program
	{
		static void Main(string[] args)
		{
			int inteiro = 100;
			float real = 25.5f;

			/* real = inteiro;  100.0f
			 Console.WriteLine(real); */

			real = inteiro;
			inteiro = (int)real; 
			Console.WriteLine(real);
			
		}
	}
}