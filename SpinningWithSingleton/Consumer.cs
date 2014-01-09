namespace SpinningWithSingleton
{
    /// <summary>
    /// The consumer of the singletons.
    /// </summary>
    public class Consumer
    {
        public void Entry()
        {
            // Thread-unsafe singleton.    
            var instance1 = SingletonTake1.Instance;

            // Double-locked singleton
            var instance2 = SingletonTake2.Instance;

            // Lot better singleton.
            var instance3 = SingletonTake3.Instance;

            // Simple method call.
            SingletonTake4.SimpleMethod();

            // calling instance SingletonTake4
            var instance4 = SingletonTake4.Instance;

        }
    }
}