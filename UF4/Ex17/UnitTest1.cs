using EjerciciosOOP;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Car myCar = new Car(0);
            int expectedFuel = 100;

            // Act
            bool result = myCar.Refuel(100);
            result = result && myCar.Fuel == expectedFuel;

            // Assert
            Assert.IsTrue(result);
        }
    }
}