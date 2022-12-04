void ShowArray(string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"\b\b]\n");
}

Console.WriteLine("Введите желаемое количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {size} элементов после каждого нажимая кнопку Enter. ");
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