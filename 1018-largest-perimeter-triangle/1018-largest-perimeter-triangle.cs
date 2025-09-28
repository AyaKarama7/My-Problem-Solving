public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        int n=nums.Length;
        int ans=0;
        for(int i=n-1;i>=2;i--)
        {
            int l=i-2,r=i-1;
            if(nums[l]+nums[r]>nums[i])
            {
                return (nums[i]+nums[l]+nums[r]);
            }
        }   
        return 0;
    }
}