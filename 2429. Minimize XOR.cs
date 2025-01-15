public class Solution
{
    public int MinimizeXor(int num1, int num2)
    {
        int result = num1;
        int num2Bits = BitOperations.PopCount((uint)num2);
        int setBits = BitOperations.PopCount((uint)result);
        int currentBit = 0;
        while (setBits != num2Bits)
        {
            if (setBits < num2Bits)
            {
                if (!isSet(result, currentBit))
                {
                    result = setBit(result, currentBit);
                    setBits++;
                }
            }
            else
            {
                if (isSet(result, currentBit))
                {
                    result = unsetBit(result, currentBit);
                    setBits--;
                }
            }
            currentBit++;
        }
        return result;
    }
    private bool isSet(int x, int bit)
    {
        return (x & (1 << bit)) != 0;
    }
    private int setBit(int x, int bit)
    {
        return x | (1 << bit);
    }
    private int unsetBit(int x, int bit)
    {
        return x & ~(1 << bit);
    }
}
