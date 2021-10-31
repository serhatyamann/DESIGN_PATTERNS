using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Client
    {
        public static void Display(IComponent component)
        {
            Console.WriteLine(component.Operation());
        }
    }
}
