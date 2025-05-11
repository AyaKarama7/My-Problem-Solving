public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)return false;
        int[] freq=new int[26];
        foreach(var i in s)freq[i-'a']++;
        foreach(var i in t)
        {
            if(freq[i-'a']>0)freq[i-'a']--;
            else return false;
        }
        return true;
    }
}