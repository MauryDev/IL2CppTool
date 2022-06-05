// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.CPointer`1
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct CPointer<T> : IObjectBase, IStruct, ICPointer where T : struct, IObjectBase
  {
    public const int Bytes = 4;
    public IntPtr m_PTR;
    private IL2CppApp app;

    public CPointer(IL2CppApp app, IntPtr pointer)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(4);
      this.Pointer = pointer;
    }

    public static CPointer<T> Cast(IL2CppApp app, IntPtr address) => new CPointer<T>()
    {
      m_PTR = address,
      app = app
    };

    public IL2CppApp App
    {
      get => this.app;
      set => this.app = value;
    }

    public IntPtr Address
    {
      get => this.m_PTR;
      set => this.m_PTR = value;
    }

    public IntPtr Pointer
    {
      get => this.app.Cast<C4Bytes>(this.m_PTR).ValueIntPtr;
      //set => this.app.Cast<C4Bytes>(this.m_PTR).ValueIntPtr = value;
      set => this = this.app.Cast<C4Bytes>(this.m_PTR).ValueIntPtr;
    }

    public T Value => this.app.Cast<T>(this.Pointer);

    public int ByteSize => 4;

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<CPointer<T>> ToPointer() => this.app.ToPointer<CPointer<T>>(this.m_PTR);

    public void op_new(IL2CppApp app, object val)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(4);
      if (!(val is IntPtr num))
        return;
      this.Pointer = num;
    }

    public static explicit operator T(CPointer<T> cPointer) => cPointer.Value;

    public static explicit operator IntPtr(CPointer<T> cPointer) => cPointer.Pointer;

    public static implicit operator CPointer<T>(IntPtr val)
    {
      CPointer<T> cpointer = new CPointer<T>();
      cpointer.op_new(IL2CppApp.Current, (object) val);
      return cpointer;
    }

    public static implicit operator CPointer<T>(T val) => (CPointer<T>) val.ToPointer();
  }
}
