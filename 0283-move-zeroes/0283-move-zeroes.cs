public class Solution {
    public void MoveZeroes(int[] nums) {
        int n=nums.Length;
        if(n==1)return;
        int z=nums.Length;
        for(int i=0;i<n;i++)
        {
            if(nums[i]!=0&&z!=n)
            {
                nums[z]=nums[i];
                nums[i]=0;
                while(nums[z]!=0)z++;
                if(z==n)return;
            }
            else if(nums[i]==0)
            {
                if(z==n)z=i;
            }
        }
    }
}