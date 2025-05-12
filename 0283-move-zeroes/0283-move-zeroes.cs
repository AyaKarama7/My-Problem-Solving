public class Solution {
    public void MoveZeroes(int[] nums) {
        int z=nums.Length;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0&&z!=nums.Length)
            {
                nums[z]=nums[i];
                nums[i]=0;
                while(nums[z]!=0)z++;
                if(z==nums.Length)return;
            }
            else if(nums[i]==0)
            {
                if(z==nums.Length)z=i;
            }
        }
    }
}