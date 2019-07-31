using System;

namespace AdventureGame
{
	public static class Game
	{
		
		static string FCharacterName = "Pless";
		static string LCharacterName = "Haldur";
		
		public static void StartGame()
		{
			Dialogue("Welcome to JETBUILDERS!" , "white");
			Dialogue("Our motto is: CREATE. CONSTRUCT. CONCLUDE." , "cyan");
			NameCharacter();
		}

		static void NameCharacter()
		{
			Console.WriteLine("Enter your name first name:");
			FCharacterName = Console.ReadLine();
			Console.WriteLine("Enter your last name:");
			LCharacterName = Console.ReadLine();
			Console.WriteLine("Welcome aboard " + FCharacterName +  "! I'm sure you'll do just fine.");
			Console.ReadKey();
			Console.Clear();
			Introduction();
		}

		static void Introduction()
		{
			Console.WriteLine("You are in an office, on your first day. You are approached by your new boss, ");
			Console.ReadKey();
			Dialogue("\"Ah! " + FCharacterName + "! Good to see you here bright and early. Your desk is over there\"", "cyan");
			Console.ReadKey();
			Console.WriteLine("You see the desk he pointed at, above it is a poster with a jet on it along with the company motto:");
			Console.ReadKey();
			Dialogue("CREATE. CONSTRUCT. CONCLUDE.", "Yellow");
			Console.ReadKey();
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

	