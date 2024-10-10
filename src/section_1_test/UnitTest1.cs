namespace section_1_test;

using Xunit;
using section_1;

public class UnitTest1
{
    [Fact]
        public void Test_Add_TwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = Program.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }
}
