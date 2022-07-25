using System.Runtime.InteropServices;

[Flags]
public enum ConsoleMode : uint
{
    None = 0x0000,
    EchoInput = 0x0004,
    WindowInput = 0x0008,
    MouseInput = 0x0010,
    QuickEditMode = 0x0040,
    ExtendedFlags = 0x0080,
}

public enum ConsoleInputHandle : int
{
    StandardInput = -10,
    StandardOutput = -11,
    StandardError = -12
}

public struct ConsolePoint
{
    public short X;
    public short Y;
}

[Flags]
public enum ConsoleEventType : ushort
{
    Keyboard = 0x0001,
    Mouse = 0x0002,
    WindowBufferSize = 0x0004,
    Menu = 0x0008,
    Focus = 0x0010
}

[StructLayout(LayoutKind.Explicit)]
public struct InputRecord
{
    [FieldOffset(0)]
    public ConsoleEventType EventType;
    [FieldOffset(4)]
    public KeyboardRecord KeyEvent;
    [FieldOffset(4)]
    public MouseRecord MouseEvent;
    [FieldOffset(4)]
    public WindowBufferSizeRecord WindowBufferSizeEvent;
}

[Flags]
public enum MouseButtonState : uint
{
    NoButton = 0x0000,
    LeftButton = 0x0001,
    RightButton = 0x0002,
    MiddleButton = 0x0004,
    ThirdButton = 0x0008,
    FourthButton = 0x0010
}

[Flags]
public enum ControlKeyState : uint
{
    None = 0x0000,
    RightAlt = 0x0001,
    LeftAlt = 0x0002,
    RightCtrl = 0x0004,
    LeftCtrl = 0x0008,
    Shift = 0x0010,
    NumLock = 0x0020,
    ScrollLock = 0x0040,
    CapsLock = 0x0080,
    EnhancedKey = 0x0100,
}

[Flags]
public enum MouseEventFlagsState : uint
{
    Idle = 0x0000,
    Move = 0x0001,
    DoubleClick = 0x0002,
    Wheel = 0x0004,
    HorizontalWheel = 0x0008
}

[StructLayout(LayoutKind.Sequential)]
public struct MouseRecord
{
    public ConsolePoint Position;
    public MouseButtonState ButtonState;
    public ControlKeyState ControlKeyState;
    public MouseEventFlagsState EventFlags;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct KeyboardRecord
{
    [FieldOffset(0)]
    public bool KeyDown;
    [FieldOffset(4)]
    public ushort RepeatCount;
    [FieldOffset(6)]
    public ushort VirtualKeyCode;
    [FieldOffset(8)]
    public ushort VirtualScanCode;
    [FieldOffset(10)]
    public char UnicodeChar;
    [FieldOffset(10)]
    public byte AsciiChar;
    [FieldOffset(12)]
    public ControlKeyState ControlKeyState;

    public ConsoleKey ConsoleKey => (ConsoleKey)VirtualKeyCode;
}

public struct WindowBufferSizeRecord
{
    public ConsolePoint Size;
}