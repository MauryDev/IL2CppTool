// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.CByte
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct CByte : IObjectBase, IStruct
  {
    public const int Bytes = 1;
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

    public CByte(IntPtr address, IL2CppApp app)
    {
      this.m_PTR = address;
      this.app = app;
    }

    public byte ValueUInt8
    {
      get => CByte.GetValue(this.app, this.m_PTR);
      set => CByte.SetValue(value, this.app, this.m_PTR);
    }

    public sbyte ValueInt8
    {
      get => (sbyte) CByte.GetValue(this.app, this.m_PTR);
      set => CByte.SetValue((byte) value, this.app, this.m_PTR);
    }

    public bool ValueBool
    {
      get => Convert.ToBoolean(CByte.GetValue(this.app, this.m_PTR));
      set => CByte.SetValue(Convert.ToByte(value), this.app, this.m_PTR);
    }

    public static byte GetValue(IL2CppApp app, IntPtr address) => app.ReadMem(address, 1)[0];

    public static void SetValue(byte value, IL2CppApp app, IntPtr address) => app.Write(address, new byte[1]
    {
      value
    });

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<CByte> ToPointer() => new CPointer<CByte>(this.app, this.m_PTR);

    public void op_new(IL2CppApp app, object val)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(1);
      switch (val)
      {
        case sbyte num1:
          this.ValueInt8 = num1;
          break;
        case byte num2:
          this.ValueUInt8 = num2;
          break;
        case bool flag:
          this.ValueBool = flag;
          break;
      }
    }

    private static CByte Create(object val)
    {
      CByte cbyte = new CByte();
      cbyte.op_new(IL2CppApp.Current, val);
      return cbyte;
    }

    public int ByteSize => 1;

    public static explicit operator byte(CByte cByte) => cByte.ValueUInt8;

    public static explicit operator sbyte(CByte cByte) => cByte.ValueInt8;

    public static explicit operator bool(CByte cByte) => cByte.ValueBool;

    public static implicit operator CByte(byte val) => IL2CppApp.InicializeIObjectBase<CByte>(1) with
    {
      ValueUInt8 = val
    };

    public static implicit operator CByte(sbyte val) => CByte.Create((object) val);

    public static implicit operator CByte(bool val) => CByte.Create((object) val);
  }
}
