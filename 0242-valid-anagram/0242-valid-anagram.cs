public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)return false;
        Dictionary<char,int> freq=new Dictionary<char,int>();
        foreach(var i in s)
        {
            if(freq.ContainsKey(i))freq[i]++;
            else freq[i]=1;
        }
        foreach(var i in t)
        {
            if(freq.ContainsKey(i)&&freq[i]>0)freq[i]--;
            else return false;
        }
        return true;
    }
}