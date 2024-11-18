public class Solution {
    public int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        int[] resultArray = new int[n];
        for(int i = 0; i < n; i++)
        {
            if (k > 0)
            {
                int sum = 0;
                for (int j = i + 1; j < i + 1 + k; j++)
                {
                    int index = j;
                    if (index >= n) index = index % n;
                    sum += code[index];
                }
                resultArray[i] = sum;
            }
            else if (k < 0)
            {
                int sum = 0;
                for (int j = i - 1; j > i - 1 - Math.Abs(k); j--)
                {
                    int index = j;
                    if (index < 0) index = ((index % n) + n) % n;
                    sum += code[index];
                }
                resultArray[i] = sum;
            }     
        }
        return resultArray;
    }
}
