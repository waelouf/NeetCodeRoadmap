// See https://aka.ms/new-console-template for more information
Console.WriteLine(MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));


int MaxArea(int[] height)
{
    int maxArea = 0;
    var l = 0;
    var r = height.Length - 1;
    while (l < r)
    {
        maxArea = Math.Max(maxArea,  (r - l) * Math.Min(height[l], height[r]));
        if (height[l] < height[r])
            l++;
        else
            r--;

    }

    return maxArea;
}