//console app

using System;
//allows to avoid repeating the word system thoughout the code

//Goal:
//1. Prompt user for minutes exercised
//2. Add minutes to total
//3.Display total minutes exercised to the screen
//4.Repeat until the user quits

namespace FitnessFrog
{
	class Program
	{
		static void Main()
		{
			int runningTotal = 0;
			bool keepGoing = true;
			
			while(keepGoing)
			{
				//1.
				Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
				//System.Console.Write() - System = namespace, Console = class, Write = Method
				//console.write = printing params to the console
				
				string entry = Console.ReadLine();
				if (entry == "quit")
				{
					keepGoing = false;
				}
				else
				{
					//2.
					int minutes = int.Parse(entry);
					//extracing the value from entry which is a string and converting it to an integer
					runningTotal = runningTotal + minutes;

					//3.
					Console.WriteLine("You've entered " + runningTotal + " minutes.");
				}
			}
			Console.WriteLine("Goodbye");
		}
	}
}