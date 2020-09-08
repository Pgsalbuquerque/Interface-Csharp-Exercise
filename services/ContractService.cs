using System;
using Contract.entities;

namespace Contract.services
{
    class ContractService
    {
        public Installment[] installments { get; set; }

        public int numberOfInstallments { get; set; }

        public ContractService(ContractClient contract, int numberOfInstallments,
            IOnlinePaymentServices onlinePaymentService)
        {
            this.numberOfInstallments = numberOfInstallments;

            this.installments = new Installment[numberOfInstallments];

            double value = (contract.amount / numberOfInstallments);


            for (int i = 1; i <= numberOfInstallments; i++)
            {
                DateTime date = DateTime.ParseExact(contract.date.AddMonths(i).ToString("dd/MM/yyyy"), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                double interest = onlinePaymentService.interest(value, i);
                double paymentFee = onlinePaymentService.paymentFee(value + interest);

                double valueInstallment = value + (interest + paymentFee);

                this.installments[i - 1] = new Installment(date, valueInstallment); ;
                
                
            }
            this.printInstallments();

        }

        public void printInstallments()
        {
            foreach (Installment installment in this.installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
