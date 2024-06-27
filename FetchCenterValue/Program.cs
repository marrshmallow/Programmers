using System;

namespace FetchCenterValue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int solution(int[] array)
            {
                int answer = 0;
            
                // 중요 조건 : "순서대로 정렬했을 때"
                // 중앙값의 인덱스는 배열 길이를 2로 나눈 값에 1을 더한 것이다.
            
                for(int i = 0; 0 < i && i < 100; i++)
                {
                    if (array[i] <= -1000 || array[i] >= 1000)
                        throw new Exception ("Invalid parameter");
                    else
                    {
                        int center = (array.Length / 2) + 1;
                        answer = array[center];
                    }
                }
                return answer;
            }
        }
    }
}