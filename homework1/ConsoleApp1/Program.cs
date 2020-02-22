using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            while (true)
            {
                Console.WriteLine("输入q退出，输入回车继续");
                if (Console.ReadLine() == "q")
                    return;
                Console.WriteLine("输入两个数字");
                try
                {
                    a = Double.Parse(Console.ReadLine());
                    b = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("检查数字是否正确");
                    return;
                }
                Console.WriteLine("输入运算符");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"结果为{a + b}", a + b);
                        break;
                    case "-":
                        Console.WriteLine($"结果为{a - b}", a - b);
                        break;
                    case "*":
                        Console.WriteLine($"结果为{a * b}", a * b);
                        break;
                    case "/":
                        if (b != 0)
                            Console.WriteLine($"结果为{a / b}", a / b);
                        else
                            Console.WriteLine("除数不能为零");
                        break;
                    default:
                        Console.WriteLine("检查运算符");
                        break;
                }
            }
        }
    }
}
