using System;
using Contract.entities;
using Contract.services;

namespace Contract
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter contract data\nNumber: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());
            Console.WriteLine("Installments:");

            ContractClient contract = new ContractClient(number, date, value);
            ContractService contractService = new ContractService(contract, numberOfInstallments, new PaypalService());
        }
    }
}
