int[] array = {1, 2, 3, 31, 51, 5, 6, 523, 18 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n) 
{
    if(array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}