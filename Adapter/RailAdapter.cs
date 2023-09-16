namespace Adapter
{
     public class RailAdapter : IRailAdapter
     {
         private readonly Car _car;

         // Constructs a new RailAdapter object with the given Car object.
         // Parameter: car - The Car object to adapt.
         public RailAdapter(Car car)
         {
             this._car = car;
         }
        
         public string Move()
         {
             return $"{this._car.Move()} to rail";
         }
        
         // Stops the car on a rail.
         // Return: A string indicating that the car has stopped on a rail.
         public string Stop()
         {
             return $"{this._car.Stop()}";
         }
     }
}