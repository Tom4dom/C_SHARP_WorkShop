Console.WriteLine("Input integer 'A': ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer 'B'");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberC = numberA/numberB;

if (numberB == numberC)
{
    Console.WriteLine($"Yes! It is true that {numberA} is a square of {numberB}");
}
else
{
    Console.WriteLine($"No! It is not true that {numberA} is square of {numberB}");
}