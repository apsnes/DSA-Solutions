// Simulation
public class Solution
{
    public int NumSteps(string s)
    {
        var steps = 0;

        while (s.Length > 1)
        {
            if (s[^1] == '1')
            {
                // odd
                var sb = new StringBuilder(s);
                if (!s.Contains('0'))
                {
                    sb.Replace('1', '0');
                    sb.Insert(0, '1');
                }
                else
                {
                    for (int i = sb.Length -2; i >= 1; i--)
                    {
                        if (sb[i] == '0')
                        {
                            sb[i] = '1';
                            break;
                        }
                    }
                    sb[^1] = '0';  
                }             
                s = sb.ToString();
            }
            else
            {
                // even
                s = s[..^1];
            }
            steps++;
        }
        return steps;
    }
}

// Greedy
public class Solution
{
    public int NumSteps(string s)
    {
        var steps = 0;
        var carry = 0;
        var n = s.Length;

        for (int i = n - 1; i > 0; i--)
        {
            var curr = (s[i] - 0) + carry;
            if (curr % 2 == 1)
            {
                steps += 2;
                carry = 1;
            }
            else
            {
                steps++;
            }
        }    
        return steps + carry;
    }
}
