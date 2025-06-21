namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classsic Singleton Example
            SingletonBase singleton1 = ClassicSingletonLogger.GetInstance();
            SingletonBase singleton2 = ThreadSafeSingletonLogger.GetInstance();
            if (singleton1 == singleton2)
            {
                Console.WriteLine("Both singletons are the same instance.");
            }
            else
            {
                Console.WriteLine("Singletons are different instances.");
            }

            singleton1.Log("This is a log message from ClassicSingletonLogger.");

            // Thread-Safe Singleton Example
            SingletonBase threadSafeSingleton1 = ThreadSafeSingletonLogger.GetInstance();
            SingletonBase threadSafeSingleton2 = ThreadSafeSingletonLogger.GetInstance();
            if (threadSafeSingleton1 == threadSafeSingleton2)
            {
                Console.WriteLine("Both thread-safe singletons are the same instance.");
            }
            else
            {
                Console.WriteLine("Thread-safe singletons are different instances.");
            }
            threadSafeSingleton1.Log("This is a log message from ThreadSafeSingletonLogger.");

            //Lazy Generic Singleton Example
            SingletonBase lazySingleton1 = LazyGenericSingletonLogger.GetInstance();
            SingletonBase lazySingleton2 = LazyGenericSingletonLogger.GetInstance();
            if (lazySingleton1 == lazySingleton2)
            {
                Console.WriteLine("Both lazy singletons are the same instance.");
            }
            else
            {
                Console.WriteLine("Lazy singletons are different instances.");
            }

            lazySingleton1.Log("This is a log message from LazyGenericSingletonLogger.");

            //Static  Singleton Example
            SingletonBase staticSingleton1 = StaticSingletonLogger.GetInstance();
            SingletonBase staticSingleton2 = StaticSingletonLogger.GetInstance();

            if (staticSingleton1 == staticSingleton2)
            {
                Console.WriteLine("Both static singletons are the same instance.");
            }
            else
            {
                Console.WriteLine("Static singletons are different instances.");
            }
            staticSingleton1.Log("This is a log message from StaticSingletonLogger.");


        }
    }
}
