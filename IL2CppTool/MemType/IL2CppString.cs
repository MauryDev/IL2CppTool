// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.IL2CppString
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;
using System.Text;

namespace IL2CppTool.MemType
{
  public struct IL2CppString : IObjectBase
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

    public IL2CppString(IntPtr address, IL2CppApp app)
    {
      this.m_PTR = address;
      this.app = app;
    }

    public Il2CppObject Object => new Il2CppObject(this.m_PTR, this.app);

    public int Length => (int) this.app.Cast<C4Bytes>(this.m_PTR + 8);

    public string Value
    {
      get => Encoding.Unicode.GetString(this.app.ReadMem(this.m_PTR + 12, this.Length * 2));
      set => this.app.Write(this.m_PTR + 12, Encoding.Unicode.GetBytes(value));
    }

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<IL2CppString> ToPointer() => this.app.ToPointer<IL2CppString>(this.m_PTR);

    public static explicit operator string(IL2CppString iL2CppString) => iL2CppString.Value;
  }
}
