class Program
{
    static ConsoleInputHandler inputHandler;

    static void Main(string[] args)
    {
        SetupConsole();
        using (inputHandler = new ConsoleInputHandler())
        {
            inputHandler.MouseEvent += ConsoleListener_MouseEvent;
            inputHandler.KeyEvent += ConsoleListener_KeyEvent;
            inputHandler.Run();
        }
        Console.WriteLine("Exited.");
        Console.ReadKey();
    }

    private static void ConsoleListener_KeyEvent(KeyboardRecord r)
    {
        if (r.KeyDown && r.VirtualKeyCode == (ushort)ConsoleKey.Escape)
        {
            inputHandler.Stop();
        }
        else
        {
            int width = Console.BufferWidth - 1;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"KeyDown: {r.KeyDown}".PadRight(width));
            Console.WriteLine($"KeyChar: {r.UnicodeChar}, ConsoleKey: {(ConsoleKey)r.VirtualKeyCode}".PadRight(width));
            Console.WriteLine($"RepeatCount: {r.RepeatCount}".PadRight(width));
            Console.WriteLine($"Controls: {r.ControlKeyState}".PadRight(width));
        }
    }

    private static void SetupConsole()
    {
        IntPtr handle = NativeMethods.GetStdHandle(ConsoleInputHandle.StandardInput);
        ConsoleMode mode = 0;
        NativeMethods.GetConsoleMode(handle, ref mode);
        mode &= ~ConsoleMode.QuickEditMode;
        NativeMethods.SetConsoleMode(handle, mode);
    }

    private static void ConsoleListener_MouseEvent(MouseRecord r)
    {
        int width = Console.BufferWidth - 1;
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"Position: {r.Position.X}, {r.Position.Y}".PadRight(width));
        Console.WriteLine($"Buttons: {r.ButtonState}".PadRight(width));
        Console.WriteLine($"Flags: {r.EventFlags}".PadRight(width));
        Console.WriteLine($"Controls: {r.ControlKeyState}".PadRight(width));
    }
}