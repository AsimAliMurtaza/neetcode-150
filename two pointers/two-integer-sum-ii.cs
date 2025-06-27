// This solution uses a dictionary to store the numbers and their indices.
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {

            int diff = target - numbers[i];
            if (seen.ContainsKey(diff))
            {
                return new int[] { seen[diff] + 1, i + 1 };
            }
            seen[numbers[i]] = i;
        }
        return new int[0];
    }
}
// This solution uses the two-pointer technique to find the two numbers that add up to the target.
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        // Since the array is sorted, we can use two pointers to find the two numbers that add up to the target
        for (int i = 0; i <= numbers.Length - 1; i++)
        {
            // If the sum of the two numbers is greater than the target, we move the right pointer to the left
            if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
            // If the sum of the two numbers is less than the target, we move the left
            else if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else if (numbers[left] + numbers[right] == target)
            {
                return new int[] { left + 1, right + 1 };
            }
        }
        return new int[] { };
    }
}
