// Greedy
public class Solution
{
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        Array.Sort(asteroids);
        long totalMass = mass;
        
        foreach (var a in asteroids)
        {
            if (totalMass >= a) totalMass += a;
            else return false;
        }
        return true;
    }
}


// Priorty Queue
public class Solution
{
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        long totalMass = mass;
        var pq = new PriorityQueue<int, int>();
        foreach (var a in asteroids) pq.Enqueue(a, a);
        while (pq.Count > 0)
        {
            var curr = pq.Dequeue();
            if (totalMass < curr) return false;
            totalMass += curr;
        }
        return true;
    }
}
