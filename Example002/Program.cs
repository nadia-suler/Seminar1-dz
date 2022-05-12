//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите 1е число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3е число: ");
int NumberC = Convert.ToInt32(Console.ReadLine());

int MaxNumber = NumberA;

if(MaxNumber < NumberB) MaxNumber = NumberB;
if(MaxNumber < NumberC) MaxNumber = NumberC;

Console.WriteLine("max = " + MaxNumber); 