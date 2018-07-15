using System;

namespace structures_c_
{   
    class Program
    {
     static void Main(string[] args)
        {
            LinkedLIsts<int> Lists = new LinkedLIsts<int>();
            Lists.Add(12);
            Lists.Add(6);
            Lists.Add(64);
            Lists.Add(124);
            Lists.Add(256);
            Lists.Add(512);
            Lists.Add(1084);
            System.Console.WriteLine(Lists.Size() + " test");
            System.Console.WriteLine(Lists.Get(3));
        }
    }
}
