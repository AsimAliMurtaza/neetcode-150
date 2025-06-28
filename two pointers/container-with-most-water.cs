public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;

        int maxArea = 0;

        while(left < right){
            //get the cells on x-axis (width of the bars, i.e how wide the bars are. will be useful for calculating area)
            int width = Math.Abs(right - left);
            //area = l x w but in our case, it's width x min(height[left], height[right])
            int currentArea = width * Math.Min(heights[left], heights[right]);
            //current area > max, set new max
            if(currentArea > maxArea){
                maxArea = currentArea;
            }
            //if height[left] is small, move forward by incrementing left
            if(heights[left] < heights[right]){
                left++;
            }
            //else decrement right if height[right] is smaller
            else{
                right--;
            }
        }
        return maxArea;
        }
    }