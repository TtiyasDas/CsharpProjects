using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[6];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            numbers[3] = 104;
            numbers[4] = 105;
            numbers[5] = 106;

            int i = 0;
            while(numbers[i]<numbers[5])
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
        }
    }
}
