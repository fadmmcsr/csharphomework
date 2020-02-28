using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数：");
            try
            {
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 2)
                {
                    Console.WriteLine("请输入能分解的数！");
                }
                Console.WriteLine("质因数有：");
                for (int i = 2; num != 1; i++)
                {
                    while (num % i == 0)
                    {
                        num /= i;
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("请输入整数！");
            }
           
        }
    }
}
