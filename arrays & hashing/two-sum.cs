public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //we will use a dictionary to store the numbers and their indices
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            //calculate the difference between the target and the current number
            int difference = target - nums[i];
            //if the difference is already in the dictionary, we have found the two numbers
            if (seen.ContainsKey(difference))
            {
                //return the indices of the two numbers
                return new int[] { seen[difference], i };
            }
            //if the difference is not in the dictionary, we add the current number and its index to the dictionary
            seen[nums[i]] = i;
        }
        return new int[] { };
    }
}
