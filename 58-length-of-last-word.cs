public class Solution {
    public int LengthOfLastWord(string s) {
        int characterCount = 0;

        for (int index = s.Length - 1; index >= 0; index--)
        {
            char character = s[index];

            if (character != ' ')
            {
                characterCount++;
                continue;
            }

            if (character == ' ' && characterCount > 0)
            {
                break;
            }
        }

        return characterCount;
    }
}
