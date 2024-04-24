using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardBlazor
{
	internal class CardPicker
	{
		static Random random = new Random();
		public static string[] PickSomeCards(int numberOfCards)
		{
			string[] pickedCards =new string[numberOfCards];
			for (int i = 0; i < numberOfCards; i++)
			{
				pickedCards[i] = RandomValue() + " of " + RandomSuit();
			}
			return pickedCards;
		}

		private static string RandomValue()
		{
			int Value= random.Next(1,14);
			if (Value == 1) return "Ace";
			if (Value == 11) return "Jack";
			if (Value == 12) return "Queen";
			if (Value == 13) return "King";

			// Because we declare RandomValue() as string method, we return not just Value but turn it to string.
			return Value.ToString();
		}
		
		private static string RandomSuit()
		{
			/* Practice of Ana's game in Ch.3
			Random random1 = new Random();
			double[] randomDoubles = new double[20];
			for (int i = 0; i<20; i++)
			{
				double value1 = random1.NextDouble();
				randomDoubles[i] = value1;
			} */
			

			// get a random number from 1 to 4
			int value = random.Next(1, 5);

			if (value == 1) return "Spades";
			if (value == 2) return "Hearts";
			if (value == 3) return "Clubs";
			return "Diamonds";

			

		}

	}
}
