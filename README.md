Example:
```cs

namespace RandomList
{
    public class Testers
    {
        public static IObjectBase[] Example(IL2CppApp app, out IntPtr methodpointer)
        {

            CString methodname = "get_LocalPlayer";
            CPointer<Il2CppObject> nullvalue = IntPtr.Zero;
            CPointer<CVoid> exception = IntPtr.Zero;
            var nullvalue2 = app.CastPointer<CPointer<CVoid>>(nullvalue.Address);
            CString classnameptr = "MVGameControllerBase";
            CString namespace_defaultptr = "";
            CString assemblynameptr = "Assembly-CSharp";
            C4Bytes endcalladdress = IntPtr.Zero;

            methodpointer = app.CreateCall();
            var domain = app.il2cpp_domain_get();
            app.IsNull(domain, endcalladdress);
            app.il2cpp_thread_attach(domain);
            var assembly = app.il2cpp_domain_assembly_open(domain, assemblynameptr.ToPointer());
            app.IsNull(assembly, endcalladdress);
            var image = app.il2cpp_assembly_get_image(assembly);
            app.IsNull(image, endcalladdress);
            var klass = app.il2cpp_class_from_name(image, namespace_defaultptr.ToPointer(), classnameptr.ToPointer());
            app.IsNull(klass, endcalladdress);
            var method = app.il2cpp_class_get_method_from_name(klass, methodname.ToPointer(), 0);
            app.IsNull(method, endcalladdress);
            var ret = app.il2cpp_runtime_invoke(method, nullvalue, nullvalue2, exception);
            endcalladdress.ValueIntPtr = app.EndCall();
            return new IObjectBase[]
            {
                ret
            };
        }
        public static void CallMyInfo(IL2CppApp app, CPointer<Il2CppObject> result, IntPtr method)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                Console.WriteLine("Press any key for get your info!");
                Console.ReadKey();
                app.Call(method);
                var val = (IntPtr)result;
                if (val != IntPtr.Zero)
                {
                    var gamesession = new MVLocalPlayer(val, app);
                    Console.WriteLine("XP: " + (int)gamesession.XP);
                    Console.WriteLine("Level: " + (int)gamesession.Level);
                    Console.WriteLine("Username: " + (string)gamesession.Name.Value);
                    Console.WriteLine("Gold: " + (int)gamesession.Gold);
                }
            }
        }
    }
}
```
