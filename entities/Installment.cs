using System;


namespace Contract.entities
{
    class Installment
    {
        public DateTime date { get; set; }
        public double amount { get; set; }

        public Installment(DateTime date, double amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public override string ToString()
        {
            return this.date.ToString("dd/MM/yyyy") + " --- " + this.amount;
        }
    }
}
