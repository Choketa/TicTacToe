using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] board = new char[] { '?', '?', '?', '?', '?','?', '?', '?', '?' };
            int numOfPlays = 1;
            char player;
            int index;

            Console.WriteLine("  1   2   3");
            Console.WriteLine("| {0} | {1} | {2} |  a", board[0], board[1], board[2]);
            Console.WriteLine(" ------------");
            Console.WriteLine("| {0} | {1} | {2} |  b", board[3], board[4], board[5]);
            Console.WriteLine(" ------------");
            Console.WriteLine("| {0} | {1} | {2} |  c", board[6], board[7], board[8]);
            Console.WriteLine();

            while (true)
            {
                if (numOfPlays % 2 != 0)
                {
                    Console.WriteLine("You're playing as X");
                    player = 'X';
                } else
                {
                    Console.WriteLine("You're playing as O");
                    player = 'O';
                }
                Console.WriteLine("Input column: (1,2,3)");
                int column = int.Parse(Console.ReadLine());
                Console.WriteLine("Input row: (a, b, c)");
                char row = char.Parse(Console.ReadLine());
                index = (int)row - '0' - '0';
                if (row == 'b') index += column;
                else if (row == 'c') index += (column + 2);
                else index = Math.Abs(index - column);
                if (board[index] != '?')
                {
                    while (true)
                    {
                        Console.WriteLine("Silly, you can't put it there! It's taken!");
                        Console.WriteLine("Input column: (1,2,3)");
                        column = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input row: (a, b, c)");
                        row = char.Parse(Console.ReadLine());
                        index = (int)row - '0' - '0';
                        if (row == 'b') index += column;
                        else if (row == 'c') index += (column + 2);
                        else index = Math.Abs(index - column);
                        if (board[index] == '?')
                        {
                            break;
                        }
                        else continue;
                    }

                    }
                    board[index] = player;
                
                    Console.Clear();

                Console.WriteLine("  1   2   3");
                Console.WriteLine("| {0} | {1} | {2} |  a", board[0], board[1], board[2]);
                Console.WriteLine(" ------------");
                Console.WriteLine("| {0} | {1} | {2} |  b", board[3], board[4], board[5]);
                Console.WriteLine(" ------------");
                Console.WriteLine("| {0} | {1} | {2} |  c", board[6], board[7], board[8]);
                Console.WriteLine();
                numOfPlays++;

                if ((board[8] == board[4] && board[4] == board[0] && board[8] != '?' || board[6] == board[4] && board[4] == board[2] && board[2] != '?' ||
                     board[8] == board[7] && board[7] == board[6] && board[8] != '?' || board[5] == board[4] && board[4] == board[3] && board[5] != '?' ||
                     board[2] == board[1] && board[1] == board[0] && board[2] != '?' || board[0] == board[3] && board[3] == board[6] && board[0] != '?' ||
                     board[1] == board[4] && board[4] == board[7] && board[1] != '?' || board[2] == board[5] && board[5] == board[8] && board[2] != '?'))
                    {
                    Console.WriteLine(player +" has won the game! Times played: "+(numOfPlays-1));
                    break;
                }

                    

            }
        }
    }
}
