// Задача 45: Напишите программу, 
//которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

Console.Clear();
int[] numersArray = UserEnterNumersConsol();
int[] copyNumersArray = CopyArray(numersArray);
ResultOutput(copyNumersArray);

int[] UserEnterNumersConsol()
{
    Console.Write("Введите общее количество чисел массива ");
    int sise;
    sise = int.Parse(Console.ReadLine());
    int[] userEnterNumersArray = new int[sise];
    for (int i = 0, j = 1; j <= sise; i++, j++)
    {
        Console.Write($"Введите число {j} из {sise} : ");
        userEnterNumersArray[i] = int.Parse(Console.ReadLine());
    }
    return (userEnterNumersArray);
}

int[] CopyArray(int[] numArray)
{
    int[] copyArr = new int[numArray.Length];
    for (int i = 0; i < numArray.Length; i++)
    {
        copyArr[i] = numArray[i];
    }
    return (copyArr);
}

void ResultOutput(int[] numerArray)
{
    Console.Write("Поэлементная копия массива = ( ");
    for (int i = 0; i < numerArray.Length; i++)
    {
        Console.Write($"{numerArray[i]} ");
    }
    Console.Write(")");
}