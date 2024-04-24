using System;
using System.Security.Cryptography.X509Certificates;

namespace Tic_Tac_Toe
{
	class Program
	{
		static char[,] playarea =
		{
			{ '1', '2', '3' },
			{ '4', '5', '6' },
			{ '7', '8', '9' }
		};

		static int turns = 0;

		//void doesn't return
		static void Main(string[] args)
		{
			char player = 'O';
			int input = 0;
			bool correct = true;
			Setfield();

			do
			{

				
				//Save space for console choose a spot //
				
				if (player == 'O')
				{
					player = 'X';
					
					EnterValue(player, input);
				}
				else if (player == 'X')
				{
					player = 'O';
					
					EnterValue(player, input);
				}

				Setfield();



				char[] playerChars = { 'X', 'O' };

				foreach (char playerChar in playerChars)
				{
					if (((playarea[0, 0] == playerChar) && (playarea[0, 1] == playerChar) && (playarea[0, 2] == playerChar))
						|| ((playarea[1, 0] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[1, 2] == playerChar))
						|| ((playarea[2, 0] == playerChar) && (playarea[2, 1] == playerChar) && (playarea[2, 2] == playerChar))
						|| ((playarea[0, 0] == playerChar) && (playarea[1, 0] == playerChar) && (playarea[2, 0] == playerChar))
						|| ((playarea[0, 1] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[2, 1] == playerChar))
						|| ((playarea[0, 2] == playerChar) && (playarea[1, 2] == playerChar) && (playarea[2, 2] == playerChar))
						|| ((playarea[0, 0] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[2, 2] == playerChar))
						|| ((playarea[2, 0] == playerChar) && (playarea[1, 1] == playerChar) && (playarea[0, 2] == playerChar))
						)
					{
						if (playerChar == 'X')
						{
							Console.WriteLine("Player X wins!");
						}
						else
						{
							Console.WriteLine("Player O wins!");
						}

						Console.WriteLine("Press any key to play again.");
						
						// Console.Readkey() wait in this code line until user presses a key
						Console.ReadKey();

						Reset();
						break;
					}

				
				}

				/*do {} while (correct);*/
				do
				{

					Console.WriteLine("\nPlayer {0}: Choose a spot!", player);

					try
					{
						input = Convert.ToInt32(Console.ReadLine());
					}
					catch
					{
						Console.WriteLine("Please enter an integer between 1 and 9");
					}

					if ((input == 1) && (playarea[0, 0] == '1'))
					{ correct = true; break; }
					else if ((input == 2) && (playarea[0, 1] == '2'))
					{ correct = true; break; }
					else if ((input == 3) && (playarea[0, 2] == '3'))
					{ correct = true; break; }
					else if ((input == 4) && (playarea[1, 0] == '4'))
					{ correct = true; break; }
					else if ((input == 5) && (playarea[1, 1] == '5'))
					{ correct = true; break; }
					else if ((input == 6) && (playarea[1, 2] == '6'))
					{ correct = true; break; }
					else if ((input == 7) && (playarea[2, 0] == '7'))
					{ correct = true; break; }
					else if ((input == 8) && (playarea[2, 1] == '8'))
					{ correct = true; break; }
					else if ((input == 9) && (playarea[2, 2] == '9'))
					{ correct = true; break; }
					else
					{
						Console.WriteLine("\n Incorrect Input!");
						correct = false;
					}

				} while (correct == true);

			} while (true);
		}

		public static void Setfield()
		{
			Console.Clear();
			Console.WriteLine("   |   |   ");
			Console.WriteLine(" {0} | {1} | {2} ", playarea[0,0], playarea[0,1], playarea[0,2]);
			Console.WriteLine("___|___|___");
			Console.WriteLine("   |   |   ");
			Console.WriteLine(" {0} | {1} | {2} ", playarea[1,0], playarea[1,1], playarea[1,2]);
			Console.WriteLine("___|___|___");
			Console.WriteLine("   |   |   ");
			Console.WriteLine(" {0} | {1} | {2} ", playarea[2,0], playarea[2,1], playarea[2,2]);
			Console.WriteLine("   |   |   ");
			turns++;
		}

		public static void EnterValue(char player, int input)
		{
			switch (input)
			{
				case 1:
					playarea[0, 0] = player; break;
				case 2:
					playarea[0, 1] = player; break;
				case 3:
					playarea[0, 2] = player; break;
				case 4:
					playarea[1, 0] = player; break;
				case 5:
					playarea[1, 1] = player; break;
				case 6:
					playarea[1, 2] = player; break;
				case 7:
					playarea[2, 0] = player; break;
				case 8:
					playarea[2, 1] = player; break;
				case 9:
					playarea[2, 2] = player; break;
			}

		}

		public static void Reset()
		{
			char[,] playStart =
			{
				{'1','2','3' },
				{'4','5','6'},
				{'7','8','9' }
			};

			playarea = playStart;
			Setfield();
			turns =0;
		}

	}
}
