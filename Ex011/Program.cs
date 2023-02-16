// void -> метод в котором ничего не возвращается, оператор return 
// в этом методе применяться не может.

void FillArray(int[] collectoin)
{
    int length = collectoin.Length;
    int index = 0;
    while(index < length)
    {
        collectoin[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); // Заполнения массива
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 8);
Console.WriteLine(pos);