using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Tv : ISubscriber
    {
        public string Name { get; }
        public void Display()
        {
            Console.WriteLine("{0} {1} отключен", typeof(Tv), Name);
        }
        public Tv(string name)
        {
            Name = name;
        }
        public void Subscribed(object sender, EventArgs e)
        {
            Display();
        }
    }
}
