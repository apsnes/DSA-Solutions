//Intuition - As the array is sorted, using two pointers we can always see what the smallest result can be from the
//value at the right pointer, from the values that we havent yet ruled out. Therefore we can simply add left + right
//together, and if the result is greater than target then we can decrement right, and if its lower than target, we
//can incremement left

//Example, target = 9
//-------------------------------
//| 2 | 3 | 4 | 5 | 8 | 10 | 11 |
//-------------------------------
//| L |   |   |   |   |    | R  |
//Sum = 2 + 11 = 13. 13 > 9. We cannot make the result any smaller by doing anything with the left pointer, as its already at its min
//value, so our only choice is to decrement the right pointer:
//-------------------------------
//| 2 | 3 | 4 | 5 | 8 | 10 | 11 |
//-------------------------------
//| L |   |   |   |   | R  |    |
//Sum = 2 + 10 = 12. 12 > 9. Same again, we must decrement right:
//-------------------------------
//| 2 | 3 | 4 | 5 | 8 | 10 | 11 |
//-------------------------------
//| L |   |   |   | R |    |    |
//Sum = 2 + 8 = 10. Once more, we decrement right:
//-------------------------------
//| 2 | 3 | 4 | 5 | 8 | 10 | 11 |
//-------------------------------
//| L |   |   | R |   |    |    |
//Sum = 2 + 5 = 7. 7 < 9. This time our value is too low. We already know that incrementing the right pointer will not help us, so
//we incrememnt the left pointer instead:
//-------------------------------
//| 2 | 3 | 4 | 5 | 8 | 10 | 11 |
//-------------------------------
//|   | L |   | R |   |    |    |
//Sum = 3 + 5 = 8. 8 < 9. Same again, increment left:
//-------------------------------
//| 2 | 3 | 4 | 5 | 8 | 10 | 11 |
//-------------------------------
//|   |   | L | R |   |    |    |
//Sum = 4 + 5 = 9. 9 == 9. We've found our two numbers that add up to target, so our ans[] = [ L, R ]

//Time complexity - O(n)
//Space complexity - O(1)

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        //Initiate pointers
        int left = 0, right = numbers.Length - 1;
        //While our pointers are at valid indicies
        while (left < right)
        {
            //If the total is too low, increment left
            if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            //if its too high, decrement right
            else if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
            //If not too high or too low, then we've found our answer. Add 1 to the indicies as the array in 1-indexed
            else return new int[] {left + 1, right + 1};
        }
        //Default return case - will never be reached as tests are guaranteed to contain exactly one working solution
        return new int[0];
    }
}
