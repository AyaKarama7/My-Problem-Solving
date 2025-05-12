public class Solution {
    public void MoveZeroes(int[] nums) {
        int pos=0,n=nums.Length;
        if(n==1)n=-1;
        for(int i=0;i<n;i++)
        {
            if(nums[i]!=0)nums[pos++]=nums[i];
        }
        while(pos<n)nums[pos++]=0;
    }
}