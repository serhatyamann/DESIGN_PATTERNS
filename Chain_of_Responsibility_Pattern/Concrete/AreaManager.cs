using Chain_of_Responsibility_Pattern.Abstract;
using Chain_of_Responsibility_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chain_of_Responsibility_Pattern.Concrete
{
    public class AreaManager : BankEmployee
    {
        public override void Approve(Withdraw request)
        {
            if (request.Amount > 60000)
            {
                Console.WriteLine("Your request has been approved by area manager!");
            }
        }
     }
}
