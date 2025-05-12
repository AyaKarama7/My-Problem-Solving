public class Solution {
    public int MajorityElement(int[] nums) {
       //num should be > n/2 
       //so at most half of the elements != num 
       //so we can say num is the positive and other nums is negative 
       //and num with freq > 0 is the answer 
       //Boyer voting majorty voting algorithm 
       int num=nums[0];
       int freq=1;
       for(int i=1;i<nums.Length;i++)
       {
        if(nums[i]==num)freq++;
        else if(freq==1)num=nums[i];
        else freq--;

       }
       return num;
    }
}