using System;

namespace SpinningWithSingleton
{
    /// <summary>
    /// Another implementation of singleton.
    /// </summary>
    /// <remarks>
    /// The singleton object is created very lazily. This means only when the instance is
    /// asked. This allows us to have other methods in the singleton instance that does
    /// not create an instance of <see cref="SingletonTake4"/>.
    /// </remarks>
    public class SingletonTake4
    {
         private class SingletonTake4Internal
         {
             private static SingletonTake4 _take4 = new SingletonTake4();

             public static SingletonTake4 SingletonTake4
             {
                 get { return _take4; }
             }
         }

        private SingletonTake4()
        {
            Console.WriteLine("Calling Ctor in SingletonTake4.");
        }

        public static SingletonTake4 Instance
        {
            get { return SingletonTake4Internal.SingletonTake4; }
        }

        public static void SimpleMethod()
        {
            Console.WriteLine("Running simple method in SingletonTake4");
        }
    }
}