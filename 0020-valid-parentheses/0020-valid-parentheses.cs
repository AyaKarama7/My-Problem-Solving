public class Solution {
    public bool IsValid(string s) {
        Stack<char>st=new Stack<char>();
        foreach(var c in s)
        {
            if(c=='{'||c=='('||c=='[')st.Push(c);
            else if((c=='}'||c==')'||c==']')&&st.Count()==0)return false;
            else 
            {
                if(c=='}'&&st.Peek()=='{')st.Pop();
                else if(c==']'&&st.Peek()=='[')st.Pop();
                else if(c==')'&&st.Peek()=='(')st.Pop();
                else return false;
            }
        }
        if(st.Count()==0)return true;
        return false;
    }
}