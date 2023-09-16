namespace Adapter
{
    // IRailAdapter interface
    // Defines the interface for a rail adapter object.
    public interface IRailAdapter
    {
        // Moves the car on a rail.
        // Return: A string indicating that the car is moving on a rail.
        string Move();

        // Stops the car on a rail.
        // Return: A string indicating that the car has stopped on a rail.
        string Stop();
    }
}