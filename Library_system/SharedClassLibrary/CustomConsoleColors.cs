namespace SharedClassLibrary
{
    public static class CustomConsoleColors
    {
        public static void ConsoleWrite(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
