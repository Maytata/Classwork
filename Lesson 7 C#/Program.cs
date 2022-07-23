void FillArray(int[,] array)
{
   Random random = new Random();
  int rows = array.GetLength(0);
  int colums = array.GetLength(1);
  for (int i = 0; i< rows; i++) 
 {
   for (int j = 0; j< colums; j++)
   {
    array [i,j] = random.Next(1,11);
   }
 }
}
 
void PrintArray(int [,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i<rows; i++)
    {
      for (int j = 0; j < colums; j++)
      {
        Console.Write(array[i,j] + "\t");
      }
    Console.WriteLine();
    }
  Console.WriteLine();
}

void Zad46()
{
 int rows = 4;
 int colums = 5;
 int [,] array = new int [rows, colums]; //4x5
 Console.WriteLine(array.GetLength (0));
 Console.WriteLine(array.GetLength (1));
 FillArray(array);
 PrintArray(array);
}
//Zad46();

void Zad48()
{
  Console.WriteLine("Введите m");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Dведите n");
  int column = Convert.ToInt32(Console.ReadLine());
  int [,] array = new int [rows, column];
 
  
  for (int i = 0; i< rows; i++) 
 {
   for (int j = 0; j< column; j++)
   {
    array [i,j] = i+j;
   }
 }
  PrintArray(array);
}
//Zad48();

void Zad49()
{
  Console.WriteLine("Введите m");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Dведите n");
  int column = Convert.ToInt32(Console.ReadLine());
  int [,] array = new int [rows, column];
  FillArray(array);
  PrintArray(array);
  Console.WriteLine();
   
  for (int i = 0; i< rows; i++) 
  {
   for (int j = 0; j< column; j++)
   {
    if(i%2==0 && j%2==0) 
    {
      array [i,j] = array [i,j]*array [i,j];
    }
   }
  }
  PrintArray(array);
}
//Zad49();

void Zad51()
{
  Console.WriteLine("Введите m");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Dведите n");
  int column = Convert.ToInt32(Console.ReadLine());
  int [,] array = new int [rows, column];
  FillArray(array);
  PrintArray(array);
  Console.WriteLine();
  int SumNum = 0;
  int i = 0;
  int j = 0;
  
  while (i<=rows-1)
  {
    SumNum = array[i,j] + SumNum;
    i=i+1;
    j=j+1;
  
  }
  Console.WriteLine(SumNum);
}
Zad51();