using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine("String: "+str);
            //Remove the empty spaces from the message
            str = str.Replace(" ", string.Empty);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
  }