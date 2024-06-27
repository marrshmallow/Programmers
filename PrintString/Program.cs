namespace PrintString;
using System;

public class Example
{
    public static string str;
    
    public static void Main()
    {
        Console.Clear();
        str = Console.ReadLine();
        
        if (str.Length < 1 || str.Length > 1000000)
        {
            throw new Exception("Invalid parameter");
        }

        char[] chars = str.ToCharArray(); // 받은 스트링을 문자로 쪼개서, 문자를 담는 배열을 새로 만들어 거기에 담는다
        Array stringArray = new Array [str.Length];
        if (str.Contains(' '))
        {
        }
        
    }
}