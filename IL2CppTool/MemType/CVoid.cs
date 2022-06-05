// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.CVoid
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct CVoid : IObjectBase
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

    public CVoid(IntPtr address, IL2CppApp app)
    {
      this.m_PTR = address;
      this.app = app;
    }

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<CVoid> ToPointer() => new CPointer<CVoid>(this.app, this.m_PTR);
  }
}
