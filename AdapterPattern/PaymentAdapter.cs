namespace AdapterPattern
{
    public class PaymentAdapter : IPaymentProcessor
    {
        private PayPalGateway payPal = new PayPalGateway();

        public void ProcessPayment(double amount)
        {
            payPal.MakePayment(amount);
        }
    }
}