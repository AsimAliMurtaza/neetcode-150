public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        //sort the array
        Array.Sort(nums);
        int currentSum = 0;
        List<List<int>> subarrays = new List<List<int>>();
        HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            //initialize two pointers starting from the next element and the last element
            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                //calculate the sum of the current triplet
                currentSum = nums[j] + nums[k];

                if (currentSum + nums[i] == 0)
                {
                    //if the sum is zero, add the triplet to the result
                    //use a HashSet to avoid duplicates
                    var triplet = new List<int>() { nums[i], nums[j], nums[k] };
                    string key = string.Join(",", triplet);
                    if (!seen.Contains(key))
                    {
                        seen.Add(key);
                        subarrays.Add(triplet);
                    }
                    //move both pointers inward to find other triplets
                    j++;
                    k--;
                }
                //if the sum is greater than zero, move the right pointer inwards
                else if (currentSum + nums[i] > 0)
                {
                    k--;
                }
                //if the sum is less than zero, move the left pointer inwards
                else
                {
                    j++;
                }
            }
        }
        return subarrays;
    }
}
