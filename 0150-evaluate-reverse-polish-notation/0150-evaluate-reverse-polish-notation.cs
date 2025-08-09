public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st=new Stack<int>();
        int num1,num2;
        foreach(var i in tokens)
        {
            if(int.TryParse(i,out num1))
            {
                st.Push(num1);
            }
            else
            {
                num1=st.Pop();
                num2=st.Pop();
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