void Zad63() //Задайте значение N. Выведите все натуральные числа от 1 до N.
{
 int number = 15;
 int count = 1;
 Recursion(count, number);
 Console.WriteLine();

 void Recursion(int count, int number)
 {
    if (count > number) return;
    Console.Write (count + " ");
    count++;
    Recursion(count, number);
 }
}
//Zad63();


void Zad64() //Задача 64: Задайте значения M и N. Напишите программу, 
             // которая выведет все натуральные числа в промежутке от M до N кратные трём.
{
 int numberFirst = 15;
 int numberSecond = 8;
 Recursion(numberFirst, numberSecond);
 Console.WriteLine();
 void Recursion(int numberFirst, int numbmerSecond)
 {
    if (numberSecond > numberFirst) return;
    else if (numberSecond%3==0)
    {
        Console.Write(numberSecond + " ");
    }
    numberSecond++;
    Recursion(numberFirst, numberSecond);
 }
}             
//Zad64();

void Zad65() //Задача 65: Задайте значения M и N. Напишите программу, 
             // которая выведет все натуральные числа в промежутке от M до N.
{
 int numberFirst = 15;
 int numberSecond = 8;
 Recursion(numberFirst, numberSecond);
 Console.WriteLine();
 void Recursion(int count, int number)
 {
    if (numberSecond > numberFirst) return;
    Console.Write(numberSecond + " ");
    numberSecond++;
    Recursion(numberFirst, numberSecond);
 }
}             
//Zad65();

void Zad66() //Задача 66: Задайте значения M и N. Напишите программу, 
             // которая выведет сумму натуральных чисел в промежутке от M до N.
{
 int numberFirst = 3;
 int numberSecond = 1;
 int sum = 0;
 Recursion(numberFirst, numberSecond);
 Console.WriteLine();

 void Recursion(int numberFirst, int numberSecond)
 {
    if (numberSecond > numberFirst) return;
    sum=sum + numberSecond;
    numberSecond++;
    Recursion(numberFirst, numberSecond);
 }
 Console.Write(sum);
}             
//Zad66();

void Zad67()
{
 int number=356;
 int sum = 0;
 sum = Recursion(number);
 Console.WriteLine();

 int Recursion(int number)
 {
    if (number /10 >0) return  Recursion(number / 10) + number%10;
    return number;
 }
 Console.WriteLine(sum);
}
//Zad67();


void Zad68() //Аккреман
{
 int numM=3;
 int numN=2;
 int sum=0;
 Recursion(numM, numN);
 sum = Recursion(numM,numN);
 Console.WriteLine();
 
 int Recursion(int numM, int numN)
 {
    if (numM==0) return numN+1;
    else if (numN==0) return Recursion(numM-1, 1);
    else if (numM>0 && numN>0) return Recursion(numM-1, Recursion(numM,numN-1));
    else return 0;
 }
Console.WriteLine(sum);
}
Zad68();



void Zad69()
{
 int numberFirst = 2;
 int numberSecond = 10;
 int pow = 1;
 int count=0;
 Recursion(numberFirst, numberSecond);
 Console.WriteLine();

 void Recursion(int numberFirst, int numberSecond)
 {
  if (count == numberSecond) return;
  pow*=numberFirst;
  count++;
  Recursion(numberFirst,numberSecond); 
 }
 Console.WriteLine(pow);
}
//Zad69();