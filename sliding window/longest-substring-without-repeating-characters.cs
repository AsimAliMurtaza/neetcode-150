public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        //hashset for seen chars
        HashSet<char> seen = new HashSet<char>();
        //two pointers, left and right
        int left = 0;
        int right = 0;
        int maxLength = 0;
        //iterate through the string with right pointer
        while (right < s.Length)
        {
            //if the char at right pointer is not in seen, add it to seen
            if (!seen.Contains(s[right]))
            {
                seen.Add(s[right]);
                //update maxLength if the current substring is longer
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            //if the char at right pointer is in seen, remove the char at left pointer from seen and move left pointer to the right
            else if (seen.Contains(s[right]))
            {
                seen.Remove(s[left]);
                left++;
            }

        }
        return maxLength;
    }
}
