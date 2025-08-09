public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st=new Stack<int>();
        foreach(var i in tokens)
        {
            int x;
            if(int.TryParse(i,out x))
            {
                st.Push(x);
            }
            else
            {
                int num1=st.Pop();
                int num2=st.Pop();
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