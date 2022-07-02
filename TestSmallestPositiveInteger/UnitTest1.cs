using TaskSmallestPositiveInteger;
using Xunit;

namespace TestSmallestPositiveInteger
{
    public class UnitTest1
    {
        [Fact]
        public void GetSmallestPositiveNumberFromArray1()
        {
            //arrange
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };//5

            //Act
            var result = Solution.solution(A);

            //assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void GetSmallestPositiveNumberFromArray2()
        {
            //arrange
            int[] A = new int[] { 1, 2, 3 };//4

            //Act
            var result = Solution.solution(A);

            //assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void GetSmallestPositiveNumberFromArray3()
        {
            //arrange
            int[] A = new int[] { -1, -3 };//1

            //Act
            var result = Solution.solution(A);

            //assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void GetSmallestPositiveNumberFromArray4()
        {
            //arrange
            int[] A = new int[] { -1, -3, 0, 1, 3, 4, 6 };//2

            //Act
            var result = Solution.solution(A);

            //assert
            Assert.Equal(2, result);
        }
    }
}