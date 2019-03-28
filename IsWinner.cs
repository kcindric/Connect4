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
        int loopNumber = 0;
        public void WinnerCheck(string[,] board, bool gameEnd, string playerSign)
        {
            gameEnd = false;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    //ne radi jer gleda i * a ne samo X i O pa tako često ovo bude
                    if (board[i,j]==playerSign && board[i,j+1] == playerSign && board[i,j+2] == playerSign && board[i, j + 3] == playerSign)
                    {
                        Console.WriteLine($"Winner {playerSign}!");
                        gameEnd = false;
                    }
                }
            }
        }
    }
}
