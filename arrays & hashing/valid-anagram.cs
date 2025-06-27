public class Solution {
    public bool IsAnagram(string s, string t) {
        //one solution is to sort the string and check if both equal or not
        char[] s1 = s.ToCharArray();
        char[] s2 = t.ToCharArray();

        Array.Sort(s1);
        Array.Sort(s2);

        string sortedS = new string(s1);
        string sortedT = new string(s2);

        if (sortedS == sortedT){
            return true;
        }else{
            return false;
        }
    }
}

//second solution: O(n) time complexity
public class Solution {
    public bool IsAnagram(string s, string t) {
        //we maake a dictionary to count the freq of the chars. If freq is the same for both strings, anagrams else not.
        Dictionary<char, int> ngrams = new Dictionary<char, int> ();

        foreach(char ch in s){
            //if key exists, increment the count, else add it with count 1
            if (ngrams.ContainsKey(ch))
            {
                ngrams[ch]++;
            }
            else
            {
                ngrams[ch] = 1;
            }
        }
        //check the second string
        foreach(char ch in t){
            //if the char is not in the dict or its count is 0, then its not an anagram
            //if the char is in the dict, we decrement its count
            if (!ngrams.ContainsKey(ch) || ngrams[ch] == 0)
            {
                return false;
            }
            else
            {
                ngrams[ch]--;
            }
        }
        //finally, we check if all counts are 0, if yes, then its an anagram
        foreach (var count in ngrams.Values)
        {
            if (count != 0) return false;
        }

        return true;
    }
}
