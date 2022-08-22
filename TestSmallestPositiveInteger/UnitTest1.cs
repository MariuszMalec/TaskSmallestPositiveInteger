using TaskSmallestPositiveInteger;
using Xunit;

namespace TestSmallestPositiveInteger
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( new int[] { 1, 3, 6, 4, 1, 2 },5)]
        [InlineData(new int[] { 1,2,3 }, 4)]
        [InlineData(new int[] { -1, -3 }, 1)]
        [InlineData(new int[] { -1, -3, 0, 1, 3, 4, 6 }, 2)]
        public void GetSmallestPositiveNumberFromArray(int[] value1, int value2)
        {
            //arrange

            //Act
            var result = Solution.solution(value1);

            //assert
            Assert.Equal(value2, result);
        }
    }
}