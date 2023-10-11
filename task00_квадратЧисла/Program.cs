/* Программа для вывода квадрата числа*/
System.Console.WriteLine("Enter number: "); // cw - быстрый вызов Console.WriteLine
int userNumber = Convert.ToInt32(Console.ReadLine()); // считываем ввод с консоли, конвертируем в число типа int и присваиваем в переменную
int result = userNumber * userNumber;
Console.WriteLine(result);