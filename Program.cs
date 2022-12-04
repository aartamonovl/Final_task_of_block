void ShowArray(string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"\b\b]\n");
}

string [] FindElemLenLessThree (string [] array)
{
    int changedSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            changedSize++;
    }
    if (changedSize != 0)
    {
        string [] changedArray = new string [changedSize];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
                changedArray[j++] = array[i];
        }
        return changedArray;
    }
    else 
    {
        string [] zeroArray = new string [1];
        zeroArray[0] = string.Empty;
        return zeroArray;
    }
}

Console.WriteLine("Введите желаемое количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    Console.WriteLine($"Введите элементы после каждого нажимая кнопку Enter. ");
    Console.WriteLine($"Пустое значение не считается за элемент массива.");
    string [] array = new string [size];
    for (int i = 0; i < size; i++)
    {
        string elem = Console.ReadLine();
        if (elem != string.Empty)
            array[i] = elem;
        else i--;
    }

    ShowArray(array);
    ShowArray(FindElemLenLessThree(array));
}
else
    Console.WriteLine("Размер массива должен быть больше 0. Попробуйте снова.");