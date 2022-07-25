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


void Zad53()
{
 int rows = 5;
 int colums = 5;
 int [,] array = new int [rows, colums];
 FillArray(array);
 PrintArray(array);
 Console.WriteLine();
 int temp = 0;
 int minrow = 0;
 int maxrow = rows - 1;
 for (int j = 0; j< colums; j++)
 {
    temp = array[minrow,j];
    array[minrow,j] = array [maxrow,j];
    array[maxrow,j] = temp;
 }
PrintArray(array);
} 
//Zad53();


void Zad55()
{
  Console.WriteLine("Введите m");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Dведите n");
  int column = Convert.ToInt32(Console.ReadLine());
  int [,] array = new int [rows, column];
  FillArray(array);
  PrintArray(array);
  Console.WriteLine();

  if (rows == column)
  {
    for (int i = 0; i<rows; i++)
    {
      for (int j = i; j<column; j++)
      {
        (array[i,j], array[j,i]) = (array[j,i], array[i,j]);
      }
    }
  }
  else Console.WriteLine("массив невозможно перевернуть");
  Console.WriteLine();
  PrintArray(array);
}
//Zad55();



void Zad57()
{
    Random random = new Random();
    int rows = random.Next(2,6);
    int columns = random.Next(3,7);
    int [,]array = new int [rows, columns];
    int[] dictionary = new int [10];
    FillArray(array);
    PrintArray(array);
    for (int i = 0; i<rows; i++)
    {
      for (int j = i; j<columns; j++)
      {
        dictionary[array[i,j]]++;
      }
    }

    Console.WriteLine();
    for (int i= 0; i<dictionary.Length; i++)
    {
        Console.WriteLine($"Элемент {i} встречается {dictionary[i]} раз");
    }
}
//Zad57();

void Zad59()
{
    Random random = new Random();
    int rows = random.Next(2,6);
    int columns = random.Next(3,7);
    int [,]array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);

    int min = array [0,0];
    int j_min = 0;
    int i_min = 0;
    for (int i = 0; i<rows; i++)
    {
      for (int j = i; j<columns; j++)
      {
        if (array[i,j]<min)
        {
            min = array[i,j];
            j_min = j;
            i_min = i;
        }
      }
    }
    Console.WriteLine($"минимальный элемент находится на позитии {i_min}, {j_min} и равен {min}");
    int[,] newArray = new int [rows - 1, columns - 1];
    int bias_i = 0;
    for (int i = 0; i<rows - 1; i++)
    { 
      if (i == i_min) bias_i++;
      int bias_j = 0;
      for (int j = i; j<columns - 1; j++)
      {
        if (j == j_min) bias_j++;
        newArray[i,j] = array[i + bias_i,j+bias_j];
      }
    }
  Console.WriteLine();
  PrintArray(newArray);
}
Zad59();
      
      