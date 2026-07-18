using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
            Console.WriteLine("Singleton Object Created");
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton Object");
        }
    }
}