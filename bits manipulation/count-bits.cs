public class Solution {
    public int[] CountBits(int n) {
        int[] arr = new int[n+1];
        int count = 0;
        for (int i = 0; i <= n; i++){
            int c = i;
            while(c != 0){
                c = c & (c - 1);
                count += 1;
            }
        arr[i] = count;
        count = 0;
        }
        return arr;
    }
}
