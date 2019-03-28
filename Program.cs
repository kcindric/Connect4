using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheese
{
    class Program
    {
        
        static void Main()
        {
            string playerOneSign = "X";
            string playerTwoSign = "O";
            Board board = new Board();
            FieldCheck fieldCheck = new FieldCheck();
            IsWinner isWinner = new IsWinner();

            string[,] boardArr = new string[6, 9];
            bool gameEnd = true;

            do
            {
                //1st player turn
                board.DisplayBoard(boardArr);
                Console.WriteLine("Choose a column from 1 to 7:");
                int choice = int.Parse(Console.ReadLine());

                while (choice < 1 || choice > 7)
                {
                    Console.WriteLine("Choose a column from 1 to 7:");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                fieldCheck.Check(boardArr, choice, playerOneSign);
                Console.Clear();
                isWinner.WinnerCheck(boardArr, gameEnd, playerOneSign);
                if (gameEnd == false)
                {
                    Console.WriteLine("gameEnd is false");
                }

                //2nd player turn
                board.DisplayBoard(boardArr);
                Console.WriteLine("Choose a column from 1 to 7:");
                choice = int.Parse(Console.ReadLine());

                while (choice < 1 || choice > 7)
                {
                    Console.WriteLine("Choose a column from 1 to 7:");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                fieldCheck.Check(boardArr, choice, playerTwoSign);
                Console.Clear();
                isWinner.WinnerCheck(boardArr, gameEnd, playerTwoSign);

            } while (gameEnd);

            Console.WriteLine("The game has ended!");
        }

    }
}
