public class Solution
{
    public bool IsValid(string s)
    {
        // We can use a stack to keep track of the opening brackets
        // and check if they match with the closing brackets.
        Dictionary<char, char> pairs = new Dictionary<char, char>(){
            {')','('},
            {'}', '{'},
            {']', '['}
        };
        Stack<char> stack = new Stack<char>();
        // Iterate through each character in the string
        foreach (char ch in s)
        {
            // If the character is a closing bracket, we check if it matches the top of the stack
            if (pairs.ContainsKey(ch))
            {
                char top = stack.Count() > 0 ? stack.Pop() : '#';
                // If the top of the stack does not match the corresponding opening bracket, return false
                if (top != pairs[ch])
                {
                    return false;
                }
            }
            else
            {
                // If the character is an opening bracket, we push it onto the stack
                stack.Push(ch);
            }
        }
        return stack.Count == 0;
    }
}
