public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)return false;
        char[] arr1=s.ToCharArray();
        char[] arr2=t.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        string x=new string(arr1);
        string y=new string(arr2);
        if(String.Compare(x,y)==0)return true;
        return false;
    }
}