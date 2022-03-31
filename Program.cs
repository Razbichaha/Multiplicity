using System;

namespace Кратность
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = rnd.Next(1,27);
            Console.WriteLine("Число - " + n);

            for(int i =100;i<1000;i++)
            {
                //для проверки
                if (i % n == 0) { Console.Write(i+" - "); }
                //
                bool flag = true;
                int q=0 ;
                while(flag)
                {
                    q = q + n;
                    if (q == i) { Console.WriteLine(i); flag = false; }
                    if (q > i){ flag = false; }
                }


            }

        }
    }
}
