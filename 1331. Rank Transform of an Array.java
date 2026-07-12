class Solution {
    public int[] arrayRankTransform(int[] arr) {
        if (arr.length == 0) return arr;
        var copy = arr.clone();
        Arrays.sort(copy);
        var ranks = new HashMap<Integer, Integer>();
        ranks.put(copy[0], 1);
        var currRank = 1;
        for (int i = 1; i < copy.length; i++) {
            if (copy[i] > copy[i - 1]) {
                currRank++;
                ranks.put(copy[i], currRank);
            }
        }

        var res = new int[arr.length];
        for (int i = 0; i < arr.length; i++) {
            res[i] = ranks.get(arr[i]);
        }

        return res;
    }
}
