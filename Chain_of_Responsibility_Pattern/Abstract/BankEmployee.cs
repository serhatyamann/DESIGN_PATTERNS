using Chain_of_Responsibility_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern.Abstract
{
    public abstract class BankEmployee
    {
        protected BankEmployee _nextEmployee;

        public void SetNextEmployee(BankEmployee bankEmployee)
        {
            this._nextEmployee = bankEmployee;
        }
        public abstract void Approve(Withdraw request);
    }
}
