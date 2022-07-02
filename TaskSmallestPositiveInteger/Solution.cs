namespace TaskSmallestPositiveInteger
{
    public static class Solution
    {
        public static int solution(int[] A)
        {
            int result=0;
            var tests = A.ToArray().Distinct().OrderBy(x=>x).Where(x=>x>0).ToList();
            if (!tests.Any())
            {
                return 1;
            }
            var max = tests.Max();
            for (int i = 1; i <= max; i++)
            {
                if (tests.Contains(i))
                {
                    result++;
                }
                if (!tests.Contains(i))
                {
                    result++;
                    break;
                }
                if (i == max)
                {
                    return result+1;
                }
            }
            return result;
        }
    }
}