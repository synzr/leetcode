public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int index = 0; index < nums.Length; index++) {
            int currentNumber = nums[index];
            int complement = target - currentNumber;

            if (dictionary.ContainsKey(complement)) {
                int[] result = new int[] { dictionary[complement], index };
                return result;
            }

            dictionary.TryAdd(currentNumber, index);
        }

        return null;
    }
}
