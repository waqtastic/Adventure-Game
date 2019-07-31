using System;

namespace AdventureGame
{
	public static class Game
	{
		
		static string CharacterName = "Pless Haldur";
		
		public static void StartGame()
		{
			Dialogue("Welcome to JETBUILDERS!" , "white");
			Dialogue("Our motto is: CREATE. CONSTRUCT. CONCLUDE." , "cyan");
			NameCharacter();
		}

		static void NameCharacter()
		{
			Console.WriteLine("Enter your name:");
			CharacterName = Console.ReadLine();

			Console.WriteLine("Welcome aboard " + CharacterName +  "! I'm sure you'll do just fine.");
		}

		static void Dialogue(string message, string color)
		{
			if (color== "red")
			{ Console.ForegroundColor = ConsoleColor.Red; }
			else if (color == "green")
			{ Console.ForegroundColor = ConsoleColor.Green; }
			else if (color == "yellow")
			{ Console.ForegroundColor = ConsoleColor.Yellow; }
			else if (color == "cyan")
			{ Console.ForegroundColor = ConsoleColor.Cyan; }
			else
			{ Console.ForegroundColor = ConsoleColor.White; }

			Console.WriteLine(message);
			Console.ResetColor();
		}

		
	}
	
	class Item
	{

	}
	class Program
	{
		static void Main()
		{
			Game.StartGame();
			Console.Read();
		}
	}

}

/*string charactername = "pless haldur";

console.writeline("welcome to jetbuilders!");
			console.writeline("our motto is: create. construct. conclude.");
			console.writeline("enter your name:");

			charactername = console.readline();

			console.writeline(charactername + "? well no one gets to choose their own name i guess. welcome aboard!");
			*/

	