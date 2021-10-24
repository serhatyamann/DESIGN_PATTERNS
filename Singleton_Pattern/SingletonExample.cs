using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public partial class SingletonExample
    {
        private SingletonExample() { } //Private constructor.
        private static SingletonExample _instance;

        public static SingletonExample GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonExample();
            }
            return _instance;
        }
    }
}
