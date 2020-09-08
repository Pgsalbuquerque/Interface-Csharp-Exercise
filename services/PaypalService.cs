
using Contract.services;

namespace Contract.services
{
    class PaypalService : IOnlinePaymentServices
    {
        public double paymentFee(double amount) 
        {
            System.Console.WriteLine((amount * 0.02));
            return (amount * 0.02);
        }

        public double interest(double amount, int installment) 
        {
            System.Console.WriteLine((amount * 0.01 * installment));
            return (amount * 0.01 * installment);
        }
    }
}
