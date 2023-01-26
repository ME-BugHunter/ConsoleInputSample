using ConsoleInputSample;

namespace ProgramUnitTests
{
    public class ProgramTests
    {
       
        [Test]
        public void Test_ProgramSum_TwoPositiveNumbers()
        {
            //Arrange
            string input = "5 10 13";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.In

            //Act
            Program.InputNumbers();

            //Assert
            var actualResult = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "28" + Environment.NewLine;
          
            Assert.That(expectedResults, Is.EqualTo(actualResult));
        }

        [Test]
        public void Test_ProgramSum_TwoNegativeNumbers()
        {
            //Arrange
            string input = "-34 -10";
            var writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.In

            //Act
            Program.InputNumbers();

            //Assert
            var actualResult = writer.ToString();
            var expectedResults = "The sum is: " + Environment.NewLine + "-44" + Environment.NewLine;

            Assert.That(expectedResults, Is.EqualTo(actualResult));
        }
    }
}