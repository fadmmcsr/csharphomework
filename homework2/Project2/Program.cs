using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("输入数组长度");
            length = Convert.ToInt32(Console.ReadLine());
            if (length < 1)
                Console.WriteLine("数组长度要大于0！");
            int[] num = new int[length];
            Console.WriteLine("输入" + length + "个数");
            try
            {
                for (int i = 0; i < length; i++)
                {
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("输入有误！");
            }
            int max = num[0], min = num[0], sum = 0;
            double average;
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                if (num[i] >= max)
                    max = num[i];
                if (num[i] <= min)
                    min = num[i];
                sum += num[i];
            }
            average = sum / length;
            Console.WriteLine("最大值为" + max);
            Console.WriteLine("最小值为" + min);
            Console.WriteLine("平均值为" + average);
            Console.WriteLine("和为" + sum);
        }
    }
}
