using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[5];
            int cnt = 0;

            while (cnt < 5) {
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
                cnt++;
            }

            Console.WriteLine(arr.Max() + arr.Min());
        }
    }
}
