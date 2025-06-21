using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class StaticSingletonLogger : SingletonBase
    {
        private static readonly StaticSingletonLogger instance = new StaticSingletonLogger();

        private StaticSingletonLogger()
        {
            // Private constructor to prevent instantiation
        }

        public static StaticSingletonLogger GetInstance()
        {
            return instance;
        }
    }
}
