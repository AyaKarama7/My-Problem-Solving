public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int n=strs.Length,m=201;
        if(n<=1)return strs[0];
        string res="";
        foreach(var s in strs)m=Math.Min(m,s.Length);
        for(int j=0;j<m;j++)
        {
            
            char num=strs[0][j];

            for(int i=0;i<n;i++)
            {
                if(num!=strs[i][j])return res;
            }
            res+=num;
        }
        return res;
    }
}