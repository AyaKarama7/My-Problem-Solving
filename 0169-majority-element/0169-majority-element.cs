public class Solution {
    public int MajorityElement(int[] nums) {
        int n=nums.Length;//3
        if(n==1)return nums[0];
        Array.Sort(nums);//2 3 3 
        if(nums[0]==nums[n-1])return  nums[0];
        for(int i=0;i<n-n/2;i++)
        {
            if(nums[i]==nums[i+n/2])return nums[i];
        }
        return 0;
    }
}