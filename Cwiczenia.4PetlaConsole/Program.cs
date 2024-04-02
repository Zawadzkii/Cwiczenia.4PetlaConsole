using System;

class Program
{
	static void Main()
	{
		Console.Write("Podaj liczbę całkowitą: ");
		int n = int.Parse(Console.ReadLine());

		int number = 1;
		for (int i = 1; i <= n; i++)
		{
			for (int j = 1; j <= i; j++)
			{
				Console.Write($"{number} ");
				number++;
			}
			Console.WriteLine();
		}
	}
}