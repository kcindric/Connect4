using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheese
{
    public class Board
    {
        //Method that draws a board every turn using an array
        public void DisplayBoard(string[,] board)
        {
            int rows = 6;
            int col = 7;

            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < col; j++)
                {
                    if (board[i, j] != "X" && board[i, j] != "O")
                        board[i, j] = "*";
                    Console.Write(board[i, j]);
                }
                Console.Write("| \n");

            }
        }
    }
}
