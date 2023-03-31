// See https://aka.ms/new-console-template for more information
var sol = new solution();

sol.GenerateParenthesis(7).ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();
//sol.GenerateParenthesis(2).ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();
//sol.GenerateParenthesis(3).ToList().ForEach(x => Console.WriteLine(x));


public class solution
{
    List<string> result;
    int maxLength;

    public IList<string> GenerateParenthesis(int n)
    {
        result = new List<string>();
        maxLength = n;

        Backtrack("", 0, 0);

        return result;
    }

    void Backtrack(string s, int openCount, int closeCount)
    {
        if (openCount == closeCount && openCount == maxLength)
        {
            result.Add(s);
            return;
        }

        if (openCount < maxLength)
        {
            Backtrack(s+"(", openCount + 1, closeCount);
        }

        if (openCount > closeCount)
        {
            Backtrack(s+")", openCount, closeCount + 1);
        }
    }
}