


int[] nums = { 1, 2, 3, 4};

Console.WriteLine(ContainsDuplicate(nums));



bool ContainsDuplicate(int[] nums)
{
    bool containsDuplicate = false;

    var set = new HashSet<int>();

    foreach (int i in nums)
    {
        if (set.Contains(i))
        {
            return true;
        }

        set.Add(i);
    }

    return containsDuplicate;
}
