public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int l=0, r=nums.Length-1;
        while(l<r)
        {
            if(nums[l]+nums[r]==target)return new int[]{l+1,r+1};
            else if(nums[l]+nums[r]<target)l++;
            else r--;
        }
        return new int[]{};
    }
}