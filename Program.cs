using System;

namespace Кратность
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumberRandom = new Random();

            int randomNumber = NumberRandom.Next(1,27);
            Console.WriteLine("Число - " + randomNumber);

            for(int i =100;i<1000;i++)
            {
                bool stopCicle = true;
                int summand = 0;

                while(stopCicle)
                {
                    summand = summand + randomNumber;
                    if (summand == i) { Console.WriteLine(i); stopCicle = false; }
                    if (summand > i){ stopCicle = false; }
                }
            }
        }
    }
}
