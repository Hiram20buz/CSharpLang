using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card();

            Console.WriteLine(card1.AccountNum);
        }
    }
    class Card
    {
        private string accountNum = "0011592048120";
        public string AccountNum {
        get{return accountNum ;} 
        }
    }
}
