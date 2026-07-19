using System;

namespace AdapterPattern
{
    public class RazorPay : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Payment of Rs.{amount} processed using RazorPay.");
        }
    }
}