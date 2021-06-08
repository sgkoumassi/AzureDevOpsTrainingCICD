using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentesImplementationsDeSingleton
{
    public sealed class SingletonSansLockDiffereeAvecLazy
    {
        private static readonly Lazy<SingletonSansLockDiffereeAvecLazy> lazy =
            new Lazy<SingletonSansLockDiffereeAvecLazy>(() => 
            new SingletonSansLockDiffereeAvecLazy());

        private static SingletonSansLockDiffereeAvecLazy Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private SingletonSansLockDiffereeAvecLazy() { }
    }
}
