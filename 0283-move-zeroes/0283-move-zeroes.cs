public class Solution {
    public void MoveZeroes(int[] nums) {
        int n=nums.Length;
        int[] arr=new int[n];
        int l=0,r=n-1;
        for(int i=0;i<n;i++)
        {
            if(nums[i]==0)
            {
                arr[r]=0;
                r--;
            }
            else 
            {
                arr[l]=nums[i];
                l++;
            }
        }
        for(int i=0;i<n;i++)
        nums[i]=arr[i];
    }
}