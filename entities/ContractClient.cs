using System;
using Contract.entities;

namespace Contract.entities
{
    class ContractClient
    {
        public int number { get; private set; }
        public DateTime date { get; private set; }
        public double amount { get; private set; }
        

        public ContractClient(int number, DateTime date, double amount)
        {
            this.number = number;
            this.date = date;
            this.amount = amount;
        }
    }
}
