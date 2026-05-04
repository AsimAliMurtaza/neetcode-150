public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;
        for (int i = 0; i< 32; i++){
            uint bit = n & 1;
            res = (res << 1) | bit;
            n = n >> 1;
        }
        return res;
    }
}
