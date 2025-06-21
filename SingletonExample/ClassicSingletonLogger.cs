using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class ClassicSingletonLogger : SingletonBase
    {
        private static ClassicSingletonLogger? instance;

        private ClassicSingletonLogger()
        {
            // Private constructor to prevent instantiation
        }

        public static ClassicSingletonLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ClassicSingletonLogger();
            }
            return instance;
        }

    }
}
