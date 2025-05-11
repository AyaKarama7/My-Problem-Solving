public class Solution {
    
    public int ClimbStairs(int n) {
        if(n<=2)return n;
        int[] fepo=new int[n+1];
        fepo[1]=1;
        fepo[2]=2;
        for(int i=3;i<=n;i++)
        {
            fepo[i]=fepo[i-1]+fepo[i-2];
        }
        return fepo[n];
    }
}