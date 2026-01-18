public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> buffer = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (int.TryParse(tokens[i], out int num))
            {
                buffer.Push(num);
            }
            else
            {
                int op1 = buffer.Pop();
                int op2 = buffer.Pop();
                if (tokens[i] == "+")
                {
                    buffer.Push(op1 + op2);
                }
                else if (tokens[i] == "-")
                {
                    buffer.Push(op2 - op1);
                }
                else if (tokens[i] == "*")
                {
                    buffer.Push(op1 * op2);
                }
                else if (tokens[i] == "/")
                {
                    buffer.Push(op2 / op1);
                }
            }



        }
        return buffer.Pop();

    }
}