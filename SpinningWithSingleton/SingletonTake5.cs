using System;

namespace SpinningWithSingleton
{
    /// <summary>
    /// This is the Lazy version of the singleton.
    /// </summary>
    /// <remarks>
    /// The instance is created very lazily.
    /// </remarks>
    public class SingletonTake5
    {
        private static readonly Lazy<SingletonTake5> _instance = new Lazy<SingletonTake5>(() => new SingletonTake5());

        private SingletonTake5()
        {
            Console.WriteLine("Calling Ctor in SingletonTake5.");
        }

        public static SingletonTake5 Instance
        {
            get { return _instance.Value; }
        }  
    }
}