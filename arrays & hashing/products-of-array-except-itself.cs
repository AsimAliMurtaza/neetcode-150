public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] products = new int[nums.Length];
        // We will use two arrays to store the products of all elements to the left and right of each index
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        // Initialize the first element of left to 1, as there are no elements to the left of the first element
        left[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            // The product of all elements to the left of index i is the product of all elements to the left of index i-1 multiplied by the element at index i-1
            left[i] = left[i - 1] * nums[i - 1];
        }
        // Initialize the last element of right to 1, as there are no elements to the right of the last element
        right[nums.Length - 1] = 1;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            // The product of all elements to the right of index i is the product of all elements to the right of index i+1 multiplied by the element at index i+1
            right[i] = right[i + 1] * nums[i + 1];
        }
        // Now we can calculate the product of all elements except the current element by multiplying the left and right products
        for (int i = 0; i < nums.Length; i++)
        {
            products[i] = left[i] * right[i];
        }
        return products;
    }
}
