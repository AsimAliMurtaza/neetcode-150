public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            // If the middle element is the target, return its index
            if (nums[mid] == target)
            {
                return mid;
            }
            // If the left part is sorted
            if (nums[left] <= nums[mid])
            {
                // Check if the target is in the left part
                if (nums[left] <= target && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                // If the right part is sorted
                // Check if the target is in the right part
                if (nums[mid] < target && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}
