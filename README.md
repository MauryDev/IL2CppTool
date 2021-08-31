Example:
```cs
using IL2CppTool;
using System;
using IL2CppTool.Extensions;
using System.Text;
using IL2CppTool.MemType;
namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            IL2CppApp app = new IL2CppApp(System.Diagnostics.Process.GetProcessesByName("kogama")[0]);
            

            var methodname = app.New("get_LocalPlayer", MemEnum.Char, true);
            var nullvalue = app.New(IntPtr.Zero,MemEnum.IntPtr);
            var classnameptr = app.New("MVGameControllerBase", MemEnum.Char, true);
            var namespace_defaultptr = app.New("", MemEnum.Char, true);
            var assemblynameptr = app.New("Assembly-CSharp", MemEnum.Char, true);
            var endcalladdress = app.New(IntPtr.Zero, MemEnum.IntPtr);

            var mycall = app.CreateCall();
            app.il2cpp_domain_get(out MemObject<IntPtr> domain);
            app.IsNull(domain, endcalladdress);
            app.il2cpp_thread_attach(domain, out MemObject<IntPtr> thread);
            app.il2cpp_domain_assembly_open(domain, assemblynameptr, out MemObject<IntPtr> assembly);
            app.IsNull(assembly, endcalladdress);
            app.il2cpp_assembly_get_image(assembly, out MemObject<IntPtr> image);
            app.IsNull(image, endcalladdress);
            app.il2cpp_class_from_name(image, namespace_defaultptr, classnameptr, out MemObject<IntPtr> klass);
            app.IsNull(klass, endcalladdress);
            app.il2cpp_class_get_method_from_name(klass, methodname, app.New(0,MemEnum.Int),out MemObject<IntPtr> method);
            app.IsNull(method, endcalladdress);
            app.il2cpp_runtime_invoke(method, nullvalue, app.New(IntPtr.Zero, MemEnum.IntPtr,true), app.New(IntPtr.Zero, MemEnum.IntPtr,true), out MemObject<IntPtr> ret);
            endcalladdress.Value = app.EndCall();
            while (true)
            {
                Console.ReadKey();
                Console.WriteLine("My Info");
                CallMyInfo(app, ret, mycall);
            }
        }
        public static void CallMyInfo(IL2CppApp app,MemObject<IntPtr> result,IntPtr method)
        {
            app.Call(method);
            var val = result.Value;
            if (val != IntPtr.Zero)
            {
                var level = app.ReadMem<int>(val + 0x10, 4, MemEnum.Int);
                var team = app.ReadMem<int>(val + 0x14, 4, MemEnum.Int);
                var profileID = app.ReadMem<int>(val + 0x24, 4, MemEnum.Int);
                var actorid = app.ReadMem<int>(val + 0x28, 4, MemEnum.Int);
                Console.WriteLine($@"
Level : {level}
Team : {team}
Profile ID : {profileID}
Actor ID : {actorid}
");
            }
        }
    }
}
```
