/*Принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве
А(3,6) В(2,1) -> 5,09
А(7,-5) В(1,-1) -> 7,21
*/
System.Console.WriteLine("Enter coordinates for A (x,y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter coordinates for B (x,y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

//int squareX = Math.pow((userBx - userAx), 2);
//int squareY = (userBx - userAx) * (userBx - userAx);
double distanceAB = Math.Sqrt(Math.Pow((userBx - userAx), 2) + Math.Pow((userBy - userAy), 2));
System.Console.WriteLine(Math.Round(distanceAB, 3));