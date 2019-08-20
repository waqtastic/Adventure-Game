using System;
using System.Threading;

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
			Console.WriteLine("Welcome aboard " + FCharacterName + " " + LCharacterName + "! I'm sure you'll do just fine.");
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
			Console.WriteLine("You see the desk he pointed at, above it is a poster with a jet \non it along with the company motto:");
			Console.ReadKey();
			Dialogue("CREATE. CONSTRUCT. CONCLUDE.", "Yellow");
			Console.ReadKey();
			Console.WriteLine("As you look around you notice there are jets everywhere, one of \nthe rooms looks like it was taken straight out of a \nLockheed SR-71 Blackbird");
			Console.WriteLine("Dang, how much did they spend to get that?");
			Console.ReadKey();
			Console.WriteLine("You sit down at your desk and turn on your computer, when you \nrealise you haven't been assigned anything to do.");
			Console.WriteLine("What do you do " + FCharacterName + "?");
			Console.ReadKey();
			Console.Clear();
			Choice();
		}

		static void Choice()
		{

			string input = "";
			Console.WriteLine("You could get a cup of coffee, or you could ask someone what you should be doing");
			Console.ReadKey();
			Console.WriteLine("A: Go get a cup of coffee first");
			Console.WriteLine("B: Ask someone what it is you should be doing");
			Console.WriteLine("Enter your choice:");
			input = Console.ReadLine();
			input = input.ToUpper();
			if (input == "A")
			{
				Console.Clear();
				Console.WriteLine("You go to the kitchen area and see some people milling around a coffee machine \nyou grab a cup and push the button to vend a fresh brew");
				Console.ReadKey();
				Console.WriteLine("You see some other people milling around the office. Do you talk to them or go \nback to your desk?");
				Console.WriteLine("A: Introduce yourself to the others at the office");
				Console.WriteLine("B: Go back to your desk");
				Console.ReadKey();
				input = Console.ReadLine();
				input = input.ToUpper();
				if (input == "A")
				{
					Console.Clear();
					Console.WriteLine("You turn to one of the other people in the area and introduce yourself");
					Console.ReadKey();
					Dialogue("Hello, my name is " + FCharacterName + " I just started today", "green");
					Console.ReadKey();
					Console.WriteLine("A sleepy looking guy with a cup of coffee looks at you blankly for a moment before \nrealising that you were talking to them");
					Console.ReadKey();
					Dialogue("Hmm? Oh I thought you were talking to Jen", "Yellow");
					Console.ReadKey();
					Console.WriteLine("He points vaguely behind him. You see there's no one there");
					Console.ReadKey();
					Dialogue("I'm Bob. So you're new huh? Welcome to the grindstone. Got your first assignment yet?", "Yellow");
					Console.ReadKey();
					Console.WriteLine("You shake your head");
					Dialogue("You should talk to Greg then, he'll assign you something", "Yellow");
					Console.ReadKey();
					Console.WriteLine("He points you towards a guy in a checkered shirt, who is stood at a desk");
					Dialogue("Thanks Bob, nice to meet you by the way", "Green");
					Console.ReadKey();
					Console.WriteLine("Bob nods in acknowledgement and wanders off to his desk");
					Console.ReadKey();
					Console.WriteLine("You decide to go see the person who hired you, Greg");
					Console.ReadKey();
					Dialogue("\"Hey Greg, it's my first day. What should I do?\"", "Green");
					Console.ReadKey();
					Dialogue("\"Oh hey " + FCharacterName + "! Welcome aboard. Well since you're just starting out we thought \nwe'd give you a simple project\"", "Cyan");
					Console.ReadKey();
					Dialogue("\"Great, what do you want me to do?\"", "Green");
					Console.ReadKey();
					Console.WriteLine("Greg hands you a knife");
					Console.ReadKey();
					Dialogue("\"I need you to go into the basement and shank the bugs down there\"", "Cyan");
					Console.ReadKey();
					Dialogue("\"I thought this was a software company?\"", "Green");
					Console.ReadKey();
					Dialogue("\"Yes, and it's your job to get rid of those bugs!\"", "Cyan");
					Console.WriteLine("You are handed a pointy piece of metal, and Greg points you towards an ominous looking door. \nYou're not sure what you've gotten yourself into, but it looks like you have a task at least");
					Dialogue("And don't forget to mark it \"done\" in Jira afterwards!", "Cyan");
					BugQuest();
				}
				else
				{
					Console.Clear();
					Console.WriteLine("You decide to head back to your desk and set up your laptop");
					Console.ReadKey();
					Console.WriteLine("You set up your email account and see that it has one called \"First assignment\" \non it. Looks like they've already got something \nin mind for you.");
					Console.ReadKey();
					Console.WriteLine("You open the email and it has instructions to... grab a knife and go to the \nbasement to kill some bugs");
					Console.ReadKey();
					Console.WriteLine("Are they serious?");
					Console.ReadKey();
					Console.WriteLine("As you scroll down you see that it says \"Yes, I'm serious\"");
					Console.ReadKey();
					Console.WriteLine("You get up from your desk and grab a knife from the kitchen. \nThen you head towards the basement");
					BugQuest();
				}


			}
			else
			{
				Console.WriteLine("You decide to go see the person who hired you, Greg");
				Console.ReadKey();
				Dialogue("\"Hey Greg, it's my first day. What should I do?\"", "Green");
				Console.ReadKey();
				Dialogue("\"Oh hey " + FCharacterName + "! Welcome aboard. Well since you're just starting out we thought \nwe'd give you a simple project\"", "Cyan");
				Console.ReadKey();
				Dialogue("\"Great, what do you want me to do?\"", "Green");
				Console.ReadKey();
				Console.WriteLine("Greg hands you a knife");
				Console.ReadKey();
				Dialogue("\"I need you to go into the basement and shank the bugs down there\"", "Cyan");
				Console.ReadKey();
				Dialogue("\"I thought this was a software company?\"", "Green");
				Console.ReadKey();
				Dialogue("\"Yes, and it's your job to get rid of those bugs!\"", "Cyan");
				Console.WriteLine("You are handed a pointy piece of metal, and Greg points you towards an ominous looking door. \nYou're not sure what you've gotten yourself into, but it looks like you have a task at least");
				Dialogue("And don't forget to mark it \"done\" in Jira afterwards!", "Cyan");
				BugQuest();
			}

		}

		static void BugQuest()
		{
			Console.Clear();
			Console.ReadKey();
			Console.WriteLine("You look at the knife, on closer inspection it has \"C#\" written on it. \nYou touch the blade and find see that it is infact sharp. You open the ominous\n door, it's dark in here.");
			Console.ReadKey();
			Console.WriteLine("You head down the stairs into the gloomy basement. It's difficult to see down \nhere");
			Console.ReadKey();
			Console.Clear();
			ChoiceBugQuest();

		}

		private static void ChoiceBugQuest()
		{
			string input = "";
			Console.Clear();
			Console.WriteLine("You could try finding a light switch in here, or you could just use the torch on your phone");
			Console.ReadKey();
			Console.WriteLine("A: Search for the light switch");
			Console.WriteLine("B: Use the torch on your phone");
			Console.WriteLine("Enter your choice:");
			input = Console.ReadLine();
			input = input.ToUpper();
			if (input == "A")
			{
				Console.WriteLine("You decide to look for the light switch, there's got to be one somewhere.");
				Console.ReadKey();
				Console.WriteLine("You search the dimly lit area near the entrance for a light switch without much luck");
				Console.ReadKey();
				Console.WriteLine("You stray further and further away from the light, you find a switch. You flip \nit and nothing happens");
				Console.ReadKey();
				Console.WriteLine("A buzzing noise from above echoes through the basement, followed by a \"tink\" \nas a dull yellow flash momentarily stuns you");
				Console.ReadKey();
				Console.WriteLine("On the second flash you see the bug they mentioned infront of you");
				BugFight();
			}
			else
			{
				
			}

		}

		private static void BugFight()
		{
			Console.Clear();
			Console.ReadKey();
			Spider();
			Console.ReadKey();
			Dialogue("Psst hey kid wanna buy some drugs?", "Red");
		}

		private static void Spider()
		{
			Console.WriteLine(@"
  /^\ ___ /^\
 //^\(o o)/^\\
/'<^~``~''~^>`\

");


		}


			//change this into a switch statement at some point

			public static void Dialogue(string message, string color)

		{
			if (color == "red")
			{ Console.ForegroundColor = ConsoleColor.Red; }
			else if (color == "green")
			{ Console.ForegroundColor = ConsoleColor.Green; }
			else if (color == "yellow")
			{ Console.ForegroundColor = ConsoleColor.Yellow; }
			else if (color == "cyan")
			{ Console.ForegroundColor = ConsoleColor.Cyan; }
			else if (color == "blue")
			{ Console.ForegroundColor = ConsoleColor.Blue; }
			else
			{ Console.ForegroundColor = ConsoleColor.White; }

			Console.WriteLine(message);
			Console.ResetColor();
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
}

	