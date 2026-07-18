using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetInstance();

            Singleton obj2 = Singleton.GetInstance();

            obj1.ShowMessage();

            if (obj1 == obj2)
            {
                Console.WriteLine("Both objects are same.");
            }
            else
            {
                Console.WriteLine("Objects are different.");
            }

            Console.ReadKey();
        }
    }
}