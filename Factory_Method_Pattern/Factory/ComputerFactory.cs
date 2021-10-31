using Factory_Method_Pattern.Concrete;
using Factory_Method_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern.Factory
{
    public class ComputerFactory
    {
        public IComputer CreateComputer(string brandName)
        {
            if (string.IsNullOrEmpty(brandName))
            {
                return null;
            }
            if ("ASUS".Equals(brandName))
            {
                return new ASUS();
            }
            else if ("DELL".Equals(brandName))
            {
                return new DELL();
            }
            else if ("HP".Equals(brandName))
            {
                return new HP();
            }
            return null;
        }
    }
}
