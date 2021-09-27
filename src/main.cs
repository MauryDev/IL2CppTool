using IL2CppTool;
using System;
using IL2CppTool.Extensions;
using System.Text;
using IL2CppTool.MemType;
using System.Management;
namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("kogama")[0];
            var app = new IL2CppApp(process);
            var getping = new GetPing();
            getping.GetMethods();
            while (true)
            {
                Console.WriteLine(getping.GetPingVal() + " ms");
                System.Threading.Thread.Sleep(200);
                Console.SetCursorPosition(0, 0);

            }
        }
    }
}
