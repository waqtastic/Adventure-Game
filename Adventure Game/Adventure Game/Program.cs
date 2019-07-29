using System;

namespace AdventureGame
{
	class Program
	{
		static void Main()
		{
			string CharacterName = "Pless Haldur";

			Console.WriteLine("Welcome to Jetbuilders!");
			Console.WriteLine("Our motto is: Create. Construct. Conclude.");
			Console.WriteLine("Enter your name:");

			CharacterName = Console.ReadLine();

			Console.WriteLine(CharacterName + "? Well no one gets to choose their own name I guess. Welcome aboard!");
		}
	}
}

