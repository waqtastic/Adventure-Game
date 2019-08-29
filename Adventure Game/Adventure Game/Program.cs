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
			Console.WriteLine("You are in an office, on your first day. You are approached by \nyour new boss, Ricardo.");
			Console.ReadKey();
			Dialogue("\"Ah! " + FCharacterName + "! Good to see you here bright and early. \nYour desk is over there\"", "cyan");
			Console.WriteLine("You see the desk he pointed at, above it is a poster with a jet \non it along with the company motto:");
			Console.ReadKey();
			Dialogue("CREATE. CONSTRUCT. CONCLUDE.", "yellow");
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
				ChoiceA();
			}
			else if (input == "B")
			{
				Console.WriteLine("You decide to go see the person who hired you, Greg");
				Console.ReadKey();
				Dialogue("\"Hey Greg, it's my first day. What should I do?\"", "green");
				Dialogue("\"Oh hey " + FCharacterName + "! Welcome aboard. Well since you're just starting out we thought \nwe'd give you a simple project\"", "cyan");
				Dialogue("\"Great, what do you want me to do?\"", "green");
				Console.WriteLine("Greg hands you a knife");
				Console.ReadKey();
				Dialogue("\"I need you to go into the basement and shank the bugs down there\"", "cyan");
				Dialogue("\"I thought this was a software company?\"", "green");
				Dialogue("\"Yes, and it's your job to get rid of those bugs!\"", "cyan");
				Console.WriteLine("You are handed a pointy piece of metal, and Greg points you towards an ominous looking door. \nYou're not sure what you've gotten yourself into, but it looks like you have a task at least");
				Dialogue("\"And don't forget to mark it \"done\" in Jira afterwards!\"", "cyan");
				ChoiceBugQuest();
			}
			else
			{
				Console.WriteLine("Pick from one of the choices:");
				Console.ReadKey();
				Console.Clear();
				Choice();
			}
		}
		public static void ChoiceA() //this the one where choices get screwed up because it just ignores the first character you write. So if you type A and then push enter it will ignore it and assume its blank, but if you push space or anything else before your choice it works fine.
		{
			string input = "";
			Console.Clear();
			Console.WriteLine("You go to the kitchen area and see some people milling around a coffee machine \nyou grab a cup and push the button to vend a fresh brew.");
			Console.ReadKey();
			Console.WriteLine("You see some other people milling around the office. Do you talk to them or go \nback to your desk?");
			Console.WriteLine("A: Introduce yourself to the others at the office");
			Console.WriteLine("B: Go back to your desk");
			Console.WriteLine("Enter your choice:");
			Console.ReadKey();
			input = Console.ReadLine();
			input = input.ToUpper();
			if (input == "A")
			{
				Console.Clear();
				Console.WriteLine("You turn to one of the other people in the area and introduce yourself");
				Console.ReadKey();
				Dialogue("\"Hello, my name is " + FCharacterName + ", I just started today\"", "green");
				Console.WriteLine("A sleepy looking guy with a cup of coffee looks at you blankly for a moment \nbefore realising that you were talking to them");
				Console.ReadKey();
				Dialogue("\"Hmm? Oh I thought you were talking to Jen\"", "yellow");
				Console.WriteLine("He points vaguely behind him. You see there's no one there");
				Console.ReadKey();
				Dialogue("\"I'm Bob. So you're new huh? Welcome to the grindstone. Got your first \nassignment yet?\"", "yellow");
				Console.WriteLine("You shake your head");
				Dialogue("\"You should talk to Greg then, he'll assign you something\"", "yellow");
				Console.WriteLine("He points you towards a guy in a checkered shirt, who is stood at a desk");
				Dialogue("\"Thanks Bob, nice to meet you by the way\"", "green");
				Console.WriteLine("Bob nods in acknowledgement and wanders off to his desk");
				Console.ReadKey();
				Console.WriteLine("You decide to go see the person who hired you, Greg");
				Console.ReadKey();
				Dialogue("\"Hey Greg, it's my first day. What should I do?\"", "green");
				Dialogue("\"Oh hey " + FCharacterName + "! Welcome aboard. Well since you're just starting out we thought \nwe'd give you a simple project\"", "cyan");
				Dialogue("\"Great, what do you want me to do?\"", "green");
				Console.WriteLine("Greg hands you a knife");
				Console.ReadKey();
				Dialogue("\"I need you to go into the basement and shank the bugs down there\"", "cyan");
				Dialogue("\"I thought this was a software company?\"", "green");
				Dialogue("\"Yes, and it's your job to get rid of those bugs!\"", "cyan");
				Console.WriteLine("You are handed a pointy piece of metal, and Greg points you towards an ominous looking door. \nYou're not sure what you've gotten yourself into, but it looks like you have a task at least");
				Dialogue("\"And don't forget to mark it \"done\" in Jira afterwards!\"", "cyan");
				ChoiceBugQuest();
			}
			else if (input == "B")
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
				ChoiceBugQuest();
			}
			else
			{
				Console.WriteLine("Pick from one of the choices");
				Console.ReadKey();
				Console.Clear();
				ChoiceA();
			}
		}


		private static void ChoiceBugQuest()
		{
			string input = "";
			Console.Clear();
			Console.ReadKey();
			Console.WriteLine("You look at the knife, on closer inspection it has \"C#\" written on it.\nYou touch the blade and find see that it is infact sharp. You open the ominous \ndoor, it's dark in here.");
			Console.ReadKey();
			Console.WriteLine("You head down the stairs into the gloomy basement. It's difficult to see down \nhere");
			Console.ReadKey();
			Console.WriteLine("You could try finding a light switch in here, or you could just use the torch \non your phone");
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
			else if (input == "B")
			{
				Console.WriteLine("You use the torch on your phone to light the area up");
				Console.ReadKey();
				Console.WriteLine("In front of you, you see a giant spider!");
				Console.ReadKey();
				BugFight();
			}
			else
			{
				Console.WriteLine("Pick from one of the choices:");
				Console.ReadKey();
				Console.Clear();
				ChoiceBugQuest();
			}

		}

		private static void BugFight()
		{
			string input = "";
			Console.Clear();
			Console.ReadKey();
			Spider();
			Console.ReadKey();
			Console.WriteLine("You are faced with the biggest spider you've ever seen.\nFrozen from shock, a few moments pass before you hear:");
			Console.ReadKey();
			Dialogue("\"Psst hey kid wanna buy some drugs?\"", "red");
			Console.WriteLine("This seems to be the bug they were talking about. I guess \nyou have to deal with it somehow");
			Console.ReadKey();
			Console.WriteLine("A: Shank it with your C# knife");
			Console.WriteLine("B: Call the cops");
			Console.WriteLine("C: Nope right out of there");
			input = Console.ReadLine();
			input = input.ToUpper();
			if (input == "A")
			{
				Console.WriteLine("You take out your knife, and decide to see how sharp it really is");
				Console.ReadKey();
				Dialogue("\"Hey what are you doing with that knife\"", "red");
				Console.WriteLine("You close your eyes and thrust your knife towards the spider!");
				Console.ReadKey();
				Console.Clear();
				Spider();
				Console.ReadKey();
				Console.Clear();
				SpiderDead();
				Console.ReadKey();
				Dialogue("\"Don't... forget... to mark it as done in Jira\"", "red");
				Console.Clear();
				QuestComplete();
			}
			else if (input == "B")
			{
				Console.WriteLine("Did that spider just offer you drugs?");
				Console.ReadKey();
				Console.WriteLine("You decide to call the cops, afterall, drugs are illegal");
				Console.ReadKey();
				Dialogue("\"You're calling the popo?! Screw this I'm out!\"", "red");
				Console.WriteLine("you see the spider hurriedly pack a suitcase full of \nwebbing and scurry off into the vents");
				Console.ReadKey();
				Console.WriteLine("I guess you're done with the quest. You hear a voice \necho through the vents as you turn to leave");
				Dialogue("\"Don't forget to mark it as done in Jira\"", "red");
				Console.Clear();
				QuestComplete();

			}
			else if (input == "C")
			{
				Console.WriteLine("At the sight of the oversized apparently TALKING \nspider you decide to back away right up the stairs you just came down");
				Console.ReadKey();
				Dialogue("\"That's right, walk away! And make sure you let the others \nknow that this is spider turf\"", "red");
				QuestFailed();

			}
			else
			{
				Console.WriteLine("Pick from one of the choices");
				Console.ReadKey();
				Console.Clear();
				BugFight();
			}
		}
		private static void QuestComplete()
		{

		}
		private static void QuestFailed()
		{
			Console.Clear();
			Console.WriteLine("You head back upstairs and bump into the Greg, the guy who hired you");
			Console.ReadLine();
			Dialogue("\"I can't do it, this isn't what I signed up for!\"", "green");
			Console.WriteLine("Greg doesn't appear surprised by your outburst");
			Console.ReadLine();
			Dialogue("\"Well I can't say I didn't expect this, not everyone is cut out to be a developer\"", "cyan");
			Console.WriteLine("He walks you over to his desk, and shuffles about with paperwork for a moment");
			Console.ReadLine();
			Dialogue("\"I don't think you're a good fit at this company, so I'm afraid I'm going to have to ask you to sign that\"", "cyan");
			Console.WriteLine("It's an acknowledgement of termination. You hastily sign \nit so you can leave and find a less insane job. As you're \nreading through the contract something catches your eye, a \"Cannon Clause\"");
			Console.ReadLine();
			Dialogue("\"What's this Cannon Clause about?\"", "green");
			Console.WriteLine("Greg pulls a lever that was obscured by his monitor and \nthe floor underneath you vanishes");
			Console.ReadLine();
			Console.WriteLine("You find yourself in the barrel of a cannon");
			Dialogue("\"Should have read the contract!\"", "cyan");
			Dialogue("\"Oh shi-\"", "green");
			Thread.Sleep(1000);
			Console.Clear();
			Death();
		}

		private static void Death()
		{
			Typewrite(@"
▓██   ██▓ ▒█████   █    ██    ▓█████▄  ██▓▓█████ ▓█████▄ 
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▒██▀ ██▌▓██▒▓█   ▀ ▒██▀ ██▌
  ▒██ ██░▒██░  ██▒▓██  ▒██░   ░██   █▌▒██▒▒███   ░██   █▌
  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░▓█▄   ▌░██░▒▓█  ▄ ░▓█▄   ▌
  ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░▒████▓ ░██░░▒████▒░▒████▓ 
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒▒▓  ▒ ░▓  ░░ ▒░ ░ ▒▒▓  ▒ 
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░     ░ ▒  ▒  ▒ ░ ░ ░  ░ ░ ▒  ▒ 
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░     ░ ░  ░  ▒ ░   ░    ░ ░  ░ 
 ░ ░         ░ ░     ░           ░     ░     ░  ░   ░    
 ░ ░                           ░                  ░      ");
		}
		private static void Spider()
		{
			Console.Write(@"
             ||
             ||
             ||
             ||
             ||
             ||
       _ /\  ||  /\ _
      / X  \.--./  X \
     /_/ \/`    `\/ \_\
    /|(`-/\_/)(\_/\-`)|\
   ( |` (_(.oOOo.)_) `| )
   ` |  `//\(  )/\\`  | `
     (  // ()\/() \\  )
      ` (   \   /   ) `
         \         /        
          `       `  
");


		}

		private static void SpiderDead()
		{
			Console.Write(@"
             ||
             ||
             ||
             ||
             ||
             ||
       _ /\  ||  /\ _
      / X  \.--./  X \
     /_/ \/`    `\/ \_\
    /|(`-/\_/)(\_/\-`)|\
   ( |` (_(.xXXx.)_) `| )
   ` |  `//\(  )/\\`  | `
     (  // ()\/() \\  )
      ` (   \   /   ) `
         \         /        
          `       `  
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

			Typewrite(message);
			Console.ResetColor();
			Console.ReadKey();
		}
		static void Typewrite(string message)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
				System.Threading.Thread.Sleep(20);
			}
			Console.WriteLine();
		}

		static void Main()
			{
				Console.Title = "JETBUILDERS";
				Game.StartGame();
				Console.Read();
			}
		}
	}
}

	