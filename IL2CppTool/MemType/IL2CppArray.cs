// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.IL2CppArray
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct IL2CppArray : IObjectBase
  {
    public IntPtr m_PTR;
    public IL2CppApp app;

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

    public IL2CppArray(IntPtr address, IL2CppApp app)
    {
      this.m_PTR = address;
      this.app = app;
    }

    public Il2CppObject Object => new Il2CppObject(this.m_PTR, this.app);

    public CPointer<CVoid> Bounds => this.app.Cast<CPointer<CVoid>>(this.m_PTR + 8);

    public int Length => this.app.Cast<C4Bytes>(this.m_PTR + 12).ValueInt32;

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<IL2CppArray> ToPointer() => this.app.ToPointer<IL2CppArray>(this.m_PTR);
  }
}
