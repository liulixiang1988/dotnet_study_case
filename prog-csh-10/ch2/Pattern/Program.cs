// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// read integer from console
var value = int.Parse(Console.ReadLine() ?? String.Empty);

switch (value)
{
    case < 0:
        Console.WriteLine("Value is positive");
        break;
    case > 0:
        Console.WriteLine("Value is negative");
        break;
    default:
        Console.Write("Value is zero");
        break;
}

switch (Environment.OSVersion)
{
    
    case {Platform: PlatformID.MacOSX}:
        Console.WriteLine("MacOSX");
        break;
    case {Platform: PlatformID.Unix}:
        Console.WriteLine("Unix");
        break;
    default:
        Console.WriteLine("Windows");
        break;
}