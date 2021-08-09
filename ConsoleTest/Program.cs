using System;
using System.Threading;

namespace ConsoleTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Teste 1 | Result 1,5
            Console.WriteLine(Avarage.Average(2, 1));
            //Teste 3 | Result 752
            Console.WriteLine(ReadWriteExecute.SymbolicToOctal("rwxr-x-w-"));
            //Teste 4 | Result flo, fle, fla 
            foreach (var p in Prefix.AllPrefixes(3, new string[] { "flow", "flowers", "flew", "flag", "fm" }))
                Console.WriteLine(p);
            //Teste 5 | Result True
            UnloadingTime();
            //Teste 6 | Result 5 1 2 3 4
            Racer();
        }

        private static void UnloadingTime()
        {
            var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

            UnloadingTime[] unloadingTimes = new UnloadingTime[]
            {
            new UnloadingTime(DateTime.Parse("3/4/2019 19:00", format), DateTime.Parse("3/4/2019 20:30", format)),
            new UnloadingTime(DateTime.Parse("3/4/2019 22:10", format), DateTime.Parse("3/4/2019 22:30", format)),
            new UnloadingTime(DateTime.Parse("3/4/2019 20:30", format), DateTime.Parse("3/4/2019 22:00", format))
            };

            Console.WriteLine(UnloadingTrucks.CanUnloadAll(unloadingTimes));
        }

        private static void Racer()
        {
            Thread t1 = new(new Racer("1").Run);
            Thread t2 = new(new Racer("2").Run);
            Thread t3 = new(new Racer("3").Run);
            Thread t4 = new(new Racer("4").Run);
            Thread t5 = new(new Racer("5").Run);

            t1.Start();
            t2.Start();
            t5.Start();
            t1.Join();
            t2.Join();
            t3.Start();
            t3.Join();
            t4.Start();
        }
    }
}
