using System.Runtime.InteropServices;

internal static class NativeMethods
{
    [DllImport("kernel32.dll")]
    public static extern IntPtr GetStdHandle(ConsoleInputHandle nStdHandle);

    [DllImport("kernel32.dll")]
    public static extern bool GetConsoleMode(IntPtr hConsoleInput, ref ConsoleMode lpMode);

    [DllImport("kernel32.dll")]
    public static extern bool SetConsoleMode(IntPtr hConsoleInput, ConsoleMode dwMode);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    public static extern bool ReadConsoleInput(IntPtr hConsoleInput, [Out] InputRecord[] lpBuffer, int nLength, ref int lpNumberOfEventsRead);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    public static extern bool WriteConsoleInput(IntPtr hConsoleInput, InputRecord[] lpBuffer, int nLength, ref int lpNumberOfEventsWritten);
}