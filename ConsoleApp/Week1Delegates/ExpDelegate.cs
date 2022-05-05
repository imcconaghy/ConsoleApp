using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.ExpDelegates
{
    // declaring a delegate
    public delegate int Multiplier(int x);

    public delegate int Multiplier2();

    public class ExpDelegate
    {
        
        // definding a compatible method or function
        public int SquareArea(int side)
        {
            return side * side;
        }

        // definding another compatible method or function
        public int ObjectCapacity(int side)
        {
            return 2 * side;
        }

        public int SomeRandomFunction()
        {
            return 5;
        }

        public void SimpleDelegateCaller()
        {
            CallSimpleDelegate();
        }


        public void CallSimpleDelegate()
        {
            // creating a delegate instance
            Multiplier m = SquareArea;

            // creating a delegate instance (slightly more complicated)
            Multiplier m2 = new Multiplier(SquareArea);

            // invoking the delegate => invokes the method
            int area = m(5);

            // above is a short hand way of the following
            int area2 = m.Invoke(6);

            // show the result i.e printline 
            Console.WriteLine("area is: " + area);
        }

        public void CallDelegateFor(bool isSquare)
        {
            if (isSquare)
            {
                Multiplier m = SquareArea;
                int area = m(5);
                Console.WriteLine("For area result is: " + area);
                return;
            }

            Multiplier o = ObjectCapacity;
            int result = o(6);
            Console.WriteLine("For obj capacity result is: " + result);
        }
    }
}
