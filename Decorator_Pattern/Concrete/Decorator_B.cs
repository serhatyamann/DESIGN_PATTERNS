using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Concrete
{
    public class Decorator_B : IComponent
    {
        private IComponent _component;
        public Decorator_B(IComponent component)
        {
            this._component = component;
        }
        public string Operation()
        {
            return _component.Operation() + "I am a software engineer\n";
        }
    }
}
