public class Solution {
    public string LongestPalindrome(string s) {
        string lp = "";
        int lpLength = 0;
        for(int i=0; i<s.Length;i++){
            int j=i; int k=i;
            while(j>=0 && k<s.Length && s[j] == s[k])
            {
                if(k-j+1 > lpLength)
                {
                    lpLength = k-j+1;
                    lp= s.Substring(j, k-j+1);
                }
                j--;
                k++;
            }

            j=i; k=i+1;

            while(j>=0 && k<s.Length && s[j]==s[k])
            {
                if(k-j+1 > lpLength)
                {
                    lpLength = k-j+1;
                    lp = s.Substring(j, k-j+1);
                }
                j--;
                k++;
            }
        }
        return lp;
    }
}
