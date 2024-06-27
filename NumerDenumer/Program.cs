using System;

namespace NumerDenumer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] solution(int numer1, int denom1, int numer2, int denom2)
            {
                int[] answer = new int[] { };
                
                if (numer1 <= 0 || denom1 <= 0 || numer2 <= 0 || denom2 <= 0 || numer1 >= 1000 || denom1 >= 1000 ||
                    numer2 >= 1000 || denom2 >= 1000)
                    throw new Exception("Invalid parameter");
                return answer;
            }
        }
    }
}