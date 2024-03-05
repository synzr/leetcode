public class Solution {
    private string[] GetDigits (int number)
    {
        List<string> digits = new List<string>();

        if (number == 0)
        {
            digits.Add("0");
            return digits.ToArray();
        }

        if (number < 0)
        {
            number *= -1;
            digits.Add("-");
        }

        while (number != 0) 
        {
            int digit = number % 10;

            digits.Add(digit.ToString());
            number /= 10;
        }

        return digits.ToArray();
    }

    public bool IsPalindrome(int x)
    {
        string[] digits = GetDigits(x);

        for (int index = 0; index < digits.Length; index++)
        {
            int jndex = index == 0 ? digits.Length - 1 : digits.Length - (index + 1);
            
            if (digits[index] == digits[jndex])
            {
                return true;
            }
        }

        return false;
    }
}
