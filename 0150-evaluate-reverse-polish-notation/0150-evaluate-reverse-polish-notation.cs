public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st=new Stack<int>();
        int a,b;
        foreach(var i in tokens)
        {
            if(int.TryParse(i,out a))
            {
                st.Push(a);
            }
            else
            {
                b=st.Pop();
                a=st.Pop();
                switch (i) {
                    case "+": st.Push(a + b); break;
                    case "-": st.Push(a - b); break;
                    case "*": st.Push(a * b); break;
                    case "/": st.Push(a / b); break;
                }
            }
        }
        return st.Peek();
    }
}