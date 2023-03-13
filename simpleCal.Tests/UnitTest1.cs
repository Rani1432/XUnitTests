using simpleCal.Controllers;

namespace simpleCal.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Multiplication()
        {
            var simpleController = new SimpleController();

            //act
            var result = simpleController.Multiplication(5,5);

            //assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void Addition()
        {
            var simpleController = new SimpleController();

            //act
            var result = simpleController.Addition(5, 5);

            //assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Substration()
        {
            var simpleController = new SimpleController();

            //act
            var result = simpleController.Substration(5, 5);

            //assert
            Assert.Equal(0, result);
        }
    }
}