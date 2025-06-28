public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            //if current price is less than minPrice, set minPrice to current price
            //this way, we always have the lowest price seen so far
            if (minPrice > prices[i])
            {
                minPrice = prices[i];
            }
            //calculate profit by subtracting minPrice from current price
            int currentProfit = prices[i] - minPrice;
            if (currentProfit > maxProfit)
            {
                maxProfit = currentProfit;
            }
        }
        return maxProfit;
    }
}

//this is another solution using two pointers or sliding window technique
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int left = 0;
        int right;
        //left pointer will always point to the lowest price seen so far
        //right pointer will iterate through the prices array
        for (right = 1; right < prices.Length; right++)
        {
            //if the price at right pointer is greater than the price at left pointer,
            if (prices[right] > prices[left])
            {
                //calculate the profit
                int currentProfit = prices[right] - prices[left];
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
            }
            else
            {
                //if the price at right pointer is less than or equal to the price at left pointer,
                //move the left pointer to the right
                left = right;
            }
        }
        return maxProfit;
    }
}
