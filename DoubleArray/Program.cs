using System;

namespace DoubleArray
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            int[] solution(int[] numbers)
            {
                int[] answer = new int[] { };
        
                for (int i = 1; 0 < i && i < 1001; i++)
                {
                    if (-10000 > numbers[i] || 10000 > numbers[i])
                        throw new Exception("Invalid parameter!");
                    else answer[i] = numbers[i] * 2;
                }
                return answer;
            }
        }
    }
}