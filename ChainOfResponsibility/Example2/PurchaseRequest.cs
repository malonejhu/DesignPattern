using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example2
{
    internal class PurchaseRequest
    {
        private double amount;
        private int number;
        private string purpose;

        public PurchaseRequest(double amount, int number, string purpose)
        {
            this.amount = amount;
            this.number = number;
            this.purpose = purpose;
        }

        public double Amount 
        {
            get { return amount; }
            set { amount = value; }
        }

        public int Number 
        {
            get { return number; }
            set { number = value; }
        }

        public string Purpose
        {
            get{ return purpose; }
            set { purpose = value; }
        }
    }
}