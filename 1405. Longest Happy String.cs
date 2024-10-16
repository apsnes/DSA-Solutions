public class Solution {
    public string LongestDiverseString(int a, int b, int c)
    {
        int maxLength = a + b + c;
        int currA = 0;
        int currB = 0;
        int currC = 0;
        StringBuilder sb = new();
        int i = 0;

        while (i < maxLength)
        {
            if (currA < 2 && a >= b && a >= c || a > 0 && (currB == 2 || currC == 2))
            {
                sb.Append('a');
                currA++;
                currB = 0;
                currC = 0;
                a--;
            }
            else if (currB < 2 && b >= a && b >= c || b > 0 && (currA == 2 || currC == 2))
            {
                sb.Append('b');
                currB++;
                currA = 0;
                currC = 0;
                b--;
            }
            else if (currC < 2 && c >= a && c >= b || c > 0 && (currB == 2 || currA == 2))
            {
                sb.Append('c');
                currC++;
                currA = 0;
                currB = 0;
                c--;                
            }
            i++;      
        }
        return sb.ToString();
    }
}
