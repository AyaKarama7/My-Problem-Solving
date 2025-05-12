public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int k=nums[0],num=nums[0],mx=1,c=1;
        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]==num)c++;
            else
            {
                if(mx<c)
                {
                    mx=c;
                    k=num;
                }
                c=1;
                num=nums[i];
            }
        }
        if(c>mx)
        {
            mx=c;
            k=num;
        }
        return k;
    }
}