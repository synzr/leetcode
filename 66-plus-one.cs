public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int index = digits.Length - 1; index >= 0; index--)
        {
            if (digits[index] != 9)
            {
                digits[index] = digits[index] + 1 % 10;
                return digits;
            }

            digits[index] = 0;
        }

        Array.Resize(ref digits, digits.Length + 1);
        digits[0] = 1;

        return digits;
    }
}
