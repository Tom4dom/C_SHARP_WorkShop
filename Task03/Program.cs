// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятниц


Console.WriteLine("Please, input the number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Monday");
}
if (day == 2)
{
    Console.WriteLine("Tuesday");
}
if (day == 3)
{
    Console.WriteLine("Wednesday");
}
if (day == 4)
{
    Console.WriteLine("Thursday");
}
if (day == 5)
{
    Console.WriteLine("Friday");
}
if (day == 6)
{
    Console.WriteLine("Saturday");
}
if (day == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Sorry! But it is not a number of the day of the week!");
}


