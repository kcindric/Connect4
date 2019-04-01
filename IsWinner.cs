using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheese
{
    public class IsWinner
    {
        bool gameEnd = false;

        //checks
        public bool WinnerCheck(string[,] board, string playerSign)
        {
            //horizontal check
            int rows = 6;
            int col = 7;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //it checks columns 
                    if (board[i, j] == playerSign && board[i, j + 1] == playerSign && board[i, j + 2] == playerSign && board[i, j + 3] == playerSign)
                    {
                        Console.WriteLine($"Winner {playerSign}!");
                        gameEnd = true;

                    }
                }
            }


            //vertical check
            //int rows and col are different because there are no additional "|" signs as in the horizontal check
            int rows_vertical = 3;
            int col_vertical = 7;

            for (int j = 0; j < col_vertical; j++)
            {
                for (int i = 0; i < rows_vertical; i++)

                {
                    if (board[i, j] == playerSign && board[i + 1, j] == playerSign && board[i + 2, j] == playerSign && board[i + 3, j] == playerSign)
                    {
                        Console.WriteLine($"Winner {playerSign}!");
                        gameEnd = true;

                    }
                }
            }

            //diagonal check
            #region diagonal check L to R
            
            

            for(int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //don't know should I put it in our outside with the int loop?
                    //IT WORKS!
                    //test every possible outcome
                    int innerLoop = 0;
                    int loop = 0;
                    do
                    {
                        //index outside of the array
                        if (board[i-loop, j+loop] == playerSign && board[i-1-loop, j+1+loop] == playerSign && board[i-2-loop, j+2+loop] == playerSign && board[i-3-loop, j+3+loop] == playerSign)
                        {
                            Console.WriteLine($"Winner {playerSign}!");
                            gameEnd = true;
                        }
                        innerLoop++;
                    } while (innerLoop < loop);
                    loop++;
                }
            }
           

            if (board[3,0] == playerSign && board[2,1] == playerSign && board[1,2] == playerSign && board[0,3] == playerSign )
            {
                Console.WriteLine($"Winner {playerSign}!");
                gameEnd = true;
            }
            #endregion



            if (gameEnd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
