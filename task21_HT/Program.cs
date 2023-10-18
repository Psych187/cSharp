/*принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
System.Console.WriteLine("Enter coordinates for A (x,y,z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter coordinates for B (x,y,z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

//int squareX = Math.pow((userBx - userAx), 2);
//int squareY = (userBx - userAx) * (userBx - userAx);
double distanceAB = Math.Sqrt(Math.Pow((userBx - userAx), 2) + Math.Pow((userBy - userAy), 2) + Math.Pow((userBz - userAz), 2));
System.Console.WriteLine(Math.Round(distanceAB, 3));