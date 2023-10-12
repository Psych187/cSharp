/*Программа, выводящая случайное число из отрезка [10,99] и показывает его наибольшую цифру*/

int number = new Random().Next(10,100);
System.Console.WriteLine(number);

int first = number / 10;
int second = number % 10;
if (first > second) {
    System.Console.WriteLine("The biggest is " + first);
}
if (first < second) {
    System.Console.WriteLine("The biggest is " + second);
}