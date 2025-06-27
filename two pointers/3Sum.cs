public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        int currentSum = 0;
        List<List<int>> subarrays = new List<List<int>>();
        HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                currentSum = nums[j] + nums[k];

                if (currentSum + nums[i] == 0)
                {
                    var triplet = new List<int>() { nums[i], nums[j], nums[k] };
                    string key = string.Join(",", triplet);
                    if (!seen.Contains(key))
                    {
                        seen.Add(key);
                        subarrays.Add(triplet);
                    }
                    j++;
                    k--;
                }
                else if (currentSum + nums[i] > 0)
                {
                    k--;
                }
                else
                {
                    j++;
                }
            }
        }
        return subarrays;
    }
}
