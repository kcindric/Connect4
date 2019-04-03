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

        //checks is there a winning combination
        //a lot of dirty code, could use a rework
        public bool WinnerCheck(string[,] board, string playerSign)
        {
            //horizontal check
            int rows = 6;
            int col = 7;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                { 
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
                    int innerLoop = 0;
                    int loop = 0;
                    do
                    {
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
            #endregion

            #region diagonal check R to L

            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 7; j++)
                {
                    int innerLoop = 0;
                    int loop = 0;
                    do
                    {
                        if (board[i - loop, j - loop] == playerSign && board[i - 1 - loop, j - 1 - loop] == playerSign && board[i - 2 - loop, j - 2 - loop] == playerSign && board[i - 3 - loop, j - 3 - loop] == playerSign)
                        {
                            Console.WriteLine($"Winner {playerSign}!");
                            gameEnd = true;
                        }
                        innerLoop++;
                    } while (innerLoop < loop);
                    loop++;
                }
            }
            #endregion

            //returns a value based is there a winner or not
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
