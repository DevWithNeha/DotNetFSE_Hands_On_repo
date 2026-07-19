using FactoryMethodPattern;
using System;

namespace factoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocument pdf = DocumentFactory.CreateDocument("PDF");
            pdf.Open();

            IDocument word = DocumentFactory.CreateDocument("WORD");
            word.Open();

            Console.ReadKey();
        }
    }
}