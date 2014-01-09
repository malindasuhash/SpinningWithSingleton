using System;

namespace SpinningWithSingleton
{
    /// <summary>
    /// This is a much safer implementation of singleton.
    /// </summary>
    /// <remarks>
    /// This is lot safer because the instance is created as the type is created.
    /// the caller simply returns this.
    /// May be better as there is no locking and it simply returns a created instance.
    /// The singleton instance is created in an eager fashion. 
    /// </remarks>
    public class SingletonTake3
    {
        private static readonly SingletonTake3 _instance = new SingletonTake3();

        private SingletonTake3()
        {
            Console.WriteLine("Calling Ctor in SingletonTake3.");
        }

        public static SingletonTake3 Instance
        {
            get { return _instance; }
        } 
    }
}