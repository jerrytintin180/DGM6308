﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch3GuyMoneyPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			Guy joe = new Guy() { Cash = 50, Name = "Joe" };
			Guy bob = new Guy() { Cash = 100, Name = "Bob" };
			while(true)
			{
				joe.WriteMyInfo();
				bob.WriteMyInfo();
				Console.Write("Enter an amount: ");
				string howMuch = Console.ReadLine();
				if (howMuch == "") return;
				if (int.TryParse(howMuch, out int tempAmount))
				{
					Console.Write("Who should give the cash: ");
					string whichGuy = Console.ReadLine();
					if (whichGuy =="Joe")
					{
						 int cashGiven = joe.GiveCash(tempAmount);
						bob.ReceiveCash(cashGiven);
					} 
					else if (whichGuy == "Bob")
					{
						int cashGiven = bob.GiveCash(tempAmount);
						joe.ReceiveCash(cashGiven);
					}
					else
					{
						Console.WriteLine("Please enter 'Joe' or 'Bob'");
					}
					
				}
                else
                {
					Console.WriteLine("Please enter an amount (or a blank line to exit)");
                }
            }
		}

			

	
	}

}
