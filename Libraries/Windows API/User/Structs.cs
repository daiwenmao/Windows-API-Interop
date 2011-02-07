﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class User
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct WNDCLASSEX
        {
           public uint cbSize;
           public ClassStyles style;
           [MarshalAs(UnmanagedType.FunctionPtr)]
           public WindowProc lpfnWndProc;
           public int cbClsExtra;
           public int cbWndExtra;
           public IntPtr hInstance;
           public IntPtr hIcon;
           public IntPtr hCursor;
           public IntPtr hbrBackground;
           public string lpszMenuName;
           public string lpszClassName;
           public IntPtr hIconSm;
        }

    }

}
