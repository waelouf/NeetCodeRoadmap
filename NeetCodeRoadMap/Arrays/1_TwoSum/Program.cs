
Console.WriteLine(TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11));
Console.WriteLine(TwoSum(new int[] { 2, 7, 11, 15 }, 9));
Console.WriteLine(TwoSum(new int[] { 3, 2, 4 }, 6));
Console.WriteLine(TwoSum(new int[] { 3, 3 }, 6));

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];

    Dictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (map.ContainsKey(nums[i]))
        {
            result[0] = i;
            result[1] = map[nums[i]];
            break;
        }
        else
        {
            int expeted = target - nums[i];
            if (!map.ContainsKey(expeted))
            {
                map.Add(expeted, i);
            }
        }
    }

    return result;
}