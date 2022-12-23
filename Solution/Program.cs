Console.WriteLine("Введите элементы вашего массива через пробел");
string [] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string [] newArray = new string [COUNT(array)];
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine ("Новый массив из элементов, длина которых меньше, либо равна 3 символам:");
Console.WriteLine($"[{string.Join(", ", NewArray(array))}]");

int COUNT (string [] array )
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i].Length <=3)
        { 
            count++;
        }
    }
    return count;
}

string [] NewArray (string [] array)
{
    for (int i =0, j=0; i<array.Length;i++)
    {
        if (array[i].Length <=3)
        { 
            newArray[j] = array[i]; 
            j++;
        }
    } 
    return (newArray);
}
