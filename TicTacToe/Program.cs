using System;

namespace TicTacToe
{
    internal class Program
    {
        //Creating The PlayField
        static char[,] playField =
            {
                {'1' ,'2' ,'3' },
                {'4', '5', '6' },
                {'7' ,'8', '9' }


            };

        //Initialise the turns
        static int turns = 0;

        static void Main(string[] args)
        {
            int input = 0;
            int player = 1;
            bool isInputCorrect = true;

            //Loop while the game continues

             do
            {
                if (player == 1)
                {
                    player = 2;
                    EnterCharacter(player, input);
                }

                else if(player ==2)
                {
                    player = 1;
                    EnterCharacter(player, input);
                }

              // Implement Set Field method inside loop, to set field each time a player plays

                SetField();

                // Calculate Winning Logic

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                         || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                         || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                         || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                         || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                         )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!");
                        }

                        Console.WriteLine("Press any Key to Reset the Game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("/Draw");
                        Console.WriteLine("Press any Key to Reset the Game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }




                do
            {
                Console.Write("\nPLayer {0}: Choose your place you want to cross or zero: " ,player);
                try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }

                 catch
                    {
                        Console.WriteLine("Enter correct field!!!!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        isInputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        isInputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        isInputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        isInputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        isInputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        isInputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        isInputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        isInputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        isInputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        isInputCorrect = false;
                    }






                } while (!isInputCorrect);


            } while (true);

            

            



        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };

            playField = playFieldInitial;
            SetField();
            turns = 0;
        }





        // Setting the Playing Field
        static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0,1], playField[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            turns++;


        }

        static void EnterCharacter( int player , int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1: playField[0, 0] = playerSign ; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;

            }




        }


    }
}
