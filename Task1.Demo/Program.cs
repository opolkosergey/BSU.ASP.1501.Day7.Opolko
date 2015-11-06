using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();
            var panasonic = new Tv("Panasonic");
            var lg = new Tv("LG");
            var human = new Human("John");

            timer.TimerCounted += panasonic.Subscribed;
            timer.TimerCounted += lg.Subscribed;
            timer.TimerCounted += human.Subscribed;
            timer.Run(1000);

            timer.TimerCounted -= panasonic.Subscribed;
            timer.Run(5000);

            Console.ReadKey();
        }
    }
}
