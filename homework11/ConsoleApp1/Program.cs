using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Console.WriteLine("欢迎进入订单系统！\n");
            int method;
            bool stop = false;
            while(!stop)
            {
                Console.WriteLine("输入数字继续：1、添加订单，2、修改订单，3、删除订单，4、查询订单，0、退出\n");
                method = Convert.ToInt32(Console.ReadLine());
                switch(method)
                {
                    case 1:
                        service.AddOrder();
                        break;
                    case 2:
                        service.UpdateOrder();
                        break;
                    case 3:
                        service.DeleteOrder();
                        break;
                    case 4:
                        service.QueryOrder();
                        break;
                    case 0:
                        stop = true;
                        break;
                }
            }
        }
    }
}
