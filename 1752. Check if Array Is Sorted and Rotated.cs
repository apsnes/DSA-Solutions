// One pass count solution
public class Solution
{
    public bool Check(int[] nums)
    {
        var count = 0;
        var prev = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < prev) count++;
            prev = nums[i];
        }

        return count == 0 || (count == 1 && nums[0] >= nums[^1]);
    }
}

// Reconstruct array
public class Solution
{
    public bool Check(int[] nums)
    {
        var n = nums.Length;
        if (n == 0) return true;
        var prev = nums[0];
        var pivotIndex = -1;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < prev)
            {
                pivotIndex = i;
                break;
            }
            prev = nums[i];   
        }
        if (pivotIndex == -1) return IsSorted(nums);

        var newArr = new int[n];
        var leftArr = nums[..pivotIndex];
        var rightArr = nums[pivotIndex..];

        var newArrIndex = 0;
        for (int i = 0; i < rightArr.Length; i++)
        {
            newArr[newArrIndex] = rightArr[i];
            newArrIndex++;
        }
        for (int i = 0; i < leftArr.Length; i++)
        {
            newArr[newArrIndex] = leftArr[i];
            newArrIndex++;
        }

        return IsSorted(newArr);
    }

    private bool IsSorted(int[] arr)
    {
        var prev = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < prev) return false;
            prev = arr[i];
        }
        return true;
    }
}
