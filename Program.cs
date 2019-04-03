using System;

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
            bool gameContinue = true;

            do
            {
                if (gameContinue)
                {
                    //1st player turn (X)
                    //choose your column
                    board.DisplayBoard(boardArr);
                    Console.WriteLine("Player X's turn");
                    Console.WriteLine("Choose a column from 1 to 7:");
                    int choice = int.Parse(Console.ReadLine());

                    //if your choice is out of the column range repeat
                    while (choice < 1 || choice > 7)
                    {
                        Console.WriteLine("Player X's turn");
                        Console.WriteLine("Choose a column from 1 to 7:");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    //checks if the bottom row of the column taken
                    //if it is, it moves the X to the next free row of the chosen column
                    fieldCheck.Check(boardArr, choice, playerOneSign);
                    Console.Clear();
                }

                //checks if there is a winning combination
                if (isWinner.WinnerCheck(boardArr, playerOneSign))
                {
                    Console.WriteLine("\n");
                    board.DisplayBoard(boardArr);
                    gameContinue = false;
                }

                if (gameContinue)
                {
                    //2nd player turn (O)
                    board.DisplayBoard(boardArr);
                    Console.WriteLine("Player O's turn");
                    Console.WriteLine("Choose a column from 1 to 7:");
                    int choice = int.Parse(Console.ReadLine());

                    while (choice < 1 || choice > 7)
                    {
                        Console.WriteLine("Player O's turn");
                        Console.WriteLine("Choose a column from 1 to 7:");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }

                    fieldCheck.Check(boardArr, choice, playerTwoSign);
                    Console.Clear();
                    if (isWinner.WinnerCheck(boardArr, playerTwoSign))
                    {
                        Console.WriteLine("\n");
                        board.DisplayBoard(boardArr);
                        gameContinue = false;
                    }
                }

            } while (gameContinue);

            Console.ReadLine();
        }

    }
}
