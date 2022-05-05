using System;
using ConsoleApp.ExpDelegates;
using ConsoleApp.Week1Delegates;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Week 1 - Delegates 
            UnderstandingDelegates();
        }

        public static void UnderstandingDelegates()
        {
            var example = new ExpDelegate();
            example.SimpleDelegateCaller();

            example.CallDelegateFor(true);
            example.CallDelegateFor(false);

            var consumeDelegate = new DelegateConsumer();
            consumeDelegate.ConsumeDelegate();

            consumeDelegate.ConsumeMulticastDelegate();
        }
    }
}
