using Microsoft.Win32;
using System;

namespace Full
{
    public static class FullUtil
    {
        public static void Run()
        {
            var key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
            var product = key.GetValue("ProductName");

            Console.WriteLine($"Hello from .NET Framework on {product}!");
        }
    }
}
