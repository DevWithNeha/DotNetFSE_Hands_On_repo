using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Console.WriteLine("Gaming Computer");
            ComputerBuilder gaming = new GamingComputerBuilder();
            director.Construct(gaming);
            gaming.GetComputer().Show();

            Console.WriteLine("Office Computer");
            ComputerBuilder office = new OfficeComputerBuilder();
            director.Construct(office);
            office.GetComputer().Show();

            Console.ReadKey();
        }
    }
}