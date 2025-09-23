public class Solution {
    private List<int>SubString(string s)
    {
        int startIdx=0,dotIdx,num;
        List<int>nums=new List<int>();
        while((dotIdx=s.IndexOf('.',startIdx))!=-1)
        {
            num=int.Parse(s.Substring(startIdx,dotIdx-startIdx));
            nums.Add(num);
            startIdx=dotIdx+1;
        }
        num=int.Parse(s.Substring(startIdx));
        nums.Add(num);
        return nums;
    }
    public int CompareVersion(string version1, string version2) {
        if(version1==version2)return 0;
        List<int>v1=SubString(version1);

        List<int>v2=SubString(version2);

        int i=0;
        while(i<v1.Count&&i<v2.Count)
        {
            if(v1[i]<v2[i])return -1;
            if(v1[i]>v2[i])return 1;
            i++;
        }
        while(i<v1.Count)
        {
            if(v1[i++]>0)return 1;
        }
        while(i<v2.Count)
        {
            if(v2[i++]>0)return -1;
        }
        return 0;
    }
}