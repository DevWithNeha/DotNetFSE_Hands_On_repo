using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor razorPay = new RazorPay();
            razorPay.ProcessPayment(5000);

            IPaymentProcessor payPal = new PaymentAdapter();
            payPal.ProcessPayment(3000);

            Console.ReadKey();
        }
    }
}