public class Solution
{
    public bool IsPalindrome(string s)
    {
        //inialize an empty string to store the cleaned characters
        string ss = "";
        foreach (char c in s)
        {
            //check if the character is alphanumeric, if yes, convert it to lowercase and add it to the string
            if (char.IsLetterOrDigit(c))
            {
                ss += char.ToLower(c);
            }
        }

        int left = 0;
        int right = ss.Length - 1;
        //use two pointers to check if the string is a palindrome
        while (left < right)
        {
            if (ss[left] != ss[right])
            {
                return false;
            }
            //move the pointers towards the center
            left++;
            right--;
        }

        return true;
    }
}
