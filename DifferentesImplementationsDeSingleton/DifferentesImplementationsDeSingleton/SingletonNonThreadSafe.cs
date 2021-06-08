using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentesImplementationsDeSingleton
{
   public sealed class SingletonNonThreadSafe
    {
        private static SingletonNonThreadSafe instance = null;

        private SingletonNonThreadSafe() { }

        public static SingletonNonThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonNonThreadSafe();
                }
                return instance;
            }
        }
    }
}
