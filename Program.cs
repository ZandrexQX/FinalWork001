Console.Clear();
Console.WriteLine("Final Task");
Console.WriteLine("------");

string[] Arr3Chars(string[] arr)
{
    int count = 0;
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }
    string[] arr2 = new string[count];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4){
            arr2[count] = arr[i];
            count++;
        }
    }
    return arr2;
}



Console.Write("Введите строки через пробел: ");
string[] strArray = Console.ReadLine().Split("");
Console.ReadLine();

/*--------------------------------------------*/