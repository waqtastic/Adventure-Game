using System;

namespace AdventureGame
{
	public static class Game
	{

		static string FCharacterName = "Pless";
		static string LCharacterName = "Haldur";

		public static void StartGame()
		{
			Dialogue("Welcome to JETBUILDERS!", "white");
			Dialogue("Our motto is: CREATE. CONSTRUCT. CONCLUDE.", "cyan");
			NameCharacter();
		}

		static void NameCharacter()
		{
			Console.WriteLine("Enter your name first name:");
			FCharacterName = Console.ReadLine();
			Console.WriteLine("Enter your last name");
			LCharacterName = Console.ReadLine();
			Console.WriteLine("Welcome aboard " + FCharacterName + " " +  LCharacterName + "! I'm sure you'll do just fine.");
			Console.ReadKey();
			Console.Clear();
			Introduction();
		}

		static void Introduction()
		{
			Console.WriteLine("You are in an office, on your first day. You are approached by \nyour new boss, Ricardo");
			Console.ReadKey();
			Dialogue("\"Ah! " + FCharacterName + "! Good to see you here bright and early. \nYour desk is over there\"", "cyan");
			Console.ReadKey();
			Console.WriteLine("You see the desk he pointed at, above it is a poster with a jet\n on it along with the company motto:");
			Console.ReadKey();
			Dialogue("CREATE. CONSTRUCT. CONCLUDE.", "Yellow");
			Console.ReadKey();
			Console.WriteLine("AS you look around you notice there are jets everywhere, one of\n the rooms looks like it was taken straight out of a \nLockheed SR-71 Blackbird");
			Console.WriteLine("Dang, how much did they spend to get that?");
			Console.ReadKey();
			Console.WriteLine("You sit down at your desk and turn on your computer, when you \nrealise you haven't been assigned anything to do.");
			Console.WriteLine("What do you do?");
			Console.ReadKey();
		}

		static void Choice()
		{
			string input = "";
			Console.WriteLine("A: Go get a cup of coffee first");
			Console.WriteLine("B: Ask someone what it is you should be doing");
			input = Console.ReadLine();
		}

		//change this into a switch statement at some point
		
		static void Dialogue(string message, string color)

		{
			if (color == "red")
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

	