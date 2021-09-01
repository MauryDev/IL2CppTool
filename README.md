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
            

            var methodname = app.NewString("get_LocalPlayer",CString.CStringType.Char);
            var nullvalue = app.NewObject(IntPtr.Zero,MemEnum.IntPtr);
            var classnameptr = app.NewString("MVGameControllerBase", CString.CStringType.Char);
            var namespace_defaultptr = app.NewString("", CString.CStringType.Char);
            var assemblynameptr = app.NewString("Assembly-CSharp", CString.CStringType.Char);
            var endcalladdress = app.NewObject(IntPtr.Zero, MemEnum.IntPtr);

            var mycall = app.CreateCall();
            app.il2cpp_domain_get(out CObject<IntPtr> domain);
            app.IsNull(domain, endcalladdress);
            app.il2cpp_thread_attach(domain, out CObject<IntPtr> thread);
            app.il2cpp_domain_assembly_open(domain, assemblynameptr.ToPointer(), out CObject<IntPtr> assembly);
            app.IsNull(assembly, endcalladdress);
            app.il2cpp_assembly_get_image(assembly, out CObject<IntPtr> image);
            app.IsNull(image, endcalladdress);
            app.il2cpp_class_from_name(image, namespace_defaultptr.ToPointer(), classnameptr.ToPointer(), out CObject<IntPtr> klass);
            app.IsNull(klass, endcalladdress);
            app.il2cpp_class_get_method_from_name(klass, methodname.ToPointer(), app.NewObject(0,MemEnum.Int),out CObject<IntPtr> method);
            app.IsNull(method, endcalladdress);
            app.il2cpp_runtime_invoke(method, nullvalue, app.NewObject(IntPtr.Zero, MemEnum.IntPtr), app.NewObject(IntPtr.Zero, MemEnum.IntPtr), out CObject<IntPtr> ret);
            endcalladdress.Value = app.EndCall();
            while (true)
            {
                Console.ReadKey();
                Console.WriteLine("My Info");
                CallMyInfo(app, ret, mycall);
            }
        }
        public static void CallMyInfo(IL2CppApp app, CObject<IntPtr> result,IntPtr method)
        {
            app.Call(method);
            var val = result.Value;
            if (val != IntPtr.Zero)
            {
                var level = app.ReadMem<int>(val + 0x10, MemEnum.Int);
                var team = GetTeamName(app.ReadMem<int>(val + 0x14, MemEnum.Int));
                var profileID = app.ReadMem<int>(val + 0x24, MemEnum.Int);
                var actorid = app.ReadMem<int>(val + 0x28, MemEnum.Int);
                Console.WriteLine($@"
Level : {level}
Team : {team}
Profile ID : {profileID}
Actor ID : {actorid}
");
            }
        }
        public static string GetTeamName(int id)
        {
            string name = "None";
            switch (id)
            {
                case 0:
                    name = "Blue";
                    break;
                case 1:
                    name = "Red";
                    break;
                case 2:
                    name = "Green";
                    break;
                case 3:
                    name = "Yellow";
                    break;
            }
            return name;
        }
    }
}
```
