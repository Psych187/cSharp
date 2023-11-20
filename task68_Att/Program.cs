// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

System.Console.WriteLine("Enter number m: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter  number n: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    
    else if (n == 0) return Ackermann(m - 1, 1);
    
    else  return Ackermann(m - 1, Ackermann(m, n - 1));
    
}
int result = Ackermann(number1, number2);
System.Console.WriteLine(result);