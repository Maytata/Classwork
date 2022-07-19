int[] FillArray(int[] array)
{
    Random rand = new Random();    
    for(int i = 0; i < array.Length; i++) array[i] = rand.Next(1, 11);

    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}
void Check(int arr1, int arr2, int arr3)
{
 if (arr1<=arr2+arr3 & arr2<=arr1+arr3 & arr3<=arr1+arr2)
        { 
         Console.WriteLine("Треугольник существует");
        }
  else Console.WriteLine("Треугольник не существует");
}


void Zad40() 
{
 int [] array = new int[8];
 //int[] secondarray = new int [8];
 FillArray(array);
 PrintArray(array);
 Console.WriteLine();
 int MaxIndex = array.Length-1;

for (int i = 0; i<array.Length/2; i++)
  {
    //secondarray [MaxIndex - i] = array [i];
    int temp = array[i];
    array[i] = array [MaxIndex - i];
    array [MaxIndex - i] = temp;
  }
PrintArray(array);
}
//Zad40();


void Zad41()
{
Console.WriteLine($"Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Check(a,b,c);
}
 //Zad41();   

 
 void Zad44()
 {
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int firstnum = 0;
int secondnum = 1;
int Fib = 0;
Console.Write($"{firstnum} {secondnum} ");
for (int i=0; i<N-2; i++)
 {
  Fib = firstnum + secondnum;
  Console.Write($"{Fib} ");
  firstnum = secondnum;
  secondnum = Fib;
 }
 }
 //Zad44();

void Zad45()
{
 int[] array = new int[8];
 int[] secondarray = new int [8];
 FillArray(array);
 PrintArray(array);
 for (int i = 0; i<array.Length; i++)
     {
      secondarray[i] = array[i];
     }
 Console.WriteLine();
 PrintArray(secondarray);
}
// Zad45();
