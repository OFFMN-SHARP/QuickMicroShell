namespace QuickMicroShell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double version = 1.0;
            int build = 0001;
            string releasename = "alpha";
            while (true)
            {
                Console.BackgroundColor=ConsoleColor.Blue;
                Console.Write("Shell");
                Console.Write($"[{version}|{build:D4}:({releasename})]");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write($"[{DateTime.Now:HH:mm:ss}|{Environment.UserName}|{Environment.MachineName}]");
                Console.BackgroundColor=ConsoleColor.White;
                Console.WriteLine($"<{Directory.GetCurrentDirectory}>");
                Console.ResetColor();
                Console.Write("└──>");
                int originalLeft = Console.CursorLeft;
                int originalTop = Console.CursorTop;
                Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft - 1));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('<');
                Console.ResetColor();
                Console.SetCursorPosition(originalLeft, originalTop);
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
