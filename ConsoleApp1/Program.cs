Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы:");

var Color = Console.ReadLine();

if (Color == "red")
{
    Console.BackgroundColor= ConsoleColor.Red;
    Console.ForegroundColor= ConsoleColor.Black;

    Console.WriteLine("Your color is red");
}

else if (Color == "green")
{
    Console.BackgroundColor= ConsoleColor.Green;
    Console.ForegroundColor= ConsoleColor.Black;

    Console.WriteLine("Your color is green");
}

else if (Color == "white")
{
    Console.BackgroundColor= ConsoleColor.White;
    Console.ForegroundColor= ConsoleColor.Black;

    Console.WriteLine("Your color is white");
}

else
{
    Console.BackgroundColor= ConsoleColor.Cyan;
    Console.ForegroundColor= ConsoleColor.Black;

    Console.WriteLine("Your color is cyan");
}

