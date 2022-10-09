// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
double[] numersArray = UserEnterNumersConsol();
ResultOutput(numersArray);

double[] UserEnterNumersConsol()
{
    double[] userEnterNumersArray = new double[4];
    Console.Write("Введите число b1: ");
    userEnterNumersArray[0] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число k1: ");
    userEnterNumersArray[1] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число b2: ");
    userEnterNumersArray[2] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число k2: ");
    userEnterNumersArray[3] = double.Parse(Console.ReadLine());
    return (userEnterNumersArray);
}

void ResultOutput(double[] numerArray)
{
    double[] xyArray = new double[2];
    xyArray[0] = (numerArray[2] - numerArray[0]) / (numerArray[1] - numerArray[3]);
    xyArray[1] = (numerArray[1] * xyArray[0]) + numerArray[0];
    Console.Write($"Точка пересечения прямых = ({xyArray[0]};{xyArray[1]})");
}