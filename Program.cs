/*
void InputMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = Convert.ToDouble(new Random().Next(-10, 10))/10 ;
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
InputMatrix(matrix);
*/

/*
Console.Write("введите номер строки : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца : ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [6,6];
RandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение {n } строки и {m } столбца равно {numbers [n,m]} \t");
}

PrintArray(numbers);

void RandomNumbers(int[,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
        {        
   for (int j = 0; j < array.GetLength(1); j++)      
{
                array [i,j] = new Random().Next( 100);
  }     }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write(" ");
    for (int j = 0; j < array.GetLength(1); j++)
         {
        Console.Write(array[i,j] + " ");
   }   
             Console.WriteLine(""); 
  }
}
*/


/*Console.Write("введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
RandomNumbers(numbers);

Console.WriteLine();
PrintArray(numbers);

void RandomNumbers(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
 {
 array[i, j] = new Random().Next(0, 10);
  }
}
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
 {
 for (int j = 0; j < array.GetLength(1); j++)
 {
     Console.Write($"{array[i, j]} \t ");
            
 }
        Console.WriteLine("");
 }
 }
 for (int j = 0; j < numbers.GetLength(1); j++)
{
    double x = 0;
 for (int i = 0; i < numbers.GetLength(0); i++)
  {
        x = (x + numbers[i, j]);
  }
    x = x / n;

    Console.Write($"{x} \t ");
   Console.Write(" ");
}
*/
