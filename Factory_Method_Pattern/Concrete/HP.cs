using Factory_Method_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern.Concrete
{
    public class HP : IComputer
    {
        public string Brand()
        {
            return "The brand of this computer is HP";
        }
    }
}
