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



void Zad54()
{
  Console.WriteLine("Введите m");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Dведите n");
  int column = Convert.ToInt32(Console.ReadLine());
  int [,] array = new int [rows, column];
  FillArray(array);
  PrintArray(array);
  Console.WriteLine();
  for (int i = 0; i<rows; i++)
    {
      for (int j = 0; j < column; j++)
      {
        for (int u = 0; u < column-1-j; u++)
        {
          if(array[i,u]< array[i,u+1])
          {
            int temp = array[i,u];
            array[i,u]= array [i,u+1];
            array [i,u+1]=temp;
          }
        }
      }
    }
  PrintArray(array);
}
  Zad54();


void Zad56()
{
 Console.WriteLine("Введите m");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Dведите n");
  int column = Convert.ToInt32(Console.ReadLine());
  int [,] array = new int [rows, column];
  FillArray(array);
  PrintArray(array);
  Console.WriteLine();
  int sumMin = 0;
  int sum=0;
  int sumIndex=0;
  for (int j = 0; j < column; j++)
  {
    sumMin+= array [0,j];
  }
  for (int i = 1; i<rows; i++)
    {
      for (int j = 0; j < column; j++)
      {
        sum += array[i,j];
      }
      if (sum<sumMin)
      {
        sumMin=sum;
        sumIndex=i;
      }
    }
 Console.WriteLine($"минимальная сумма находится в строке {sumIndex+1} и равна {sumMin}");
}
Zad56();