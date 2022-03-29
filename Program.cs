using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            
            //Convert the methods to threads
            Thread method1 = new Thread(() => LongRunningProcess.MethodA(5, 6));
            Thread method2 = new Thread(() => LongRunningProcess.MethodB(3, 4));
            Thread method3 = new Thread(() => LongRunningProcess.MethodC(6, 9));
            method1.Start();
            method2.Start();
            method3.Start();

            Console.WriteLine(mainThread.Name + " is complete");
        
        }

    }
    class LongRunningProcess
    {
        
        public bool longRunningProcess()
        {
            
            var a = MethodA(5, 6);
            var b = MethodB(5, 7);
            var c = MethodC(2, 9);

            Boolean a1 = Convert.ToBoolean(a);
            Boolean b1 = Convert.ToBoolean(b);
            Boolean c1 = Convert.ToBoolean(c);

            return a1 && b1 && c1;
        }
        
        // Created methods to visulaize the multithreading in real time.
        public static double MethodA(double x, double y)
        {
            double pointer;

            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + "seconds");
                Thread.Sleep(1000);
            }
            pointer = Math.Pow(x, y);
            Console.WriteLine("Timer #1 is complete and the pointer is : "+ pointer+ "!");
            return pointer;
        }
        public static double MethodB(double x, double y)
        {
            double pointer;
            
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + "seconds");
                Thread.Sleep(1000);
            }
            pointer = Math.Pow(x, y);
            Console.WriteLine("Timer #2 is complete and the pointer is : " + pointer + "!");
            return pointer;
        }
        public static double MethodC(double x, double y)
        {
            double pointer;
            
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #3: " + i + "seconds");
                Thread.Sleep(1000);
            }
            pointer = Math.Pow(x, y);
            Console.WriteLine("Timer #3 is complete and the pointer is : " + pointer + "!"); ;
            return pointer;
        }

    }

}

