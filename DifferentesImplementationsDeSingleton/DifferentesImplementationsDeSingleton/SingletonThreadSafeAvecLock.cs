using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentesImplementationsDeSingleton
{
    public sealed class SingletonThreadSafeAvecLock
    {
        private static SingletonThreadSafeAvecLock instance = null;
        private static readonly object padlock = new object();
        SingletonThreadSafeAvecLock() { }

        public static SingletonThreadSafeAvecLock Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafeAvecLock();
                    }
                    return instance;
                }
            }
        }
    }
}
