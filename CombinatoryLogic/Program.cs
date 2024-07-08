using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Solution
{
    // 2차원 배열인 clothes를 만든다.
    // 1차원은 "의상"을, 2차원은 카테고리를 나타낸다.
    public int solution(string[,] clothes)
    {
        // string은 의상의 분류, int는 그 분류에 속한 의상의 가짓수
        Dictionary<string, int> clothesDict = new Dictionary<string, int>();
        
        // 의상을 분류해서 사전에 집어넣는다
        // clothes.GetLength(0)의 0은 clothes 배열의 1차원 값, 즉 의상의 가짓수를 나타낸 것
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            // 코니가 가진 의상의 수는 1개 이상 30개 이하이므로
            // 모든 카테고리에는 적어도 1개의 의상이 들어간다는 가정으로
            // clothes 배열의 1차원 길이만큼 카테고리를 집어 넣어 준다
            string category = clothes[i, 1];
            
            // 문자열에 포함시킬 것들을 지정하고 길이를 1 이상 20이하로 설정
            // Regex Pattern
            // ^ 스트링 시작을 표시
            // [a-zA-Z_] 알파벳 대소문자를 포함하고 언더바를 포함한다. 대소문자 구분 없음.
            // $ 스트링 끝을 표시
            string pattern = @"^[a-zA-Z_]{1,20}$";
            if (!Regex.IsMatch(category, pattern))
            {
                throw new Exception("Invalid input");
            }
            
            // 그리고 만약 사전의 카테고리란에 어떤 값이 있다면
            // = 사전의 키가 일치하는 항목이 이미 있을 경우
            if (clothesDict.ContainsKey(category))
            {
                //사전의 해당 카테고리에 항목을 하나 추가해준다
                clothesDict[category]++;
            }
            else // 그렇지 않으면
            {
                //사전 속 해당 카테고리에는 단 하나의 의상이 들어가게 된다.
                clothesDict[category] = 1;
            }
        }
        
        // 조합을 계산
        // 적어도 하나의 조합이 있을 수 있으므로 초기값을 1로 지정
        int combinations = 1;
        
        // 첫번째 카테고리의 가짓수에다가 다음 카테고리의 가짓수를 계속 곱해나간다
        foreach (var count in clothesDict.Values)
        {
            combinations *= (count + 1); // 해당 의상을 안 입는 경우의 수도 더해주기
        }
        
        // 아무것도 입지 않은 단 하나의 경우를 제외해 준 값을 반환
        return combinations - 1;
    }
}