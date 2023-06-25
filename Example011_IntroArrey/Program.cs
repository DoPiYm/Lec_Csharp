Console.Clear();
int[] array = { 11, 12, 31, 41, 15, 61, 17, 8211, 19 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}