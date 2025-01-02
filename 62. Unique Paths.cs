//Space optimised DP solution with explanation:
public class Solution
{
    public int UniquePaths(int m, int n)
    {
        //Create an integer array which is the final row (m - 1) of the 2D array.
        //Fill the row array with 1, as it is impossible to move down from this
        //position, there is only one path to the end (right).
        int[] row = new int[n];
        Array.Fill(row, 1);
        //Iterate through the 2D array up to, but not including, the final row
        for (int i = 0; i < m - 1; i++)
        {
            //Create a newRow array for the current row we're on and set the final
            //value to 1, as, similarly to the above, there is only one route to
            //the end from here (down)
            int[] newRow = new int[n];
            newRow[^1] = 1;
            //Iterate through the current row backwards from n-2 to 0
            for (int j = n - 2; j >= 0; j--)
            {
                //The value for all indexes where i < m - 1 and j < n - 1
                //is equal to (i + 1, j) + (i, j + 1). We can get the values of 
                //i + 1 from our old row array.
                newRow[j] = newRow[j + 1] + row[j];
            }
            //Update the old row array to our current row for use in the next iteration
            //of the loop
            row = newRow;
        }
        //Our final value is equal to the value at index 0 of our final row array
        return row[0];
    }
}

//DP Cache solution:
public class Solution
{
    Dictionary<(int, int), int> dp = new(); 
    public int UniquePaths(int m, int n)
    {
        return CheckPaths(0, 0, m, n);
    }
    public int CheckPaths(int x, int y, int m, int n)
    {
        if (x == m - 1 && y == n - 1) return 1;
        if (x >= m || y >= n) return 0;
        if (dp.ContainsKey((x, y))) return dp[(x, y)];
        int result = CheckPaths(x + 1, y, m, n) + CheckPaths(x, y + 1, m, n);
        dp[(x, y)] = result;
        return result;
    }
}
