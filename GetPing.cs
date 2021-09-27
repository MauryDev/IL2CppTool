using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IL2CppTool;
using IL2CppTool.MemType;
namespace RandomList
{
    public class GetPing
    {
        Action GetMethods_Fun,Get_Ping_Fun;
        CPointer<C4Bytes> retval;
        CPointer<CVoid> get_Game_method, get_Peer_method, get_RoundTripTime_method;
        void Compile_GetMethods()
        {
            // 			MVGameControllerBase.Game.Peer.RoundTripTime
            // ExitGames.Client.Photon , PhotonPeer , Photon3Unity3D
            var app = IL2CppApp.Current;
            CPointer<CString> assemblyname = (CString)"Assembly-CSharp";
            CPointer<CString> Photon3Unity3D_assemblyname = (CString)"Photon3Unity3D";
            CPointer<CString> namespace_default_name = (CString)"";
            CPointer<CString> MVGameControllerBase_name = (CString)"MVGameControllerBase";
            CPointer<CString> MVNetworkGame_name = (CString)"MVNetworkGame";
            CPointer<CString> PhotonPeer_name = (CString)"PhotonPeer";
            CPointer<CString> ExitGames_Client_Photon_name = (CString)"ExitGames.Client.Photon";
            CPointer<CString> get_Game_name = (CString)"get_Game";
            CPointer<CString> get_Peer_name = (CString)"get_Peer";
            CPointer<CString> get_RoundTripTime_name = (CString)"get_RoundTripTime";


            C4Bytes none_args = 0;

            var call = app.CreateMethod();
            // domain
            var domain = call.il2cpp_domain_get();
            call.il2cpp_thread_attach(domain);
            // assembly
            var assembly = call.il2cpp_domain_assembly_open(domain, assemblyname);
            var Photon3Unity3D_assembly = call.il2cpp_domain_assembly_open(domain, Photon3Unity3D_assemblyname);
            // images
            var image = call.il2cpp_assembly_get_image(assembly);
            var image2 = call.il2cpp_assembly_get_image(Photon3Unity3D_assembly);
            // klasses
            var MVGameControllerBase_klass = call.il2cpp_class_from_name(image, namespace_default_name, MVGameControllerBase_name);
            var MVNetworkGame_klass = call.il2cpp_class_from_name(image, namespace_default_name, MVNetworkGame_name);
            var PhotonPeer_klass = call.il2cpp_class_from_name(image2, ExitGames_Client_Photon_name, PhotonPeer_name);
            // methods
            get_Game_method = call.il2cpp_class_get_method_from_name(MVGameControllerBase_klass, get_Game_name, none_args);
            get_Peer_method = call.il2cpp_class_get_method_from_name(MVNetworkGame_klass, get_Peer_name, none_args);
            get_RoundTripTime_method = call.il2cpp_class_get_method_from_name(PhotonPeer_klass, get_RoundTripTime_name, none_args);
            call.EndCall();
            GetMethods_Fun = call.ToDel();
        }
        public void GetMethods()
        {
            if (GetMethods_Fun == null)
            {
                Compile_GetMethods();
            }
            GetMethods_Fun();
        }
        public void Compile_GetPing()
        {
            var app = IL2CppApp.Current;
            CPointer<Il2CppObject> nullobj = IntPtr.Zero;
            CPointer<CVoid> nullexc = IntPtr.Zero;
            CPointer<CPointer<CVoid>> nullparam = IntPtr.Zero;

            var call = app.CreateMethod();
            call.il2cpp_thread_attach(call.il2cpp_domain_get());
            var game = call.il2cpp_runtime_invoke(get_Game_method, nullobj, nullparam, nullexc);
            var peer = call.il2cpp_runtime_invoke(get_Peer_method, game, nullparam, nullexc);
            var roundtriptime = call.il2cpp_runtime_invoke(get_RoundTripTime_method, peer, nullparam, nullexc);
            retval = app.Cast<CPointer<C4Bytes>>(call.il2cpp_object_unbox(roundtriptime));
            call.EndCall();
            Get_Ping_Fun = call.ToDel();
        }
        public int GetPingVal()
        {
            if (Get_Ping_Fun == null)
            {
                Compile_GetPing();
            }
            Get_Ping_Fun();
            return (int)retval.Value;
        }
    }
}
