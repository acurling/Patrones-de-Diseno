using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseno
{
    internal class Singleton
    {
        private static Singleton instance;
        private static readonly object lockObject = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void SomeMethod()
        {
            // Implementación del método
        }
    }
}
