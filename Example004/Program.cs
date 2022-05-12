Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = 2;

while (NumberB <= NumberA)
{
    Console.Write(NumberB);
    NumberB = NumberB + 2;
    if(NumberB <= NumberA)
    {
        Console.Write(", ");
    }
}