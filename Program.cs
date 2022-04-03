using System;

namespace Кратность
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberRandom = new Random();

            int startRandom = 1;
            int stopRandom = 27;
            int randomNumber = numberRandom.Next(startRandom,stopRandom);
            Console.WriteLine("Число - " + randomNumber);
            int startNumber = 100;
            int stopNumber = 1000;

            for (int i=randomNumber;i<stopNumber;i=i+randomNumber)
            {
                if (i >= startNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
