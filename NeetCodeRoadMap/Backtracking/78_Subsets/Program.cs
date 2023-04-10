// See https://aka.ms/new-console-template for more information
var res = Subsets(new int[] { 1, 2, 3 });
foreach (var item in res)
{
    var s = "";
    foreach (var i in item)
    {
        s += ", " + i;
    }
    Console.WriteLine(s);
}

IList<IList<int>> Subsets(int[] nums)
{
    var result = new List<IList<int>>();
    var subset = new List<int>();

    void dfs(int i)
    {
        if (i >= nums.Length)
        {
            result.Add(subset.ToList());
            return;
        }

        subset.Add(nums[i]);
        dfs(i + 1);

        subset.Remove(nums[i]);
        dfs(i + 1);
    }


    dfs(0);
    return result;
}

