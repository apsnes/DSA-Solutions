public class Solution
{
    public int[][] HighestPeak(int[][] isWater)
    {
        //Queue to store coordinates of 'waves', starting from original water positions
        Queue<(int rows, int cols)> queue = new();
        //Loop through matrix, find water positions, and enqueue them. All non water positions marked with -1 so that we can identify if they've been visited yet or not.
        for (int i = 0; i < isWater.Length; i++)
        {
            for (int j = 0; j < isWater[0].Length; j++)
            {
                if (isWater[i][j] != 1) isWater[i][j] = -1;
                else
                {
                    isWater[i][j] = 0;
                    queue.Enqueue((i, j));
                }
            }
        }
        //Continue looping until queue is empty
        while (queue.Count > 0)
        {
            //Retrieve current coordinates from queue and corresponding current value from the grid
            var curr = queue.Dequeue();
            int currRow = curr.rows;
            int currCol = curr.cols;
            int currentVal = isWater[currRow][currCol];
            //Check if each direction coordinate is 1. in bounds and 2. if it is yet to be visited (value is -1)
            if (currRow - 1 >= 0) if (isWater[currRow - 1][currCol] == -1) 
            {
                //If it hasn't yet been visited, set its value to currentvalue +1, and enqueue it for processing
                isWater[currRow - 1][currCol] = currentVal + 1;
                queue.Enqueue((currRow - 1, currCol));
            }
            if (currRow + 1 < isWater.Length) if (isWater[currRow + 1][currCol] == -1)
            {
                isWater[currRow + 1][currCol] = currentVal + 1;
                queue.Enqueue((currRow + 1, currCol));
            }
            if (currCol + 1 < isWater[0].Length) if (isWater[currRow][currCol + 1] == -1) 
            {
                isWater[currRow][currCol + 1] = currentVal + 1;
                queue.Enqueue((currRow, currCol + 1));
            }
            if (currCol - 1 >= 0) if (isWater[currRow][currCol - 1] == -1) 
            {
                isWater[currRow][currCol - 1] = currentVal + 1;
                queue.Enqueue((currRow, currCol - 1));
            }
        }
        //Return the modified grid
        return isWater;
    }
}
