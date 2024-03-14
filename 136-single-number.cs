public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.Aggregate((first, second) => first ^ second);
    }
}
