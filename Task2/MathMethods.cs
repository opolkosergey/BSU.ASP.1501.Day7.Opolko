using System.Collections.Generic;

namespace Task2
{
    public static class MathMethods
    {
        public static IEnumerable<int> Fibonacci(int count)
        {
            if (count == 1)
            {
                yield return 1;
                yield break;
            }
            
            for (var i = 0; i < 2; i++)
            {
                yield return 1;
            }

            int x = 1, y = 1;
            for (var i = 2; i < count; i++)
            {
                var result = x + y;
                x = y;
                y = result;
                yield return result;
            }
        }
    }
}
