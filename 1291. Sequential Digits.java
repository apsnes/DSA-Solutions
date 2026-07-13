class Solution {
    public List<Integer> sequentialDigits(int low, int high) {
        if (high < low) return new ArrayList<Integer>();
        var digits = new ArrayList<Integer>();
        var template = "123456789";
        var lowStr = String.valueOf(low);
        var highStr = String.valueOf(high);

        for (int length = lowStr.length(); length <= highStr.length(); length++) {
            for (int index = 0; index + length <= template.length(); index++) {
                var currStr = template.substring(index, index + length);
                var num = Integer.parseInt(currStr);
                if (num >= low && num <= high) digits.add(num);
            }
        }

        return digits;
    }
}
