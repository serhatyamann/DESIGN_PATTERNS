using Decorator_Pattern.Concrete;
using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component();
            Client.Display(component);
            Client.Display(new Decorator_A(component));
            Client.Display(new Decorator_B(component));
            Client.Display(new Decorator_A(new Decorator_B(component)));
            Console.ReadKey();

            #region Output
            //Hey there my name is Serhat

            //Hey there my name is Serhat
            //I am 28 years old

            //Hey there my name is Serhat
            //I am a software engineer

            //Hey there my name is Serhat
            //I am a software engineer
            //I am 28 years old
            #endregion
        }
    }
}
