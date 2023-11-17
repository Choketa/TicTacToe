using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] board = new char[] { '?', '?', '?', '?', '?','?', '?', '?', '?' };
            int numOfPlays = 0;
            char player;
            int index;
            int cycle = 0;
         

            Console.WriteLine("  1   2   3");
            Console.WriteLine("| ? | ? | ? |  a");
            Console.WriteLine(" ------------");
            Console.WriteLine("| ? | ? | ? |  b");
            Console.WriteLine(" ------------");
            Console.WriteLine("| ? | ? | ? |  c");
            Console.WriteLine();

            while (cycle <= 9)
            {
                if (numOfPlays % 2 == 0)
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
                if (column < 1 || column > 3)
                {
                    TryAgain(cycle, board);
                    continue;
                }

                Console.WriteLine("Input row: (a, b, c)");
                char row = char.Parse(Console.ReadLine());
                index = (int)row - '0' - '0';
                if (row < 'a' || row > 'c')
                {
                    TryAgain(cycle, board);
                    continue;

                }

                else if (row == 'b') index += column;
                else if (row == 'c') index += (column + 2);
                else index = Math.Abs(index - column);
                if (board[index] != '?')
                {
                    TryAgain(cycle, board);
                    continue;
                }
                    board[index] = player;
                
                    Console.Clear();

                Board(board);
                numOfPlays++;
                cycle++;

                if (numOfPlays < 5) continue;

                else if (IsVictory(board))
                    {
                    Console.WriteLine(player +" has won the game! Times played: "+(numOfPlays));
                    break;
                }
                else if (numOfPlays == 9)
                {
                    Console.WriteLine("It's a tie, noobs.");
                    break;
                }

                    

            }
        }
        static bool IsVictory(char[] board)
        {
            
            return ((board[8] == board[4] && board[4] == board[0] && board[8] != '?' || board[6] == board[4] && board[4] == board[2] && board[2] != '?' ||
                     board[8] == board[7] && board[7] == board[6] && board[8] != '?' || board[5] == board[4] && board[4] == board[3] && board[5] != '?' ||
                     board[2] == board[1] && board[1] == board[0] && board[2] != '?' || board[0] == board[3] && board[3] == board[6] && board[0] != '?' ||
                     board[1] == board[4] && board[4] == board[7] && board[1] != '?' || board[2] == board[5] && board[5] == board[8] && board[2] != '?'));

        }
        static void Board(char[] board)
        {
            Console.WriteLine("  1   2   3");
            Console.WriteLine("| {0} | {1} | {2} |  a", board[0], board[1], board[2]);
            Console.WriteLine(" ------------");
            Console.WriteLine("| {0} | {1} | {2} |  b", board[3], board[4], board[5]);
            Console.WriteLine(" ------------");
            Console.WriteLine("| {0} | {1} | {2} |  c", board[6], board[7], board[8]);
            Console.WriteLine();

        }
        static void TryAgain(int cycle, char[] board)
        {
            Console.Clear();
            Board(board);
            Console.WriteLine("Think about your input.");
            cycle = 0;
        }

    }
}
