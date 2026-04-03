public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var stack = new Stack<Car>();
        var cars = new List<Car>();
        var n = position.Length;

        for (int i = 0; i < n; i++)
        {
            cars.Add(new Car(position[i], speed[i]));
        }

        cars = cars.OrderBy(x => x.Position).ToList();

        stack.Push(cars[^1]);

        for (int i = n - 2; i >= 0; i--)
        {
            var currTop = stack.Peek();
            var topTime = (target - currTop.Position) / (currTop.Speed * 1.0);
            var currTime = (target - cars[i].Position) / (cars[i].Speed * 1.0);

            if (currTime <= topTime) continue;
            stack.Push(cars[i]);
        }

        return stack.Count;
    }
}

public record Car(int position, int speed)
{
    public int Position = position;
    public int Speed = speed;
}
