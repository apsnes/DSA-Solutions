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
