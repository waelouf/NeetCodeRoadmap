// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine(IsValid("()"));
Console.WriteLine(IsValid("()[]{}"));
Console.WriteLine(IsValid("(]"));


bool IsValid(string s)
{
    // () -> 40, 41
    // [] -> 91, 93
    // {} -> 123, 125

    if (s.Length % 2 != 0)
        return false;

    bool isValid = true;

    var stack = new Stack<char>();
    foreach (char c in s)
    {
        if (c == 40 || c == 91 || c == 123)
        {
            stack.Push(c);
            continue;
        }
        else
        {
            if(stack.Count == 0)
                return false;

            var open = stack.Pop();
            if((    open == 40 && c == 41)
                || (open == 91 && c == 93)
                || (open == 123 && c == 125))
            {
                continue;
            }
            else
            {
                return false;
            }
        }
    }

    if (stack.Count > 0)
        return false;

    return isValid;
}