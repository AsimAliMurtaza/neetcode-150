public class Solution {

    public string Encode(IList<string> strs) {
        string finalString = "";

        for(int i = 0; i< strs.Count; i++){
	//take each string
            string s = strs[i];
            int length = s.Length;
		//concatenate the string with its length and a delimiter
           finalString = finalString + length.ToString() + "#" + s;
        }
        return finalString;
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        int i = 0;
        while( i < s.Length){
	//search for '#' with j = i and increment until found
            int j = i;

            while(s[j] != '#'){
                j++;
            }
		//when 3 found, calculate the length of the orginal string from i to j - 1 
		//i.e say "3#cat", i = 0; j - 1=0; so substring at 0 index is our length
            int length = int.Parse(s.Substring(i, j-i));
		//extract the substring from the string from j + 1 to the length
            string word = s.Substring(j + 1, length);

            strs.Add(word);
		//jump to next block by updating i to j+1 + length pos. i.e "3#cat4#rain"
		// i will be 2+3 = 5 so s[i] = "4". our next block.
            i = j+1 + length;
        }
        return strs;
   }
}
