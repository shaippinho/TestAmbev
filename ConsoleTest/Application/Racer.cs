using System;
using System.Threading;

namespace ConsoleTest
{
    public class Racer
    {
        private readonly string name;

        public Racer(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Thread.Sleep(100);
            Console.WriteLine(name);
        }
    }
}
