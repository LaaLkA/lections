void FillArray(int[] collection) // заполнение массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(", ");
        position++;
    }
}

int[] array = new int[10]; // new int[10] - создай новый массив с длинной 10

FillArray(array);
PrintArray(array);