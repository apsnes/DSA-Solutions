public class Solution
{
    public class DSU
    {
        private int n;
        private int[] size;
        private int[] representative;
        
        public DSU(int N)
        {
            n = N;
            size = new int[n];
            representative = new int[n];

            for (int i = 0; i < n; i++)
            {
                size[i] = 1;
                representative[i] = i;
            }
        }

        public int find(int node)
        {
            if (representative[node] == node) return node;
            return representative[node] = find(representative[node]);
        }

        public bool doUnion (int nodeOne, int nodeTwo)
        {
            nodeOne = find(nodeOne);
            nodeTwo = find(nodeTwo);

            if (nodeOne == nodeTwo) return false;
            else
            {
                if (size[nodeOne] > size[nodeTwo])
                {
                    representative[nodeTwo] = nodeOne;
                    size[nodeOne] += size[nodeTwo];
                }
                else
                {
                    representative[nodeOne] = nodeTwo;
                    size[nodeTwo] += size[nodeOne];
                }
                return true;
            }
        }
    }

    public int[] FindRedundantConnection(int[][] edges)
    {
        int n = edges.Length;
        DSU dsu = new(n);
        foreach (var edge in edges)
        {
            if (!dsu.doUnion(edge[0] - 1, edge[1] - 1)) return edge;
        }
        return new int[] { };    
    }
}
