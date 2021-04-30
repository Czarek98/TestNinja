using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Math
    {
        /// <summary>
        /// funkcja dodajaca dwie liczby całkowite
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>zwraca sume liczb a i b</returns>
        public int Add(int a, int b)
        { 
            return a + b;
        }
        
        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i; 
            //yield - przez niego nie wyjdzie z returna
            //z 1szą wartością tylko przekaże dalej
        }
    }
}