public class MinStack {

    Stack<int> Stack;
    Stack<int> Prefix;

    public MinStack() {
        Stack = new();
        Prefix = new();
    }
    
    public void Push(int val) {
        Stack.Push(val);
        if (Prefix.Count > 0)
        {
            Prefix.Push(Math.Min(val, Prefix.Peek()));
        }
        else
        {
            Prefix.Push(val);
        }
    }
    
    public void Pop() {
        Prefix.Pop();
        Stack.Pop();
    }
    
    public int Top() {
        return Stack.Peek();
    }
    
    public int GetMin() {
        return Prefix.Peek();
    }
}
