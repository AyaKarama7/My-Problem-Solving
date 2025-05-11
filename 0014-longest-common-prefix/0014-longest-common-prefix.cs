public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        int len=strs[0].Length;
        int l=1,r=len,mid=0;
        while(l<=r)
        {
            mid=(l+r)/2;
            if(IsCommon(strs,mid)==true)l=mid+1;
            else r=mid-1;
        }
        return strs[0].Substring(0,(l+r)/2);
    }
    public bool IsCommon(string[] strs,int mid)
    {
        for(int i=0;i<mid;i++)
        {
            foreach(var s in strs)
            {
                if(s[i]!=strs[0][i])return false;
            }
        }
        return true;
    }
}