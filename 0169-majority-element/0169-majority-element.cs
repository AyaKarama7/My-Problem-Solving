public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);//2 3 3 
        int n=nums.Length;//3
        for(int i=0;i<=n-n/2;i++)
        {
            if(nums[i]==nums[i+n/2])return nums[i];
        }
        return 0;
    }
}