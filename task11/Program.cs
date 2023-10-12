// программа выводит случайное 3х значное число и удаляет вторую цифру

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
 int first = number / 100;
 int second = number % 10;
 System.Console.Write(first + " " + second);