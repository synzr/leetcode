public class Solution {
    private static Dictionary<char, char> _brackets = new Dictionary<char, char>()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };

    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();

        for (int index = 0; index < s.Length; index++)
        {
            char character = s[index];

            if (_brackets.ContainsKey(character))
            {
                brackets.Push(character);
            }
            else if (brackets.Count == 0 || character != _brackets[brackets.Pop()])
            {
                return false;
            }
        }

        return brackets.Count == 0;
    }
}
