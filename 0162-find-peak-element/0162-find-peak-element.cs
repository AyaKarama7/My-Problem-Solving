public class Solution {
    public int FindPeakElement(int[] nums) {
        int n=nums.Length;
        if(n==1)return 0;
        if(nums[0]>nums[1])return 0;
        if(nums[n-1]>nums[n-2])return n-1;
        int l=1,h=n-1;
        while(l<=h)
        {
            int mid=(l+h)/2;
            if(nums[mid]>nums[mid-1]&&nums[mid]>nums[mid+1])return mid;
            else if(nums[mid]<nums[mid+1])l=mid+1;
            else h=mid-1;
        }
        return -1;
        
    }
}