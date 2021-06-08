using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentesImplementationsDeSingleton
{
    public sealed class SingletonThreadSafeSansLock
    {
        private static readonly SingletonThreadSafeSansLock instance = new SingletonThreadSafeSansLock();

        static SingletonThreadSafeSansLock() { }

        private static SingletonThreadSafeSansLock Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
