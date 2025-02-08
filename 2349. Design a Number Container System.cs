public class NumberContainers
{
    Dictionary<int, List<int>> NumbersAtIndexes;
    Dictionary<int, int> Indexes;

    public NumberContainers()
    {
        Indexes = new();
        NumbersAtIndexes = new();
    }
    
    public void Change(int index, int number)
    {
        if (Indexes.ContainsKey(index))
        {
            int prev = Indexes[index];
            NumbersAtIndexes[prev].Remove(index);
            if (NumbersAtIndexes[prev].Count == 0)
            {
                NumbersAtIndexes.Remove(prev);
            }
        }
        Indexes[index] = number;
        if (!NumbersAtIndexes.ContainsKey(number)) NumbersAtIndexes[number] = new List<int>();
        NumbersAtIndexes[number].Add(index);
    }
    
    public int Find(int number)
    {
        if (!NumbersAtIndexes.ContainsKey(number)) return -1;
        return NumbersAtIndexes[number].Min();
    }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */
