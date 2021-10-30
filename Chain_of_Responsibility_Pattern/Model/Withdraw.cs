using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern.Model
{
    public class Withdraw
    {
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }

        public Withdraw(int id, decimal amount)
        {
            CustomerId = id;
            Amount = amount;
        }
    }
}
