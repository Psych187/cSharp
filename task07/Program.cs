// Программа принимает на вход 3х значное число, на выходе показывает его последнюю цифру
 System.Console.WriteLine("Enter nuber: ");
 int userNumber = Convert.ToInt32(Console.ReadLine());
 int result = userNumber % 10;
 System.Console.WriteLine(result);