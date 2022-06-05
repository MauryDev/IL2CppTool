// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.Il2CppObject
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct Il2CppObject : IObjectBase
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

    public Il2CppObject(IntPtr address, IL2CppApp app)
    {
      this.m_PTR = address;
      this.app = app;
    }

    public CPointer<CVoid> Klass => this.app.Cast<CPointer<CVoid>>(this.m_PTR);

    public CPointer<CVoid> Monitor => this.app.Cast<CPointer<CVoid>>(this.m_PTR + 4);

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<Il2CppObject> ToPointer() => this.app.ToPointer<Il2CppObject>(this.m_PTR);
  }
}
