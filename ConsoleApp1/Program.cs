Console.Write("Enter your name:");
string name = Console.ReadLine();
Console.Write("Enter your age:");
byte age = checked ((byte) int.Parse(Console.ReadLine()));
Console.WriteLine("Ur name is {0} and ur age is {1}", name, age);
Console.Write("What is ur fav day of the week:");
DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
Console.WriteLine("Your fav day of week is {0}", day);
Console.ReadKey();