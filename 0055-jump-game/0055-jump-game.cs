public class Solution {
    public bool CanJump(int[] nums) {
        int mx=0,n=nums.Length;
        if(n==1)return true;
        for(int i=0;i<n;i++)
        {
            if(i>mx)return false;
            if(mx<(i+nums[i]))mx=i+nums[i];
        }
        return true;
    }
}