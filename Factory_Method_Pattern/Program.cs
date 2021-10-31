using Factory_Method_Pattern.Factory;
using Factory_Method_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerFactory computerFactory = new ComputerFactory();
            IComputer computer = computerFactory.CreateComputer("DELL");
            Console.WriteLine(computer.Brand());
            Console.ReadKey();

            #region Output
            //The brand of this computer is DELL
            #endregion
        }
    }
}
