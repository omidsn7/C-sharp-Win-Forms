using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            #region rrrrrrrrrrrrr
            // Main execution starts here  
            //Console.WriteLine("Main thread starts here.");

            //// This method takes 4 seconds to finish.  
            //Thread backgroundThread = new Thread(new ThreadStart(Program.DoSomeHeavyLifting));
            //// Start thread  
            //backgroundThread.Start();
            //// This method doesn't take anytime at all.  
            //Program.DoSomething();

            //// Execution ends here  
            //Console.WriteLine("Main thread ends here.");
            //Console.ReadKey();
            //Thread workerThread = new Thread(new ThreadStart(Print));
            //// Start secondary thread  
            //workerThread.Start();

            //// Main thread : Print 1 to 10 every 0.2 second.   
            //// Thread.Sleep method is responsible for making the current thread sleep  
            //// in milliseconds. During its sleep, a thread does nothing.  
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Main thread: {i}");
            //    Thread.Sleep(200);
            //}

            //Thread currentThread = Thread.CurrentThread;
            //Console.WriteLine("Thread Id {0}: ", currentThread.ManagedThreadId);
            //Console.WriteLine("Is thread background: {0}", currentThread.IsBackground);
            //Console.WriteLine("Priority: {0}", currentThread.Priority);
            //Console.WriteLine("Culture: {0}", currentThread.CurrentCulture.Name);
            //Console.WriteLine("UI Culture: {0}", currentThread.CurrentUICulture.Name);
            //Console.WriteLine();
            //Console.ReadKey();
            #endregion

        }

        private static void Print()
        {
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
                Thread.Sleep(1000);
            }
        }

        public static void DoSomeHeavyLifting()
        {
            Console.WriteLine("I'm lifting a truck!!");
            Thread.Sleep(1000);
            Console.WriteLine("Tired! Need a 3 sec nap.");
            Thread.Sleep(1000);
            Console.WriteLine("1....");
            Thread.Sleep(1000);
            Console.WriteLine("2....");
            Thread.Sleep(1000);
            Console.WriteLine("3....");
            Console.WriteLine("I'm awake.");
        }
        public static void DoSomething()
        {
            Console.WriteLine("Hey! DoSomething here!");
            for (int i = 0; i < 20; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine("I'm done.");
        }
    }
}
