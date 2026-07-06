public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int i=0;
        int j=0;
        int max = 0;
        HashSet<char> set = new HashSet<char>();

        while(j<s.Length)
        {
            if(!set.Contains(s[j]))
            {
                set.Add(s[j]);
                max = Math.Max(max, j-i+1);
                j++;
            }
            else {
                set.Remove(s[i]);
                i++;
            }
        }
        return max;
    }
}
