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
            

            var methodname = app.NewString("get_LocalPlayer", CStringType.Char);
            var nullvalue = app.ReservePointer<CVoid>();
            var nullvalue2 = app.CastPointer<CPointer<CVoid>>(nullvalue.Address);
            var classnameptr = app.NewString("MVGameControllerBase", CStringType.Char);
            var namespace_defaultptr = app.NewString("", CStringType.Char);
            var assemblynameptr = app.NewString("Assembly-CSharp", CStringType.Char);
            var endcalladdress = app.NewObject<C4Bytes>(IntPtr.Zero);

            var mycall = app.CreateCall();
            app.il2cpp_domain_get(out CPointer<CVoid> domain);
            app.IsNull(domain, endcalladdress);
            app.il2cpp_thread_attach(domain, out CPointer<CVoid> thread);
            app.il2cpp_domain_assembly_open(domain, assemblynameptr.ToPointer(), out CPointer<CVoid> assembly);
            app.IsNull(assembly, endcalladdress);
            app.il2cpp_assembly_get_image(assembly, out CPointer<CVoid> image);
            app.IsNull(image, endcalladdress);
            app.il2cpp_class_from_name(image, namespace_defaultptr.ToPointer(), classnameptr.ToPointer(), out CPointer<CVoid> klass);
            app.IsNull(klass, endcalladdress);
            app.il2cpp_class_get_method_from_name(klass, methodname.ToPointer(), app.NewObject<C4Bytes>(0),out CPointer<CVoid> method);
            app.IsNull(method, endcalladdress);
            app.il2cpp_runtime_invoke(method, nullvalue, nullvalue2, nullvalue, out CPointer<CVoid> ret);
            app.il2cpp_class_get_name(klass, out CPointer<CString> klassname);
            endcalladdress.ValueIntPtr = app.EndCall();
            CallMyInfo(app, ret, mycall, klassname);
        }
        public static void CallMyInfo(IL2CppApp app, CPointer<CVoid> result,IntPtr method, CPointer<CString> cPointer)
        {
            app.Call(method);
            var val = (IntPtr)result;
            if (val != IntPtr.Zero)
            {
                var gamesession = new MVLocalPlayer(val, app);
                Console.WriteLine((int)gamesession.XP);
                Console.WriteLine((int)gamesession.Level);
                Console.ReadKey();
                
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
