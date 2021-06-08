using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentesImplementationsDeSingleton
{
    public sealed class SingletonSansLockTatalementDifferee
    {
        private SingletonSansLockTatalementDifferee() { }

        public static SingletonSansLockTatalementDifferee Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested() { }
            internal static readonly SingletonSansLockTatalementDifferee instance = 
                new SingletonSansLockTatalementDifferee();
        }
    }
}
