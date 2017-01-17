using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace AreaCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        public static string ConstructAndCall(string choice,params double[] list)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape shape = shapeFactory.GetShape(choice,list);
            string expected = shape.CalculateArea().Display();
            return expected;
        }
        [TestMethod]
        public void GivingInvalidChoice_ShouldThrowException()
        {
            
            try
            {
                string expected = ConstructAndCall("5", 2);
            }
            catch(System.Exception ex)
            {
                Assert.AreEqual("Incorrect Shape", ex.Message, "Invalid choice");
            }
        }
        [TestMethod]
        public void GivingCharacterAsChoice_ShouldThrowException()
        {

            try
            {
                string expected = ConstructAndCall("dscs", 2);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual("Incorrect Shape", ex.Message, "Invalid choice");
            }
        }
        [TestMethod]
        public void CalculateAreaOfCircle_WithValidChoiceAndValidRadius_ShouldDisplayString()
        {
            string expected= ConstructAndCall("circle", 2);
            Assert.AreEqual("Area of the circle is 12.56", expected, "Areas are not same");
        }
        [TestMethod]
        public void CalculateAreaOfRectangle_WithValidChoiceAndValidSides_ShouldDisplayString()
        {
            string expected = ConstructAndCall("rectangle", 2, 2);
            Assert.AreEqual("Area of the rectangle is 4", expected, "Areas are not same");
        }
        [TestMethod]
        public void CalculateAreaOfTriangle_WithValidChoiceAndValidsides_ShouldDisplayString()
        {
            string expected = ConstructAndCall("triangle", 3, 2);
            Assert.AreEqual("Area of the triangle is 3", expected, "Areas are not same");
        }
        [TestMethod]
        public void CalculateAreaOfCircle_GivingValidChoice_AndInvalidNumberOfSides_ShouldThrowException()
        {

            try
            {
                string expected = ConstructAndCall("circle", 2,3);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual("Should pass only one radius", ex.Message, "Invalid choice");
            }
        }
        [TestMethod]
        public void CalculateAreaOfRectangle_GivingValidChoice_AndInvalidNumberOfSides_ShouldThrowException()
        {

            try
            {
                string expected = ConstructAndCall("rectangle", 2, 3,4);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual("Should have only 2 parameters", ex.Message, "Invalid choice");
            }
        }
        [TestMethod]
        public void CalculateAreaOfTriangle_GivingValidChoice_AndInvalidNumberOfSides_ShouldThrowException()
        {

            try
            {
                string expected = ConstructAndCall("triangle", 2, 3, 4);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual("Should have only 2 parameters", ex.Message, "Invalid choice");
            }
        }
        [TestMethod]
        public void CalculateAreaOfTriangle_GivingValidChoice_AndNegativeSides_ShouldThrowException()
        {

            try
            {
                string expected = ConstructAndCall("triangle", 2, -3);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual("Height is out of range", ex.Message, "Invalid choice");
            }
        }
        [TestMethod]
        public void CalculateAreaOfRectangle_GivingValidChoice_AndNegativeSides_ShouldThrowException()
        {

            try
            {
                string expected = ConstructAndCall("rectangle", 2, -3);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual("Breadth is out of range", ex.Message, "Invalid choice");
            }
        }
        [TestMethod]
        public void CalculateAreaOfCircle_GivingValidChoice_AndNegativeSides_ShouldThrowException()
        {

            try
            {
                string expected = ConstructAndCall("circle", -3);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual("Radius is out of range", ex.Message, "Invalid choice");
            }
        }
    }
}
