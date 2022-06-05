// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.C4Bytes
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct C4Bytes : IObjectBase, IStruct
  {
    public const int Bytes = 4;
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

    public int ValueInt32
    {
      get => C4Bytes.GetValue(this.app, this.m_PTR);
      set => C4Bytes.SetValue(value, this.app, this.m_PTR);
    }

    public IntPtr ValueIntPtr
    {
      get => (IntPtr) C4Bytes.GetValue(this.app, this.m_PTR);
      set => C4Bytes.SetValue((int) value, this.app, this.m_PTR);
    }

    public uint ValueUInt32
    {
      get => (uint) C4Bytes.GetValue(this.app, this.m_PTR);
      set => C4Bytes.SetValue((int) value, this.app, this.m_PTR);
    }

    public static int GetValue(IL2CppApp app, IntPtr address) => BitConverter.ToInt32(app.ReadMem(address, 4), 0);

    public static void SetValue(int value, IL2CppApp app, IntPtr address) => app.Write(address, BitConverter.GetBytes(value));

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<C4Bytes> ToPointer() => new CPointer<C4Bytes>(this.app, this.m_PTR);

    public void op_new(IL2CppApp app, object val)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(4);
      switch (val)
      {
        case int num1:
          this.ValueInt32 = num1;
          break;
        case uint num2:
          this.ValueUInt32 = num2;
          break;
        case IntPtr num3:
          this.ValueIntPtr = num3;
          break;
      }
    }

    private static C4Bytes Create(object val)
    {
      C4Bytes c4Bytes = new C4Bytes();
      c4Bytes.op_new(IL2CppApp.Current, val);
      return c4Bytes;
    }

    public int ByteSize => 4;

    public static explicit operator IntPtr(C4Bytes c4Bytes) => c4Bytes.ValueIntPtr;

    public static explicit operator int(C4Bytes c4Bytes) => c4Bytes.ValueInt32;

    public static explicit operator uint(C4Bytes c4Bytes) => c4Bytes.ValueUInt32;

    public static implicit operator C4Bytes(IntPtr val) => C4Bytes.Create((object) val);

    public static implicit operator C4Bytes(int val) => C4Bytes.Create((object) val);

    public static implicit operator C4Bytes(uint val) => C4Bytes.Create((object) val);
  }
}
