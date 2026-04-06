public class Solution
{
    HashSet<(int, int)> blocks = new();

    public int RobotSim(int[] commands, int[][] obstacles)
    {
        var currLocation = (0, 0);
        var currDirection = Direction.North;
        var maxDistance = 0.0;

        foreach (var o in obstacles)
        {
            blocks.Add((o[0], o[1]));
        }

        foreach (var cmd in commands)
        {
            if (cmd < 0)
            {
                currDirection = Rotate(currDirection, cmd);
            }
            else
            {
                currLocation = Walk(currDirection, currLocation, cmd);
                maxDistance = Math.Max(maxDistance, CalculateDistance(currLocation));
            }
        }

        return (int)maxDistance;
    }

    private double CalculateDistance((int x, int y) currLocation)
    {
        return Math.Pow(currLocation.x, 2) + Math.Pow(currLocation.y, 2);
    }

    private (int x, int y) Walk(Direction walkingDirection, (int x, int y) currLocation, int command)
    {
        for (int i = 0; i < command; i++)
        {
            var nextLocation = currLocation;
            if (walkingDirection == Direction.North) nextLocation = (currLocation.x, currLocation.y + 1);
            if (walkingDirection == Direction.South) nextLocation = (currLocation.x, currLocation.y - 1);
            if (walkingDirection == Direction.East) nextLocation = (currLocation.x + 1, currLocation.y);
            if (walkingDirection == Direction.West) nextLocation = (currLocation.x - 1, currLocation.y);
            if (blocks.Contains(nextLocation)) break;
            currLocation = nextLocation;
        }
        return currLocation;
    }

    private Direction Rotate(Direction startingDirection, int command)
    {
        var tuple = (startingDirection, command);
        return tuple switch
        {
            (Direction.North, -2) => Direction.West,
            (Direction.North, -1) => Direction.East,
            (Direction.East, -2) => Direction.North,
            (Direction.East, -1) => Direction.South,
            (Direction.South, -2) => Direction.East,
            (Direction.South, -1) => Direction.West,
            (Direction.West, -2) => Direction.South,
            (Direction.West, -1) => Direction.North,
            _ => throw new ArgumentException("Invalid Direction")
        };
    }
}

public enum Direction
{
    North,
    East,
    South,
    West
}
