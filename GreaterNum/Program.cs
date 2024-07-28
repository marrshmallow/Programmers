using System.Collections.Generic;

namespace GreaterNum
{
    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            // 제일 먼저 numbers의 길이부터 제한한 다음
            if (numbers.Length < 4 || numbers.Length > 1000000)
            {
                return null;
            }

            // numbers에 들어갈 수의 크기도 제한해 준다
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 1 || numbers[i] > 1000000)
                {
                    return null;
                }
            }

            // numbers의 길이는 n이라 정하고
            // numbers의 길이 만큼의 answer 행렬을 만든다
            int n = numbers.Length;
            var answer = new int[n];
            
            // 스택도 준비한다.
            var stack = new Stack<int>();

            // 안에 있는 모든 값을 일단 -1로 만든다
            for (int i = 0; i < n; i++)
            {
                answer[i] = -1;
            }
            
            // 처음에는 빈 스택으로 시작하기 때문에
            // numbers의 수를 뒤에서부터 하나씩 체크하면서 스택을 채워나간다
            //
            // 가장 뒤에 있는 수는 비교할 수가 없기 때문에
            // 그대로 스택에 그 수를 추가해 준다
            //
            // 그 다음 수를 확인했을 때, 바로 전 수보다 크다면 이 수가 뒷 큰수가 되고,
            // 따라서 스택을 갱신할 필요가 있다
            // 맨 위 값을 지우고 지금 수를 채워넣는다
            //
            // 그 다음 수를 확인했을 때, 바로 전 수보다 작다면 바로 전 수가 여전히 뒷 큰수가 되고,
            // 따라서 스택을 갱신할 필요가 없으니 그대로 두고
            // 답안의 i번 째 자리에 스택의 가장 위에 있는 수와 같은 수를 집어넣어 준다
            
            for (int i = n - 1; i >= 0; i--)
            {
                // 스택에 뭔가 있고 맨 위에 있는 값을 확인했을 때 그 값이 numbers의 i번째 값보다 작다면
                // = 뒷 큰수가 있었는데 지금 확인하는 값보다 현 시점의 뒷 큰수가 작다면
                // 이제 이 뒷 큰수는 더 이상 뒷 큰수가 아니게 된다
                while (stack.Count > 0 && stack.Peek() <= numbers[i])
                {
                    stack.Pop(); // 스택의 맨 위 값을 지운다
                }

                // 스택에 뭔가 있다면 = 뒷 큰수가 있다면
                if (stack.Count > 0)
                {
                    // 답안의 i번째 자리에 스택 가장 위에 위치한 값을 확인해서 똑같은 걸 넣어준다
                    answer[i] = stack.Peek();
                }

                // 스택에 i번째 값을 추가해 준다
                // (뒷 큰수가 갱신되었을 경우) 새 뒷 큰수를 추가해 준다
                stack.Push(numbers[i]);
            }
            
            return answer;
        }
    }
}