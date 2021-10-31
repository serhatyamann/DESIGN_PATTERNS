using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Concrete
{
    public class Component : IComponent
    {
        public string Operation()
        {
            return "Hey there! My name is Serhat\n";
        }
    }
}
