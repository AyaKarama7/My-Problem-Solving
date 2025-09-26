public class Solution {
    public int FindPeakElement(int[] nums) {
        int n=nums.Length;
        int mx=nums[0];
        int idx=0;
        for(int i=1;i<n;i++)
        {
            if(nums[i]>mx)
            {
                mx=nums[i];
                idx=i;
            }
        }
        return idx;
        
    }
}