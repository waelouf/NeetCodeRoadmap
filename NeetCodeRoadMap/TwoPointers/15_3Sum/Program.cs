// See https://aka.ms/new-console-template for more information
Console.WriteLine(ThreeSum(new int[] { -1, 0, 1, 2, -1, -4})); // -4, -1, -1, 0, 1, 2



IList<IList<int>> ThreeSum(int[] nums)
{
    var result = new List<IList<int>>();
    
    nums = nums.OrderBy(x => x).ToArray();

    for (int i = 0; i < nums.Length; i++)
    {
        var sum = nums[i];

        if (sum > 0)
            break;

        if (i > 0 && nums[i - 1] == sum)
            continue;

        int l = i + 1;
        int r = nums.Length - 1;

        while (r > l)
        {
            var total = sum + nums[l] + nums[r];

            if (total > 0)
                r--;
            else if (total < 0) 
                l++;
            else
            {
                var lst = new List<int>() { nums[i], nums[r], nums[l] };
                result.Add(lst);
                l++;
                r--;
                while (nums[l] == nums[l-1] && l < r)
                {
                    l++;
                }
            }
        }
    }

    return result;
}
