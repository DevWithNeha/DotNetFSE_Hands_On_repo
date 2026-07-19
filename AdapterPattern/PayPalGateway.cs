using System;

namespace AdapterPattern
{
    public class PayPalGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of Rs.{amount} processed using PayPal.");
        }
    }
}