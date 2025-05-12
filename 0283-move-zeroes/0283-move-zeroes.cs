public class Solution {
    public void MoveZeroes(int[] nums) {
        int n=nums.Length,i=0;
        if(n==1)i=n;
        int z=n;
        for(;i<n;i++)
        {
            if(nums[i]!=0&&z!=n)
            {
                nums[z]=nums[i];
                nums[i]=0;
                while(nums[z]!=0)z++;
                if(z==n)i=n;
            }
            else if(nums[i]==0)
            {
                if(z==n)z=i;
            }
        }
    }
}