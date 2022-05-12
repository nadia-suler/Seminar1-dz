//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите 1е число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if(NumberA > NumberB)
{
    Console.WriteLine("max = " + NumberA);
    Console.WriteLine("min = " + NumberB);
}
else
{
    Console.WriteLine("max = " + NumberB);
    Console.WriteLine("min = " + NumberA);
}