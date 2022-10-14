// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
 
Console.WriteLine("Ведите"); 
int rows = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Ведите"); 
int columns = Convert.ToInt32(Console.ReadLine()); 
 
int[,] array = new int[rows, columns]; 
FillArrayRandom(array); 
PrintArray(array); 
 
Console.WriteLine(); 
 
///Main(array); 
SumArrayMin(array); 
 
 
void FillArrayRandom(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = new Random().Next(1, 10); 
        } 
 
    } 
 
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
 
            Console.Write(array[i, j] + " "); 
 
        } 
        Console.WriteLine(""); 
    } 
} 
//// сумма строк  
void SumArrayMin(int[,] array) 
{ 
    int minSum = 0; 
int sum = SumLine(array, 0); 
for (int i = 1; i < array.GetLength(0); i++) 
{ 
  int temp = SumLine(array, i); 
  if (sum> temp) 
  { 
    sum = temp; 
    minSum = i; 
  } 
} 
 
Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой  элементов "); 
} 
 
int SumLine(int[,] array, int i) 
{ 
  int sumLine = array[i,0]; 
  for (int j = 1; j < array.GetLength(1); j++) 
  { 
    sumLine += array[i,j]; 
  } 
  return sumLine; 
}
