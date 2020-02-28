using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[101];
            for (int i = 1; i <= 100; i++)
            {
                num[i] = i;
            }
            for (int i = 2;i<=10;i++)
            {
                if (num[i] == 1)
                    continue;
                for (int k = 2; k * i <= 100; k++)
                    num[k * i] = 1;
            }
            Console.WriteLine("2到100的素数有");
            for (int i = 2; i <= 100; i++)
            {
                if (num[i] != 1)
                    Console.WriteLine(num[i]);
            }
        }
    }
}
