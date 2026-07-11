class Solution {
    public int countCompleteComponents(int n, int[][] edges) {
        var adj = BuildAdjacencyList(n, edges);
        var adjFreq = new HashMap<List<Integer>, Integer>();
        var res = 0;

        for (int i = 0; i < n; i++) {
            var neighbours = adj[i];
            Collections.sort(neighbours);
            if (!adjFreq.containsKey(neighbours)) adjFreq.put(neighbours, 0);
            adjFreq.put(neighbours, adjFreq.get(neighbours) + 1);
        }

        for (var kvp : adjFreq.entrySet()) {
            if (kvp.getKey().size() == kvp.getValue()) res++;
        }

        return res;
    }

    private List<Integer>[] BuildAdjacencyList(int n, int[][] edges) {
        List<Integer>[] adj = new ArrayList[n];
        for (int i = 0; i < n; i++) {
            adj[i] = new ArrayList<>();
            adj[i].add(i);
        }
        for (var edge : edges) {
            adj[edge[0]].add(edge[1]);
            adj[edge[1]].add(edge[0]);
        }
        return adj;
    }
}
