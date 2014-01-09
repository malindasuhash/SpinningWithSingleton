using System;

namespace SpinningWithSingleton
{
    /// <summary>
    /// Implementation of very basic Singleton (not thread-safe).
    /// </summary>
    public class SingletonTake1
    {
        private static SingletonTake1 _instance;

        private SingletonTake1()
        {
            Console.WriteLine("Calling Ctor in SingletonTake1.");
        }

        public static SingletonTake1 Instance
        {
            get { return _instance ?? (_instance = new SingletonTake1()); }
        }
    }
}