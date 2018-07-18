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
			double runningTotal = 0;
			//bool keepGoing = true;
			
			while(true)
			{
				//1.
				Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
				//System.Console.Write() - System = namespace, Console = class, Write = Method
				//console.write = printing params to the console
				
				string entry = Console.ReadLine();
				if (entry.ToLower() == "quit")
				{
					//keepGoing = false;
					break;
				}
				
					try
					{
						//2.
						double minutes = double.Parse(entry);
						//extracing the value from entry which is a string and converting it to an integer
						//double - numeric data type used to store decimals

						if (minutes <= 0)
						{
							Console.WriteLine(minutes + " is not an acceptable value.");
							continue;
						}
						if(minutes <= 10)
	                    {
	                        Console.WriteLine("Better than nothing, am I right?");
	                    }
	                    else if(minutes <= 30)
	                    {
	                        Console.WriteLine("Way to go hot stuff!");
	                    }
	                    else if(minutes <= 60)
	                    {
	                        Console.WriteLine("You must be a ninja warrior in training!");
	                    }
	                    else
	                    {        
	                        Console.WriteLine("Okay, now you're just showing off!");
	                    }

						runningTotal += minutes;
					}
					catch(FormatException)
					{
						Console.WriteLine("This is not valid input.");
						continue;
					}

					//3.
					Console.WriteLine("You've entered " + runningTotal + " minutes.");
				
			}
			Console.WriteLine("Goodbye");
		}
	}
}