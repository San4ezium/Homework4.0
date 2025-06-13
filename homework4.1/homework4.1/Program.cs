// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter numbers day : ");
short operation = Convert.ToInt16(Console.ReadLine());

switch (operation)
{
    case 1:
        Console.WriteLine("1 - Monday");
        break;

    case 2:
        Console.WriteLine("2 - Tuesday");
        break;

    case 3:
        Console.WriteLine("3 - Wednesday");
        break;
    case 4:
        Console.WriteLine("4 - Thursday");
        break;
    case 5:
        Console.WriteLine("5 - Friday");
        break;
    case 6:
        Console.WriteLine("6 - Saturday");
        break;
    case 7:
        Console.WriteLine("7 - Sunday");
        break;

    default:
        Console.WriteLine("wrong operation");
        break;
}