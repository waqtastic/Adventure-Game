using System;
using System.Threading;
using System.Collections.Generic;

namespace AdventureGame
{


    public static class Game
    {
        static string FCharacterName = "Pless";
        static string LCharacterName = "Haldur";

        public static void StartGame()
        {
            setWindow(125, 25);
            Title();
            Dialogue("A (vaguely) interactive text based adventure game!", "cyan");
            Console.WriteLine();
            StoryDialogue("Press enter to get started!");
            Console.Clear();
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
            StoryDialogue("You are in an office, on your first day. You are approached by your new boss, Ricardo.");
            Dialogue("\"Ah! " + FCharacterName + "! Good to see you here bright and early. Your desk is over there\"", "white");
            StoryDialogue("You see the desk he pointed at, above it is a poster with a jet on it along with the company motto:");
            Dialogue("CREATE. CONSTRUCT. CONCLUDE.", "yellow");
            StoryDialogue("As you look around you notice there are jets everywhere, one of the rooms looks like it was taken straight out of a Lockheed SR-71 Blackbird");
            StoryDialogue("Dang, how much did they spend to get that?");
            StoryDialogue("You sit down at your desk and turn on your computer, when you realise you haven't been assigned anything to do.");
            StoryDialogue("What do you do " + FCharacterName + "?");
            Console.Clear();
            Choice();
        }

        static void Choice()
        {

            string input = "";
            StoryDialogue("You could get a cup of coffee, or you could ask someone what you should be doing");
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
                StoryDialogue("You decide to go see the person who hired you, Greg");
                Dialogue("\"Hey Greg, it's my first day. What should I do?\"", "green");
                Dialogue("\"Oh hey " + FCharacterName + "! Welcome aboard. Well since you're just starting out we thought \nwe'd give you a simple project\"", "cyan");
                Dialogue("\"Great, what do you want me to do?\"", "green");
                StoryDialogue("Greg hands you a knife");
                Console.ReadKey();
                Dialogue("\"I need you to go into the basement and shank the bugs down there\"", "cyan");
                Dialogue("\"I thought this was a software company?\"", "green");
                Dialogue("\"Yes, and it's your job to get rid of those bugs!\"", "cyan");
                StoryDialogue("You are handed a pointy piece of metal, and Greg points you towards an ominous looking door. You're not sure what you've gotten yourself into, but it looks like you have a task at least");
                Dialogue("\"And don't forget to mark it \"done\" in Jira afterwards!\"", "cyan");
                ChoiceBugQuest();
            }
            else
            {
                StoryDialogue("Pick from one of the choices:");
                Choice();
            }
        }
        public static void ChoiceA() //this the one where choices get screwed up because it just ignores the first character you write. So if you type A and then push enter it will ignore it and assume its blank, but if you push space or anything else before your choice it works fine.
        {
            string input = "";
            Console.Clear();
            StoryDialogue("You go to the kitchen area and see some people milling around a coffee machine you grab a cup and push the button to vend a fresh brew.");
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
                StoryDialogue("You turn to one of the other people in the area and introduce yourself");
                Dialogue("\"Hello, my name is " + FCharacterName + ", I just started today\"", "green");
                StoryDialogue("A sleepy looking guy with a cup of coffee looks at you blankly for a moment before realising that you were talking to them");
                Dialogue("\"Hmm? Oh I thought you were talking to Jen\"", "yellow");
                StoryDialogue("He points vaguely behind him. You see there's no one there");
                Dialogue("\"I'm Bob. So you're new huh? Welcome to the grindstone. Got your first assignment yet?\"", "yellow");
                StoryDialogue("You shake your head");
                Dialogue("\"You should talk to Greg then, he'll assign you something\"", "yellow");
                StoryDialogue("He points you towards a guy in a checkered shirt, who is stood at a desk");
                Dialogue("\"Thanks Bob, nice to meet you by the way\"", "green");
                StoryDialogue("Bob nods in acknowledgement and wanders off to his desk");
                StoryDialogue("You decide to go see the person who hired you, Greg");
                Dialogue("\"Hey Greg, it's my first day. What should I do?\"", "green");
                Dialogue("\"Oh hey " + FCharacterName + "! Welcome aboard. Well since you're just starting out we thought we'd give you a simple \nproject\"", "cyan");
                Dialogue("\"Great, what do you want me to do?\"", "green");
                StoryDialogue("Greg hands you a knife");
                Dialogue("\"I need you to go into the basement and shank the bugs down there\"", "cyan");
                Dialogue("\"I thought this was a software company?\"", "green");
                Dialogue("\"Yes, and it's your job to get rid of those bugs!\"", "cyan");
                StoryDialogue("You are handed a pointy piece of metal, and Greg points you towards an ominous looking door. You're not sure what you've gotten yourself into, but it looks like you have a task at least");
                Dialogue("\"And don't forget to mark it \"done\" in Jira afterwards!\"", "cyan");
                ChoiceBugQuest();
            }
            else if (input == "B")
            {
                Console.Clear();
                StoryDialogue("You decide to head back to your desk and set up the laptop they gave you to work on.");
                StoryDialogue("Looks like they set up an email account for you already. You have an email with \"First assignment\" on it. They've thought of everything it seems.");
                StoryDialogue("You open the email and it has instructions to... grab a knife and go to the basement to kill some bugs");
                StoryDialogue("Are they serious?");
                StoryDialogue("As you scroll down you see that it says \"Yes, I'm serious\"");
                StoryDialogue("You get up from your desk and grab a knife from the kitchen and head towards the basement");
                ChoiceBugQuest();
            }
            else
            {
                StoryDialogue("Pick from one of the choices");
                Console.Clear();
                ChoiceA();
            }
        }


        private static void ChoiceBugQuest()
        {
            string input = "";
            Console.Clear();
            StoryDialogue("You look at the knife, on closer inspection it has \"C#\" written on it.You touch the blade and find see that it is infact sharp. You open the ominous door, it's dark in here.");
            StoryDialogue("You head down the stairs into the gloomy basement. It's difficult to see down here");
            StoryDialogue("You could try finding a light switch in here, or you could just use the torch on your phone");
            Console.WriteLine("A: Search for the light switch");
            Console.WriteLine("B: Use the torch on your phone");
            Console.WriteLine("Enter your choice:");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                StoryDialogue("You decide to look for the light switch, there's got to be one somewhere.");
                StoryDialogue("You search the dimly lit area near the entrance for a light switch without much luck");
                StoryDialogue("You stray further and further away from the light, you find a switch. You flip it and nothing happens");
                StoryDialogue("A buzzing noise from above echoes through the basement, followed by a \"tink\" as a dull yellow flash momentarily stuns you");
                StoryDialogue("On the second flash you see the bug they mentioned infront of you");
                BugFight();
            }
            else if (input == "B")
            {
                StoryDialogue("You use the torch on your phone to light the area up");
                StoryDialogue("In front of you, you see a giant spider!");
                BugFight();
            }
            else
            {
                StoryDialogue("Pick from one of the choices:");
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
            StoryDialogue("You are faced with the biggest spider you've ever seen.Frozen from shock, a few moments pass before you hear:");
            Dialogue("\"Psst hey kid wanna buy some drugs?\"", "red");
            StoryDialogue("This seems to be the bug they were talking about. I guess you have to deal with it somehow");
            Console.WriteLine("A: Shank it with your C# knife");
            Console.WriteLine("B: Call the cops");
            Console.WriteLine("C: Nope right out of there");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                StoryDialogue("You take out your knife, and decide to see how sharp it really is");
                Dialogue("\"Hey what are you doing with that knife\"", "red");
                StoryDialogue("You close your eyes and thrust your knife towards the spider!");
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
                StoryDialogue("Did that spider just offer you drugs?");
                StoryDialogue("You decide to call the cops, afterall, drugs are illegal");
                Dialogue("\"You're calling the popo?! Screw this I'm out!\"", "red");
                StoryDialogue("you see the spider hurriedly pack a suitcase full of webbing and scurry off into the vents");
                Console.ReadKey();
                StoryDialogue("I guess you're done with the quest. You hear a voice echo through the vents as you turn to leave");
                Dialogue("\"Don't forget to mark it as done in Jira\"", "red");
                Console.Clear();
                QuestComplete();

            }
            else if (input == "C")
            {
                StoryDialogue("At the sight of the oversized apparently TALKING spider you decide to back away right up the stairs you just came down");
                Dialogue("\"That's right, walk away! And make sure you let the others \nknow that this is spider turf\"", "red");
                QuestFailed();

            }
            else
            {
                StoryDialogue("Pick from one of the choices");
                Console.ReadKey();
                Console.Clear();
                BugFight();
            }
        }
        private static void QuestComplete()
        {
            Dialogue("\"I guess I'm done with this task. I'll go mark it as done in Jira\"", "green");
            StoryDialogue("You head back upstairs, back to your desk");
            StoryDialogue("On your way you see Ricardo");
            Dialogue("\"Ah! " + FCharacterName + " how did you get on with your first assignment?\"", "white");
            StoryDialogue("You mull it over for a moment before finally giving an answer\"");
            Dialogue("\"Well I got rid of the spider if that's what you're asking\"", "green");
            Dialogue("\"Fantastic! I was worried we were going to have to shoot you out of the cannon, haha!\"", "white");
            Dialogue("\"A cannon?\"", "green");
            StoryDialogue("Before you can get him to elaborate, Ricardo wanders away from your desk. Might be worth re-reading that contract to see what that's about. You decide to login to Jetbuilders.Atlassian.net to mark your task as done.");
            StoryDialogue("No sooner had you finished moving the ticket to the \"done\" column, Greg appears next to you.");
            Dialogue("\"Well, thats the end of the working day. See you tomorrow " + FCharacterName + "!\"", "cyan");
            Dialogue("\"What? But it's still the morning!\"", "green");
            StoryDialogue("Your words fall on deaf ears, Greg is already heading towards the exit. You realise everyone else is packing up and heading out as well. When in Rome, right?");
            StoryDialogue("After packing your stuff up you head outside, and drive home");
            YouWin();
        }
        private static void QuestFailed()
        {
            Console.Clear();
            StoryDialogue("You head back upstairs and bump into the Greg, the guy who hired you");
            Dialogue("\"I can't do it, this isn't what I signed up for!\"", "green");
            StoryDialogue("Greg doesn't appear surprised by your outburst");
            Dialogue("\"Well I can't say I didn't expect this, not everyone is cut out to be a developer\"", "cyan");
            StoryDialogue("He walks you over to his desk, and shuffles about with paperwork for a moment");
            Dialogue("\"I don't think you're a good fit at this company, so I'm afraid I'm going to have to ask you to sign that\"", "cyan");
            StoryDialogue("It's an acknowledgement of termination. You hastily sign it so you can leave and find a less insane job. As you're reading through the contract something catches your eye, a \"Cannon Clause\"");
            Dialogue("\"What's this Cannon Clause about?\"", "green");
            StoryDialogue("Greg pulls a lever that was obscured by his monitor and the floor underneath you vanishes");
            StoryDialogue("You find yourself in the barrel of a cannon");
            Dialogue("\"You should have read the contract!\"", "cyan");
            Dialogue("\"Oh shi-\"", "green");
            Thread.Sleep(1000);
            Console.Clear();
            Death();
        }

        private static void Title()
        {
            Dialogue(@"     ██╗███████╗████████╗██████╗ ██╗   ██╗██╗██╗     ██████╗ ███████╗██████╗ ███████╗██╗
     ██║██╔════╝╚══██╔══╝██╔══██╗██║   ██║██║██║     ██╔══██╗██╔════╝██╔══██╗██╔════╝██║
     ██║█████╗     ██║   ██████╔╝██║   ██║██║██║     ██║  ██║█████╗  ██████╔╝███████╗██║
██   ██║██╔══╝     ██║   ██╔══██╗██║   ██║██║██║     ██║  ██║██╔══╝  ██╔══██╗╚════██║╚═╝
╚█████╔╝███████╗   ██║   ██████╔╝╚██████╔╝██║███████╗██████╔╝███████╗██║  ██║███████║██╗
 ╚════╝ ╚══════╝   ╚═╝   ╚═════╝  ╚═════╝ ╚═╝╚══════╝╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝
                                                                                        ", "cyan");
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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            StoryDialogue("Always read the contract!");
            Console.ReadKey();
            Environment.Exit(0);
        }
        private static void YouWin()
        {
            Console.Clear();
            Typewrite(@"
   ,___                              _                      
  /   /                     _/_     //     _/_o             
 /    __ _ _   _,  _   __,  /  , , // __,  / ,  __ _ _   (  
(___/(_)/ / /_(_)_/ (_(_/(_(__(_/_(/_(_/(_(__(_(_)/ / /_/_)_
               /|                                           
              (/                                            
                                                            
 __   _ ___  __   ,   __    _____ __                        
( /  / /  ()( /  /   ( /   /( /( /  )     /                 
 (__/ /   /  /  /     / / /  /  /  /     /                  
  _/_(___/  (_,/_    (_/_/ _/_ /  (_    '                   
 //                                    o                    
(/                                                          
");
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
        public static void setWindow(int width, int height)
        {
            width = 150;
            height = 35;

            Console.WindowWidth = width;
            Console.WindowHeight = height;
        }

        public static void StoryDialogue(string paragraph, int tabSize = 8)
        {
            string[] lines = paragraph
                .Replace("\t", new String(' ', tabSize))
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                string process = lines[i];
                List<String> wrapped = new List<string>();

                while (process.Length > Console.WindowWidth)
                {
                    int wrapAt = process.LastIndexOf(' ', Math.Min(Console.WindowWidth - 1, process.Length));
                    if (wrapAt <= 0) break;

                    wrapped.Add(process.Substring(0, wrapAt));
                    process = process.Remove(0, wrapAt + 1);
                }

                foreach (string wrap in wrapped)
                {
                    Console.WriteLine(wrap);
                }

                Console.WriteLine(process);
                Console.ReadKey();
            }
        }

        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(5);
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


	