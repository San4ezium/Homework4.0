// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter operation");
Console.WriteLine("1 - addition");
Console.WriteLine("2 - subtraction");
Console.WriteLine("3 - multiplication");
Console.WriteLine("4 - division");

short operation = Convert.ToInt16(Console.ReadLine());
long a = 0;
long b = 0;

if (operation >= 1 && operation <= 4)
{
    Console.WriteLine("enter two numbers : ");
    a = Convert.ToInt64(Console.ReadLine());
    b = Convert.ToInt64(Console.ReadLine());
}

switch (operation)
{
    case 1:
        Console.WriteLine($"1 - addition : {a + b}");
        break;

    case 2:
        Console.WriteLine($"2 - subtraction : {a - b}");
        break;

    case 3:
        Console.WriteLine($"3 - multiplication : {a * b}");
        break;
    case 4:
        Console.WriteLine($"4 - division : {a / b}");
        break;
    default:
        Console.WriteLine("wrong operation");
        break;

}
