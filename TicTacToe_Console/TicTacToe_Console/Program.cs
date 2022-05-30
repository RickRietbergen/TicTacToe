using System;

namespace TicTacToe_Console
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player;
        static int choice;
        static int chequeredFlag;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to TicTacToe");
            Console.WriteLine("\n");
            Console.WriteLine("Player 1: X | Player 2: O");
            Console.WriteLine("\n");

            Board();
            Console.ReadLine();
        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        private static void CheckWin()
        {

        }
    }
}
