// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int[] numersArray = UserEnterNumersConsol();
ResultOutput(numersArray);

int[] UserEnterNumersConsol()
{
    Console.Write("Введите общее количество чисел ");
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

void ResultOutput(int[] numerArray)
{
    int sumPositivNums = 0;
    for (int i = 0; i < numerArray.Length; i++)
    {
        if (numerArray[i] > 0) { sumPositivNums++; }
    }
    Console.Write($"Количество чисел больше 0 = {sumPositivNums}");
}
