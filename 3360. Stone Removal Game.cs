public class Solution {
    public bool CanAliceWin(int n)
    {
        int currentRemoval = 10;
        int turns = 0;
        while (n >= currentRemoval)
        {
            n -= currentRemoval;
            currentRemoval--;
            turns++;
        }
        return turns % 2 != 0;
    }
}
