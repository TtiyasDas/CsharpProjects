using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No of Input:");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("inputs are:");
            int i;
            int count = 0;
            int sum = 0;
            for(i=1;i<=t;i++)
            {
                
                int n = Convert.ToInt32(Console.ReadLine());
                count++;
                sum = sum + n;
            }
            double avg = sum / count;
            Console.WriteLine("Sum:{0}", sum);
            Console.WriteLine("Average{0}", avg);
        }
    }
}
