// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int [] GetNumber(string text)
{
    System.Console.WriteLine(text);
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}

int PositivNum(int [] arr)
{int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) count += 1;
}
return count;
}

var N = GetNumber("Введите, пожалуйста, числа через пробел: ");
System.Console.WriteLine("Количество чисел больше 0 = " + PositivNum(N));