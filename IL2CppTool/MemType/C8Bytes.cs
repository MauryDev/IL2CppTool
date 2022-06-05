// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.C8Bytes
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct C8Bytes : IObjectBase, IStruct
  {
    public const int Bytes = 8;
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

    public long ValueInt64
    {
      get => C8Bytes.GetValue(this.app, this.m_PTR);
      set => C8Bytes.SetValue(value, this.app, this.m_PTR);
    }

    public ulong ValueUInt64
    {
      get => (ulong) C8Bytes.GetValue(this.app, this.m_PTR);
      set => C8Bytes.SetValue((long) value, this.app, this.m_PTR);
    }

    public int ByteSize => 8;

    public static long GetValue(IL2CppApp app, IntPtr address) => BitConverter.ToInt64(app.ReadMem(address, 8), 0);

    public static void SetValue(long value, IL2CppApp app, IntPtr address) => app.Write(address, BitConverter.GetBytes(value));

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<C8Bytes> ToPointer() => this.app.ToPointer<C8Bytes>(this.m_PTR);

    public void op_new(IL2CppApp app, object val)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(8);
      switch (val)
      {
        case long num:
          this.ValueInt64 = num;
          break;
        case uint _:
          this.ValueUInt64 = (ulong) val;
          break;
      }
    }

    private static C8Bytes Create(object val)
    {
      C8Bytes c8Bytes = new C8Bytes();
      c8Bytes.op_new(IL2CppApp.Current, val);
      return c8Bytes;
    }

    public static explicit operator long(C8Bytes c8Bytes) => c8Bytes.ValueInt64;

    public static explicit operator ulong(C8Bytes c8Bytes) => c8Bytes.ValueUInt64;

    public static implicit operator C8Bytes(long val) => C8Bytes.Create((object) val);

    public static implicit operator C8Bytes(ulong val) => C8Bytes.Create((object) val);
  }
}
