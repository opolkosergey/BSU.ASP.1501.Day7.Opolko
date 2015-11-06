using System;

namespace Task1
{
    public class Human : ISubscriber
    {
        public string Name { get; }
        public void Display()
        {
            Console.WriteLine("{0} {1} уведомлен", typeof(Human), Name);
        }
        public Human(string name)
        {
            Name = name;
        }
        public void Subscribed(object sender, EventArgs e)
        {
            Display();
        } 
    }
}
