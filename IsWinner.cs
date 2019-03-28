using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheese
{
    public class IsWinner
    {
        int rows = 6;
        int col = 7;
        bool gameEnd = false;

        //checks
        public bool WinnerCheck(string[,] board, string playerSign)
        {
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    //ide do 9 elemenata zato jer računa i "|" dok mi baca error za vertikalni check jer nemam tih dodatnih znakova
                    //neki workaraound gdje bi checkirao do sigurne duljine i onda promijenio stranu za ostatak
                    if (board[i,j]==playerSign && board[i,j+1] == playerSign && board[i,j+2] == playerSign && board[i, j + 3] == playerSign)
                    {
                        Console.WriteLine($"Winner {playerSign}!");
                        gameEnd = true;
                        
                    }
                }
            }

            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    //izadje mi van arraya, trenutno ne znam zašto - pogledaj komentar za gornju petlju
                    if (board[i, j] == playerSign && board[i + 1, j] == playerSign && board[i + 2, j] == playerSign && board[i + 3, j] == playerSign)
                    {
                        Console.WriteLine($"Winner {playerSign}!");
                        gameEnd = true;

                    }
                }
            }

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
