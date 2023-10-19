/*Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B*/
Console.Clear();

System.Console.WriteLine("Enter number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter degree: ");
int userDegr = Convert.ToInt32(Console.ReadLine());

if (userDegr < 0) {
    System.Console.WriteLine("Degree cannot be less 0");
} else
System.Console.WriteLine(Math.Pow(userNum, userDegr));