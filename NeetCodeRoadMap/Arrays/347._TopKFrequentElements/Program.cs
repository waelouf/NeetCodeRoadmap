// See https://aka.ms/new-console-template for more information
Console.WriteLine("Top K Frequent");
//Console.Write(TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2));
Console.Write(TopKFrequent(new int[] { 1 }, 1));


int[] TopKFrequent(int[] nums, int k)
{
    var ints = new List<int>();
    var dictionary = new Dictionary<int, int>();

    foreach (int n in nums)
    {
        if (dictionary.ContainsKey(n))
        {
            dictionary[n]++;
        }
        else
        {
            dictionary.Add(n, 1);
        }
    }

    List<int>[] arr = new List<int>[nums.Length + 1];
    foreach (var item in dictionary)
    {
        if (arr[item.Value] == null) arr[item.Value] = new List<int>();
        arr[item.Value].Add(item.Key);
    }

    for (int i = arr.Length - 1; i > 0; i--)
    {
        if (arr[i] != null && arr[i].Count > 0)
        {
            ints.AddRange(arr[i]);
            if (ints.Count == k)
                break;
        }
    }

    return ints.ToArray();
}