using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.ExpDelegates;

namespace ConsoleApp.Week1Delegates
{
    public class DelegateConsumer
    {

        public static int ObjectCalculator2(int c)
        {
            return (c * c * c) / 2;
        }

        public void ConsumeDelegate()
        {
            var expDelegate = new ExpDelegate();
            Multiplier m1 = expDelegate.SquareArea;
            var result = m1(3);
            Console.WriteLine("Result [1]: " + result);

            var expDelegateCalculator = new ExpDelegateCalculator();
            Multiplier m2 = expDelegateCalculator.ObjectCapacityCalculator;

            m1 = expDelegateCalculator.ObjectCapacityCalculator;
            result = m1(3);
            Console.WriteLine("Result [2]: " + result);

            m1 = ObjectCalculator2;
            result = m1(3);
            Console.WriteLine("Result [3]: " + result);
        }

        public void ConsumeMulticastDelegate()
        {
            var expDelegate = new ExpDelegate();
            Multiplier m1 = expDelegate.SquareArea;

            var expDelegateCalculator = new ExpDelegateCalculator();
            m1 += expDelegateCalculator.ObjectCapacityCalculator;

            m1(9);

            Multiplier2 m2 = expDelegate.SomeRandomFunction;
            var r = m2();
        }
    }
}
