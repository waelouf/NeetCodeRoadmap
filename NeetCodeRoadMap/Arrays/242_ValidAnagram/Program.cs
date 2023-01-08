
Console.WriteLine("Is anagram?");
Console.WriteLine(IsAnagram("rat", "car"));


bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    var dictionary = new Dictionary<char, int>();

    foreach (var c in s)
    {
        if (dictionary.ContainsKey(c))
        {
            dictionary[c]++;
        }
        else
        {
            dictionary.Add(c, 1);
        }
    }

    foreach (var c in t)
    {
        if (!dictionary.ContainsKey(c)) return false;

        dictionary[c]--;

        if (dictionary[c] == 0)
        {
            dictionary.Remove(c);
        }
    }

    return dictionary.Count == 0;
}