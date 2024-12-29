// Time complexity: O(n)
// Space complexity: O(1)

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        //Maintain maxProduct variable to hold our answer
        int maxProduct = int.MinValue;
        //Initialise currentMin and currentMax variables to 1, as 1 can be used as a neutral number to avoid multiplying
        //by 0 or a negative number
        int currentMin = 1;
        int currentMax = 1;
        //Iterate through the array
        foreach (int num in nums)
        {
            //As currentMax is being overwritten, we need to store it in a temp variable for use in computing the currentMin
            int temp = currentMax;
            //Compute both currentMax and currentMin - this could be simply the num itself in cases where the number is
            //positive and multiplied by a negative integer. We need to check the max of currentProduct (num) * currentMin
            // and currentMax, as if negative numbers are invovled, the negatives multiplied together would result in the
            //largest positive integer
            currentMax = Math.Max(num, Math.Max(num * currentMin, num * temp));
            currentMin = Math.Min(num, Math.Min(num * currentMin, num * temp));
            //Update maxProduct if required
            maxProduct = Math.Max(maxProduct, currentMax);
        }
        return maxProduct;
    }
}
