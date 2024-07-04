namespace BrownYellowCarpet;

public class Solution
{
    public int[] solutison(int brown, int yellow)
    {
        int[] answer = new int[] {};
        if (brown <= 8 || 5000 < brown || yellow <= 0 || 2000000 < yellow)
        {
            throw new Exception("Invalid parameter!");
        }
        else if (brown < yellow)
        {
            throw new Exception("Height cannot be longer than width!");
        }
   
        //brown = 4 * yellow - 2 + 4;
        
        return answer;
    }
}