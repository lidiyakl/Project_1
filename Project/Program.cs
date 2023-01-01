void Print(string[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

string[] Mass(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
        arr[i] = new String(Console.ReadLine());
    return arr;
}

string[] NewMass(string[] arr)
{
    int size = arr.Length;
    int size_1 = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= 3) size_1++;
    }
    string[] new_arr = new string[size_1];

    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= 3)
        {
            new_arr[j] = arr[i];
            j++;
        }
    }
    return new_arr;
}

string[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
string[] arr_2 = NewMass(arr_1);
Print(arr_2);
