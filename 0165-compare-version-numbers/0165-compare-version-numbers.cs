public class Solution {
    public int CompareVersion(string version1, string version2) {
        List<double>nums1=new List<double>();
        List<double>nums2=new List<double>();
        double num=0,p=0;
        foreach(var ch in version1)
        {
            if(ch=='.')
            {
                nums1.Add(num);
                num=0;
                p=0;
            }
            else
            {
                num=num*Math.Pow(10,p)+ch-'0';
                if(num>0)p++;
            }
        }
        nums1.Add(num);
        num=0;p=0;
        foreach(var ch in version2)
        {
            if(ch=='.')
            {
                nums2.Add(num);
                num=0;
                p=0;
            }
            else
            {
                num=num*Math.Pow(10,p)+ch-'0';
                if(num>0)p++;
            }
        }
        nums2.Add(num);
        int n=Math.Min(nums1.Count,nums2.Count);
        int i=0;
        foreach(var ele in nums1)Console.WriteLine(ele);
        foreach(var ele in nums2)Console.WriteLine(ele);

        while(i<n)
        {
            if(nums1[i]<nums2[i])return -1;
            if(nums1[i]>nums2[i])return 1;
            i++;
        }
        while(i<nums1.Count)
        {
            if(nums1[i]!=0)return 1;
            i++;
        }
        while(i<nums2.Count)
        {
            if(nums2[i]!=0)return -1;
            i++;
        }
        
        return 0;
    }
}