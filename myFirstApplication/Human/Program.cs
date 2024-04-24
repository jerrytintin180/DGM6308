using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
	 class Program
	{
		static void Main(string[] args)
		{
			YourName Tintin = new YourName("tintin", "ding", "165", 55, 30);
			YourName Tintin2 = new YourName("tintin", "ding", "165", 55, 10);

			Tintin.Introduction();
			Tintin2.Introduction();

			YourName Tintin3 = new YourName();
			Tintin3.Introduction();

		}


	}
}
