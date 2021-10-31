using Chain_of_Responsibility_Pattern.Concrete;
using Chain_of_Responsibility_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Withdraw withdraw = new Withdraw(1, 85000);
            Teller teller = new Teller();
            Manager manager = new Manager();
            AreaManager areaManager = new AreaManager();

            teller.SetNextEmployee(manager);
            manager.SetNextEmployee(areaManager);

            teller.Approve(withdraw);
            Console.ReadKey();
        }
    }
}
