public class ProductOfNumbers
{
    private List<int> pre = new();
    private int size = 0;
    public ProductOfNumbers()
    {
        pre.Add(1);
    }
    
    public void Add(int num)
    {
        if (num == 0)
        {
            pre = [ 1 ];
            size = 0;
            return;
        }
        else
        {
            pre.Add(pre[size] * num);
            size++;
        }
    }
    
    public int GetProduct(int k)
    {
        if (k > size) return 0;
        return pre[size] / pre[size - k];
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */
