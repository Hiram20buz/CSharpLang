using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

           try{ Console.Write(games[Int32.Parse(Console.ReadLine())]);}
           catch(Exception a)
           {
               Console.Write("Invalid number");
           }
        }
    }
}
