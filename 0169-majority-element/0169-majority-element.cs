public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int c=1,i=0,k=nums[0],f=1;
        while(i+1<nums.Length&&f==1)
        {
            i++;
            if(nums[i]==k)c++;
            else 
            {
                if(c>(nums.Length/2))
                {
                    f=0;
                }
                else 
                {
                    k=nums[i];
                    c=1;
                }
            }
        }
        return k;
    }
}