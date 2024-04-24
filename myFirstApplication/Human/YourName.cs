using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
	public class YourName
	{
		public string firstname=" ";
		public string lastname=" ";
		public string heigth=" ";
		public int weight=0;
		public int age=0;

		public YourName() {
			Console.WriteLine("Your name was called");
		}
		
		// as long as inside () the variables 
		public YourName(string firstName, string lastName, string Heigth, int Weight, int Age)
		{
			this.firstname = firstName; // this. let us access this file.
			this.lastname = lastName;
			this.heigth = Heigth;
			this.weight = Weight;
			this.age = Age;
		}

		public void Introduction()
		{
			if (age >= 18)
			{
				Console.WriteLine("Hello my name is {0} {1}. I am {2} and weigh {3}." +
					"Also I am {4} years old.", firstname, lastname, heigth, age);
			}else
			{
				Console.WriteLine("Sorry I am underage so I can't intro");
			}
		}
	}
}
