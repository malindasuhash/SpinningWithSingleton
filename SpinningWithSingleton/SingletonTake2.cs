using System;

namespace SpinningWithSingleton
{
    /// <summary>
    /// Implementation of single which is somewhat thread-safe.
    /// This is using double locking.
    /// </summary>
    public class SingletonTake2
    {
        private static volatile SingletonTake2 _instance; // Beware of the volatile!
        private static readonly object PadLock = new object();

        private SingletonTake2()
        {
            Console.WriteLine("Calling Ctor in SingletonTake2.");
        }

        public static SingletonTake2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (PadLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonTake2();
                        }
                    }    
                }

                return _instance;
            }
        } 
    }
}