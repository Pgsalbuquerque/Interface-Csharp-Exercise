using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.services
{
    interface IOnlinePaymentServices
    {
        double paymentFee(double amount);

        double interest(double amount, int installment);
    }
}
