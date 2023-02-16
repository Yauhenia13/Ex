int[] array = {11, 202, 35, 7, 408, 45, 65, 7, 18};

int n = array.Length; //-> длина/колличество элементов массива
int find = 7;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // если в массиве два одинаковых элемента
    }
    index++;
}
