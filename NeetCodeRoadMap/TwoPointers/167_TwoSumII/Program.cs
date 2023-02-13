// See https://aka.ms/new-console-template for more information
Console.WriteLine(TwoSum(new int[] { 2, 7, 11, 15 }, 9));
Console.WriteLine(TwoSum(new int[] { 2, 3, 4 }, 6));
Console.WriteLine(TwoSum(new int[] { -1, 0 }, -1));

int[] TwoSum(int[] numbers, int target)
{
    int[] resul = new int[2];

    int startIndex = 0;
    int lastIndex = numbers.Length - 1;

    while (startIndex < lastIndex)
    {
        int sum = numbers[startIndex] + numbers[lastIndex];
        if (sum > target)
        {
            lastIndex--;
        }
        else if (sum < target)
        {
            startIndex++;
        }
        else
        {
            resul[0] = ++startIndex;
            resul[1] = ++lastIndex;
            break;
        }
    }

    return resul;
}