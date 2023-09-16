using Adapter;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            IRailAdapter railAdapter = new RailAdapter(car);
            // Adaptee interface is incompatible with the client. But with adapter client can call it's method
            Console.WriteLine(railAdapter.Move());
            Console.WriteLine("after moving some distance");
            Console.WriteLine(railAdapter.Stop());
        }
    }
}
