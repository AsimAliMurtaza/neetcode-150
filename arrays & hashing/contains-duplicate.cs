public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> chars = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            //we chec if the dict already has a matching key for the value, if true, its a duplicate
            if (chars.ContainsKey(nums[i]))
            {
                return true;
            }
            //else we add the number to dict
            chars.Add(nums[i]);
        }
        //return false if no dups found
        return false;
    }
}