using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class LazyGenericSingletonLogger : SingletonBase
    {
        private static readonly Lazy<LazyGenericSingletonLogger> lazyInstance =
            new Lazy<LazyGenericSingletonLogger>(() => new LazyGenericSingletonLogger());
        private LazyGenericSingletonLogger()
        {
            // Private constructor to prevent instantiation
        }
        public static LazyGenericSingletonLogger GetInstance()
        {
            return lazyInstance.Value;
        }

    }
}
