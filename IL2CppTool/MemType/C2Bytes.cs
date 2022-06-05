// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.C2Bytes
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct C2Bytes : IObjectBase, IStruct
  {
    public const int Bytes = 2;
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

    public short ValueInt16
    {
      get => C2Bytes.GetValue(this.app, this.m_PTR);
      set => C2Bytes.SetValue(value, this.app, this.m_PTR);
    }

    public ushort ValueUInt16
    {
      get => (ushort) C2Bytes.GetValue(this.app, this.m_PTR);
      set => C2Bytes.SetValue((short) value, this.app, this.m_PTR);
    }

    public char ValueChar
    {
      get => (char) C2Bytes.GetValue(this.app, this.m_PTR);
      set => C2Bytes.SetValue((short) value, this.app, this.m_PTR);
    }

    public static short GetValue(IL2CppApp app, IntPtr address) => BitConverter.ToInt16(app.ReadMem(address, 2), 0);

    public static void SetValue(short value, IL2CppApp app, IntPtr address) => app.Write(address, BitConverter.GetBytes(value));

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<C2Bytes> ToPointer() => this.app.ToPointer<C2Bytes>(this.m_PTR);

    public void op_new(IL2CppApp app, object val)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(2);
      switch (val)
      {
        case short num1:
          this.ValueInt16 = num1;
          break;
        case ushort num2:
          this.ValueUInt16 = num2;
          break;
        case char ch:
          this.ValueChar = ch;
          break;
      }
    }

    private static C2Bytes Create(object val)
    {
      C2Bytes c2Bytes = new C2Bytes();
      c2Bytes.op_new(IL2CppApp.Current, val);
      return c2Bytes;
    }

    public int ByteSize => 2;

    public static explicit operator short(C2Bytes c2Bytes) => c2Bytes.ValueInt16;

    public static explicit operator ushort(C2Bytes c2Bytes) => c2Bytes.ValueUInt16;

    public static explicit operator char(C2Bytes c2Bytes) => c2Bytes.ValueChar;

    public static implicit operator C2Bytes(ushort val) => C2Bytes.Create((object) val);

    public static implicit operator C2Bytes(short val) => C2Bytes.Create((object) val);

    public static implicit operator C2Bytes(char val) => C2Bytes.Create((object) val);
  }
}
