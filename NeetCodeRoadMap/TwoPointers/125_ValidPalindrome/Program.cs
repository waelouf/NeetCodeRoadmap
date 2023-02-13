// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
Console.WriteLine(IsPalindrome("race a car"));
Console.WriteLine(IsPalindrome(" "));
Console.WriteLine(IsPalindrome("0P"));
bool IsPalindrome(string s)
{
    s = s.ToLower();
    int start = 0;
    int end = s.Length -1;
    // 97-122 -> a-z
    // 48-57 -> 0-9
    while (start < end)
    {
        var startingChar = (int)s[start];
        var endingChar = (int)s[end];
        if ((startingChar < 48 || startingChar > 57) && (startingChar < 97 || startingChar > 122))
        {
            start++;
            continue;
        }

        if ((endingChar < 48 || endingChar > 57) && (endingChar < 97 || endingChar > 122))
        {
            end--;
            continue;
        }

        if(startingChar != endingChar)
        {
            return false;
        }

        start++;
        end--;
    }

    return true;
}