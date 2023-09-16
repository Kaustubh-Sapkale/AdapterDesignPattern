using Adapter;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Car object.
            Car car = new Car();

            // Create a new RailAdapter object with the Car object.
            IRailAdapter railAdapter = new RailAdapter(car);

            // Move the car on a rail.
            Console.WriteLine(railAdapter.Move());

            // Stop the car on a rail.
            Console.WriteLine("after moving some distance");
            Console.WriteLine(railAdapter.Stop());
        }
    }
}
