using Adapter;

namespace TestDesignPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Move_ShouldReturnExpectedString()
        {
            // Arrange
            var car = new Car();
            var railAdapter = new RailAdapter(car);

            // Act
            var actualOutput = railAdapter.Move();

            // Assert
            var expectedOutput = "Car is moving to rail";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void Move_ShouldNotModifyOriginalCarObject()
        {
            // Arrange
            var car = new Car();
            var railAdapter = new RailAdapter(car);

            // Act
            railAdapter.Move();

            // Assert
            Assert.AreEqual("Car is moving", car.Move());
        }
        [TestMethod]
        public void Stop_ShouldReturnExpectedString()
        {
            // Arrange
            var car = new Car();
            var railAdapter = new RailAdapter(car);

            // Act
            var actualOutput = railAdapter.Stop();

            // Assert
            var expectedOutput = "Car Stopped...";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}