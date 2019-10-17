using System;
using System.Runtime.InteropServices;
using MyGenerics;

namespace InteropServicesTest
{
    public class InteropTest : ITesting
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        public void Test()
        {
            MessageBox(new IntPtr(0), "Using DLLImport! user32.dll !!", "Interop Dialog", 0);
        }
    }
}