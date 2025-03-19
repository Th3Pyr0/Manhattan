using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Formats;
using System.Windows;
using System.Security.Cryptography.X509Certificates;
<<<<<<< HEAD
=======
using System.Text.Unicode;
using System.Reflection.Metadata;
>>>>>>> refs/remotes/origin/main





[Flags]


public enum WindowStylesEx : uint
{
   
}

[Flags]
public enum WindowStyles : uint
{
    
}

public enum ShowWindowCommands : int
{
    Hide = 0,
    Normal = 1,
    ShowMinimized = 2,
    Maximize = 3,  
    ShowMaximized = 3,
    ShowNoActivate = 4,
    Show = 5,
    Minimize = 6,
    ShowMinNoActive = 7,
    ShowNA = 8,
    Restore = 9,
    ShowDefault = 10,
    ForceMinimize = 11
}


public struct Message
{
    public IntPtr hWnd;
    public uint Msg;
    public IntPtr wParam;
    public IntPtr lParam;
    public uint Time;
    public Point Point;
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct Vector2d
{

    public int X, Y;

     public Vector2d(int x, int y)
    {
        X = x;
        Y = y;
    }
   




}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct WNDCLASS
{
    public uint style;
    public IntPtr lpfnWndProc;
    public int cbClsExtra;
    public int cbWndExtra;
    public IntPtr hInstance;
    public IntPtr hIcon;
    public IntPtr hCursor;
    public IntPtr hbrBackground;
    public string lpszMenuName;
    public string lpszClassName;
}
<<<<<<< HEAD
public class Windowcallprog
=======


public class Window
>>>>>>> refs/remotes/origin/main
{
    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr CreateWindowEx(
        WindowStylesEx dwExStyle,
        string lpClassName,
        string lpWindowName,
        WindowStyles dwStyle,
        int x,
        int y,
        int nWidth,
        int nHeight,
        IntPtr hWndParent,
        IntPtr hMenu,
        IntPtr hInstance,
        IntPtr lpParam);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

    [DllImport("user32.dll")]
    public static extern bool UpdateWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern bool TranslateMessage([In] ref Message lpMsg);

    [DllImport("user32.dll")]
    public static extern bool DispatchMessage([In] ref Message lpmsg);

    [DllImport("user32.dll")]
    public static extern bool GetMessage(out Message lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern System.UInt16 RegisterClassW([In] ref WNDCLASS lpWndClass);

    [DllImport("user32.dll", EntryPoint = "PostQuitMessage")]
    public static extern void PostQuitMessage(int nExitCode);

    // Define the Windows procedure
<<<<<<< HEAD
=======
    public int Value { get; set; }
>>>>>>> refs/remotes/origin/main
    public static IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
    {
        switch (msg)
        {
            case 0x0010: // WM_CLOSE
                PostQuitMessage(0);
                break;
        }

        return DefWindowProc(hWnd, msg, wParam, lParam);
    }

    public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
    
    
public static IntPtr CreateWindow(string WinName, Vector2d size, WNDCLASS wc)
{
    return CreateWindowEx(0, wc.lpszClassName, WinName, 0, 0, 0, (int)size.X, (int)size.Y, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
}
<<<<<<< HEAD
//I should really comment more this shit confusing af
public static void PrimaryDraw(string Windowname)
=======


//I should really comment more this shit confusing af
public void StainsOfTime(int framerate){
    
}

public void PrimaryDraw(string Windowname)
>>>>>>> refs/remotes/origin/main
{
    WNDCLASS wc = new WNDCLASS();
    wc.lpszClassName = "MyClassName";
    Delegate wndProcDelegate = new WndProcDelegate(WndProc);
    IntPtr wndProcPtr = Marshal.GetFunctionPointerForDelegate(wndProcDelegate);
    wc.lpfnWndProc = wndProcPtr;
<<<<<<< HEAD

=======
  
>>>>>>> refs/remotes/origin/main

    ushort regResult = RegisterClassW(ref wc);
    if (regResult == 0)
    {
        throw new System.ComponentModel.Win32Exception();
    }

<<<<<<< HEAD
    Vector2d size = new Vector2d(2560, 1440);
=======
    Vector2d size = new Vector2d(640, 480);
>>>>>>> refs/remotes/origin/main
    IntPtr hWnd = CreateWindow(Windowname, size, wc);

    if (hWnd == IntPtr.Zero)
    {
        throw new System.ComponentModel.Win32Exception();
    }

    ShowWindow(hWnd, ShowWindowCommands.Show);
    UpdateWindow(hWnd);

    Message msg;
    while (GetMessage(out msg, IntPtr.Zero, 0, 0))
    {
        TranslateMessage(ref msg);
        DispatchMessage(ref msg);
    }
     
}



<<<<<<< HEAD
=======
typedef struct tagRAWINPUT {
  RAWINPUTHEADER header;
  union {
    RAWMOUSE    mouse;
    RAWKEYBOARD keyboard;
    RAWHID      hid;
  } data;
} RAWINPUT, *PRAWINPUT, *LPRAWINPUT;*/ //Goated system, will carry me to working input system



    public static void Main()
    {
        WNDCLASS wc = new WNDCLASS();
        wc.lpszClassName = "MyClassName";
       Delegate wndProcDelegate = new WndProcDelegate(WndProc);
IntPtr wndProcPtr = Marshal.GetFunctionPointerForDelegate(wndProcDelegate);
wc.lpfnWndProc = wndProcPtr;

        ushort regResult = RegisterClassW(ref wc);
        if (regResult == 0)
        {
            throw new System.ComponentModel.Win32Exception();
        }
        

        IntPtr hWnd = CreateWindowEx(0, wc.lpszClassName, "Cheese", 0, 0, 0, 800, 600, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);

        if (hWnd == IntPtr.Zero)
        {
            throw new System.ComponentModel.Win32Exception();
        }

        ShowWindow(hWnd, ShowWindowCommands.Show);
        UpdateWindow(hWnd);

        Message msg;
        while (GetMessage(out msg, IntPtr.Zero, 0, 0))
        {
            TranslateMessage(ref msg);
            DispatchMessage(ref msg);
        }
    }

