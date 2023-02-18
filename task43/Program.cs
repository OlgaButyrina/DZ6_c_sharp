// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double FindPointX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindPointY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double b1 = GetNumber("Введите координату x первой прямой: ");
double b2 = GetNumber("Введите координату y первой прямой: ");
double k1 = GetNumber("Введите координату x второй прямой: ");
double k2 = GetNumber("Введите координату y второй прямой: ");
//нужно ещё сделать проверку на параллельность прямых или их совпадение
double pointX = FindPointX(b1, b2, k1, k2);
double pointY = FindPointY(b1, k1, pointX);
System.Console.WriteLine($"Координаты точки пересечения данных прямых - ({pointX}; {pointY})");

