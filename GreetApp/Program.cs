using GreetBot;

Greeting greeting = new Greeting();
ConsoleKeyInfo consoleKeyInfo;

do
{
    string message = greeting.Greet();

    Console.WriteLine(message);

    Console.WriteLine("Press any key to get next greet message, ESC to exit");

    consoleKeyInfo = Console.ReadKey();
}
while (consoleKeyInfo.Key != ConsoleKey.Escape);