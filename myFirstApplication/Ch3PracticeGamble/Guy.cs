using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3GuyMoneyPractice
{
	
		class Guy
		{
			public String Name;
			public int Cash;

			public void WriteMyInfo()
			{
				Console.WriteLine(Name + " has " + Cash + " bucks.");
			}

			public int GiveCash(int amount)
			{
				if (amount <= 0)
				{
					Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
					return 0;
				}
				if (amount > Cash)
				{
					Console.WriteLine(Name + " says " + "I don't have enough cash to give you" + amount);
					return 0;
				}
				Cash -= amount;
				return amount;
			}

			public void ReceiveCash(int amount)
			{
				if (amount <= 0)
				{
					Console.WriteLine(Name + " says: " + amount + "isn't an amount I'll take.");
				}
				else
				{
					Cash += amount;
				}
			}
		}
	
}
