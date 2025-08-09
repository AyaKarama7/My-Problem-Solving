public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens.Length==1)return int.Parse(tokens[0]);
        Stack<int> st=new Stack<int>();
        foreach(var i in tokens)
        {
            int x;
            if(int.TryParse(i,out x))
            {
                st.Push(x);
            }
            else if(st.Count>1)
            {
                int num1=st.Peek();
                st.Pop();
                int num2=st.Peek();
                st.Pop();
                if(i=="+")num2+=num1;
                else if(i=="-")num2-=num1;
                else if(i=="*")num2*=num1;
                else num2/=num1;
                st.Push(num2);
            }
        }
        return st.Peek();
    }
}