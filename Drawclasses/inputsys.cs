using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Formats;
using System.Windows;
using System.Security.Cryptography.X509Certificates;
using System.Text.Unicode;
using System.Reflection.Metadata;


public class Inputs{
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

[StructLayout(LayoutKind.Sequential)]
public struct RAWINPUTHEADER
{
    public uint dwType;       // Type of device (mouse, keyboard, HID)
    public uint dwSize;       // Size of the RAWINPUT structure
    public IntPtr hDevice;    // Handle to the device generating the input
    public IntPtr wParam;     // Additional event information (optional)
}

// Define the RAWMOUSE structure
[StructLayout(LayoutKind.Sequential)]
public struct RAWMOUSE
{
    public ushort usFlags;        // Flags for the event
    public uint ulButtons;        // Button data
    public uint ulRawButtons;     // Raw button data
    public int lLastX;            // Relative X motion
    public int lLastY;            // Relative Y motion
    public uint ulExtraInformation; // Extra device-specific information
}

// Define the RAWKEYBOARD structure
[StructLayout(LayoutKind.Sequential)]
public struct RAWKEYBOARD
{
    public ushort MakeCode;          // Scan code
    public ushort Flags;             // Key flags
    public ushort Reserved;          // Reserved
    public ushort VKey;              // Virtual key code
    public uint Message;             // Corresponding Windows message
    public uint ExtraInformation;    // Extra device-specific information
}

// Define the RAWHID structure
[StructLayout(LayoutKind.Sequential)]
public struct RAWHID
{
    public uint dwSizeHid;   
    public uint dwCount;    
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
    public byte[] bRawData;  
}


[StructLayout(LayoutKind.Explicit)]
public struct RAWINPUT
{
    [FieldOffset(0)]
    public RAWINPUTHEADER header; 

    [FieldOffset(16)] // Offset 
    public RAWMOUSE mouse;       

    [FieldOffset(16)]
    public RAWKEYBOARD keyboard;  

    [FieldOffset(16)]
    public RAWHID hid;            
}
    public void ClickSys(bool clicked, Vector2d clickedcords){
        
        if (clicked){
            
        }
        
        

    }
}