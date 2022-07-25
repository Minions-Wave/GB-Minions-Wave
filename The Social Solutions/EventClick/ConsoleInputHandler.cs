public class ConsoleInputHandler : IDisposable
{
    public delegate void ConsoleMouseEvent(MouseRecord r);
    public delegate void ConsoleKeyEvent(KeyboardRecord r);
    public delegate void ConsoleWindowBufferSizeEvent(WindowBufferSizeRecord r);

    public event ConsoleMouseEvent MouseEvent;

    public event ConsoleKeyEvent KeyEvent;

    public event ConsoleWindowBufferSizeEvent WindowBufferSizeEvent;

    private readonly CancellationTokenSource _cts;

    public ConsoleInputHandler()
    {
        _cts = new CancellationTokenSource();
    }

    public void Run()
    {
        IntPtr handle = NativeMethods.GetStdHandle(ConsoleInputHandle.StandardInput);
        InputRecord[] inputBuffer = new InputRecord[10];
        CancellationToken token = _cts.Token;
        int numRead = 0;
        while (!token.IsCancellationRequested)
        {
            if (NativeMethods.ReadConsoleInput(handle, inputBuffer, inputBuffer.Length, ref numRead))
            {
                for (int i = 0; i < numRead; i++)
                {
                    switch (inputBuffer[i].EventType)
                    {
                        case ConsoleEventType.Mouse:
                            MouseEvent?.Invoke(inputBuffer[i].MouseEvent);
                            break;
                        case ConsoleEventType.Keyboard:
                            KeyEvent?.Invoke(inputBuffer[i].KeyEvent);
                            break;
                        case ConsoleEventType.WindowBufferSize:
                            WindowBufferSizeEvent?.Invoke(inputBuffer[i].WindowBufferSizeEvent);
                            break;
                        case ConsoleEventType.Menu:
                        case ConsoleEventType.Focus:
                            break;
                    }
                }
            }
            else
                break;
        }
    }

    public void Stop()
    {
        if (disposed)
            throw new ObjectDisposedException(nameof(ConsoleInputHandler));

        if (!_cts.IsCancellationRequested) _cts.Cancel();

        _cts.Token.WaitHandle.WaitOne();
    }

    private bool disposed;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            throw new ObjectDisposedException(nameof(ConsoleInputHandler));

        if (!_cts.IsCancellationRequested)
        {
            _cts.Cancel();
        }

        _cts.Token.WaitHandle.WaitOne();

        if (disposing)
        {
            _cts.Dispose();
        }
        disposed = true;
    }

    ~ConsoleInputHandler() => Dispose(false);
}