using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheese
{
    //checks if the bottom row of the chosen column is taken, if it is, it moves the X or O sign to the next available row 
    public class FieldCheck
    {
        public void Check(string[,] board, int choice, string sign)
        {
            choice = choice - 1;
            string x = "X";
            string o = "O";
            int height = 5;
            bool taken = true;

            do
            {
                if (board[height, choice] != x && board[height, choice] != o)
                {
                    board[height, choice] = sign;
                    taken = false;
                }
                else
                {
                    height = height - 1;
                }
            } while (taken);
        }
    }
}
