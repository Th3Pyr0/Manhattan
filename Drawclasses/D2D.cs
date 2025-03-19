using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Drawing;
using System.Security;





[ComImport]
[Guid("2cd906a8-12e2-11dc-9fed-001143a055f9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID2D1Factory
{
    IntPtr CreateHwndRenderTarget(
        [In] ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties,
        [In] ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties,
        out IntPtr renderTarget
    );
}

[StructLayout(LayoutKind.Sequential)]
public struct D2D1_RENDER_TARGET_PROPERTIES
{
    public D2D1_RENDER_TARGET_TYPE type;
    public D2D1_PIXEL_FORMAT pixelFormat;
    public float dpiX;
    public float dpiY;
    public D2D1_RENDER_TARGET_USAGE usage;
    public D2D1_FEATURE_LEVEL minLevel;
}

[StructLayout(LayoutKind.Sequential)]
public struct D2D1_HWND_RENDER_TARGET_PROPERTIES
{
    public IntPtr hwnd;
    public D2D1_SIZE_U pixelSize;
    public D2D1_PRESENT_OPTIONS presentOptions;
}

[StructLayout(LayoutKind.Sequential)]
public struct D2D1_SIZE_U
{
    public uint width;
    public uint height;
}

public enum D2D1_RENDER_TARGET_TYPE { D2D1_RENDER_TARGET_TYPE_DEFAULT }
public enum D2D1_PIXEL_FORMAT { D2D1_PIXEL_FORMAT_DEFAULT }
public enum D2D1_RENDER_TARGET_USAGE { D2D1_RENDER_TARGET_USAGE_NONE }
public enum D2D1_FEATURE_LEVEL { D2D1_FEATURE_LEVEL_DEFAULT }
public enum D2D1_PRESENT_OPTIONS { D2D1_PRESENT_OPTIONS_NONE }

[DllImport("d2d1.dll", SetLastError = true)]
public static extern int D2D1CreateFactory(
    D2D1_FACTORY_TYPE factoryType,
    [In] ref Guid riid,
    IntPtr pFactoryOptions,
    out IntPtr ppIFactory
);

public enum D2D1_FACTORY_TYPE { D2D1_FACTORY_TYPE_SINGLE_THREADED }
