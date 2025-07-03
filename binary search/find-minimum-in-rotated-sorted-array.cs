public class Solution
{
    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            // To avoid overflow, use left + (right - left) / 2 instead of (left + right) / 2
            int mid = left + (right - left) / 2;
            // If mid is greater than right, it means the minimum is in the right half
            if (nums[mid] > nums[right])
            {
                // Move the left pointer to mid + 1
                left = mid + 1;
            }
            else
            {
                // If mid is less than or equal to right, it means the minimum is in the left half or at mid
                right = mid;
            }
        }
        // When left meets right, we have found the minimum element
        return nums[left];
    }
}
