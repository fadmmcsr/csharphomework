using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void TickHandler(object sender);
    public delegate void AlarmHandler(object sender);
    public class Clock
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        public int Second { get; set; }
        public void Start()
        {
            while (true)
            {
                OnTick(this);
                if (Second % 60 == 0)
                    OnAlarm(this);
            }
        }

    }
    public class Form
    {
        public Clock clock = new Clock();
        public Form()
        {
            clock.OnTick += new TickHandler(Tick);
            clock.OnAlarm += new AlarmHandler(Alarm);
        }
        void Tick(object sender)
        {
            System.Threading.Thread.Sleep(1000);
            clock.Second += 1;
            Console.WriteLine("过了" + clock.Second + "秒");
        }
        void Alarm(object sender)
        {
            Console.WriteLine("响铃！");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.clock.Start();
        }
    }
}
