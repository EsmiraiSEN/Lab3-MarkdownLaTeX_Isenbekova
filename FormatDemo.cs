// ## Требования к программе:
// 1. Имя файла: FormatDemo.cs
// 2. Логика:
//    - Запрашивает у пользователя **два числа**
//    - Выполняет их *сложение*
//    - Выводит результат в ***форматированном виде***

Console.Write("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

double sum = number1 + number2;
Console.WriteLine($"Результат операции: {sum}");