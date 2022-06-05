// Decompiled with JetBrains decompiler
// Type: IL2CppTool.IL2CppApp
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using IL2CppTool.MemType;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IL2CppTool
{
  public class IL2CppApp
  {
    private Module ModuleData;
    private Module ModuleFun;
    private IntPtr gameAssembly;
    internal Dictionary<string, IntPtr> methodIl2cpp;

    public static IL2CppApp Current { get; set; }

    public IntPtr handler { get; private set; }

    public Module CurrentModuleData { get; set; }

    public IntPtr CurrentAddressData => this.CurrentModuleData.CurrentAddress;

    public IntPtr CurrentAddressFun => this.ModuleFun.CurrentAddress;

    public IL2CppApp(Process process)
    {
      if (process != null)
      {
        this.handler = NativeMethods.OpenProcess(ProcessAccessFlags.All, false, process.Id);
        IntPtr address1 = NativeMethods.VirtualAllocEx(this.handler, IntPtr.Zero, 10000, AllocationType.MEM_COMMIT, MemoryProtection.PAGE_EXECUTE_READWRITE);
        this.ModuleData = new Module(this, address1, 5000);
        this.ModuleFun = new Module(this, address1 + 5000, 5000);
        this.CurrentModuleData = this.ModuleData;
        this.gameAssembly = NativeMethods.GetModuleByname(process.Modules, "GameAssembly.dll").BaseAddress;
        this.methodIl2cpp = new Dictionary<string, IntPtr>();
        foreach (ExportedFunction exportedFunction in ProcessUtil.GetExportedFunctions(this.handler, this.gameAssembly))
        {
          string name = exportedFunction.Name;
          IntPtr address2 = exportedFunction.Address;
          if (this.methodIl2cpp.ContainsKey(name))
            this.methodIl2cpp[name] = address2;
          else
            this.methodIl2cpp.Add(name, address2);
        }
      }
      IL2CppApp.Current = this;
    }

    internal static T InicializeIObjectBase<T>(int bytes) where T : struct, IObjectBase
    {
      IL2CppApp current = IL2CppApp.Current;
      return new T()
      {
        Address = current.ReserveData(bytes),
        App = current
      };
    }

    public T ReserveObject<T>() where T : struct, IStruct, IObjectBase
    {
      T obj = new T() { App = this };
      obj.Address = this.ReserveData(obj.ByteSize);
      return obj;
    }

    public T Cast<T>(IntPtr address) where T : struct, IObjectBase => new T()
    {
      Address = address,
      App = this
    };

    public T Cast<T>(IObjectBase objectBase) where T : struct, IObjectBase => this.Cast<T>(objectBase.Address);

    public CPointer<T> ReservePointer<T>() where T : struct, IObjectBase => CPointer<T>.Cast(this, this.ReserveData(4));

    public CPointer<T> ToPointer<T>(IntPtr pointer) where T : struct, IObjectBase => CPointer<T>.Cast(this, this.ReserveData(4)) with
    {
      Pointer = pointer
    };

    public IntPtr ReserveData(int size) => this.CurrentModuleData.ReserveData(size);

    public IntPtr WriteFun(byte[] buff) => this.ModuleFun.WriteData(buff);

    public void Write(IntPtr address, byte[] buff) => NativeMethods.WriteMem(this.handler, address, buff);

    public byte[] ReadMem(IntPtr address, int size)
    {
      byte[] lpBuffer = new byte[size];
      NativeMethods.ReadProcessMemory(this.handler, address, lpBuffer, size);
      return lpBuffer;
    }

    public MethodNative CreateMethod() => new MethodNative(this);

    public void Call(IntPtr address) => NativeMethods.Execute(address, IntPtr.Zero, this.handler);
  }
}
