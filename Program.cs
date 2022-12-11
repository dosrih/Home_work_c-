int Min(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 < result) result = arg2;
    if (arg3 < result) result = arg3;
    return result;
    
}
//               0   1   2   3   4   5   6   7   8
int[] array = { 14, 21, 31, 10, 15, 61, 18, 16, 19 };

int result = Min(
    Min(array[0], array[1], array[2]),
    Min(array[3], array[4], array[5]),
    Min(array[6], array[7], array[8])
);
Console.WriteLine(result);
