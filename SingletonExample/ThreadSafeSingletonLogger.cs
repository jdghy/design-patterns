using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class ThreadSafeSingletonLogger : SingletonBase
    {
        private static ThreadSafeSingletonLogger? instance;
        private static readonly object lockObject = new object();// Lock object for thread safety
        private ThreadSafeSingletonLogger()
        {
            // Private constructor to prevent instantiation
        }
        public static ThreadSafeSingletonLogger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingletonLogger();
                    }
                }
            }
            return instance;
        }
        
    }
}
