using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpinningWithSingleton;

namespace Runner
{
    /// <summary>
    /// Simple runner.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Executes the entry.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var consumer = new Consumer();
            consumer.Entry();

            Console.ReadKey();
        }
    }
}
