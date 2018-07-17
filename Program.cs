using System;

namespace structures_c_
{   
    class Program
    {
     static void Main(string[] args)
        {
            // LinkedLIsts<int> Lists = new LinkedLIsts<int>();
            // Lists.Add(12);
            // Lists.Add(6);
            // Lists.Add(64);
            // Lists.Add(124);
            // Lists.Add(256);
            // Lists.Add(512);
            // Lists.Add(1084);
            // // System.Console.WriteLine(Lists.Size() + " Lists Size");
            // Lists.GetChain();
            // Lists.Remove(0);

            CustomQueue<int> Queuery = new CustomQueue<int>();
            Queuery.Add(14);
            Queuery.Add(18);
            Queuery.Add(19);
            Queuery.Add(20);
            Queuery.Add(21);

            Queuery.Remove();

            StackBasedOnArray<int> StackOnArray = new StackBasedOnArray<int>();
            StackOnArray.Push(15);
            StackOnArray.Push(20);
            StackOnArray.Push(25);
            StackOnArray.Pop();
            StackOnArray.Pop();
            StackOnArray.Push(30);
            StackOnArray.Push(35);

            Deque<int> DeDeque = new Deque<int>();
            DeDeque.Push(15);
            DeDeque.Push(20);
            DeDeque.Push(25);
            
            // get initial size:
            // System.Console.WriteLine(DeDeque.DequeSize() + " size start");

            // should be return * 15 *
            // System.Console.WriteLine(DeDeque.TakeFirst());

            // remove one:
            // DeDeque.Pop();

            // should be return * 15 *
            // System.Console.WriteLine(DeDeque.TakeFirst());

            // Shift method testing...
            DeDeque.Shift(11);

            DeDeque.Push(30);
            DeDeque.Shift(7);
            DeDeque.Pop();
            System.Console.WriteLine(DeDeque.TakeLast());
            // should be return * 11 *
            // System.Console.WriteLine(DeDeque.TakeFirst());
            System.Console.WriteLine(DeDeque.DequeSize() + " size start");
            System.Console.WriteLine(DeDeque.TakeFirst());
            DeDeque.Unshift();
            System.Console.WriteLine(DeDeque.TakeFirst());
            System.Console.WriteLine(DeDeque.DequeSize() + " size FINISH");
            DeDeque.Shift(173);
            System.Console.WriteLine(DeDeque.TakeFirst());
            DeDeque.Push(190);
            System.Console.WriteLine(DeDeque.TakeFirst());
            System.Console.WriteLine(DeDeque.TakeLast());

            // get updated size: * 3 *
            // System.Console.WriteLine(DeDeque.DequeSize() + " size finish");
        }
    }
}
