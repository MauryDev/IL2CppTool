// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.CDouble
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct CDouble : IObjectBase, IStruct
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

    public double Value
    {
      get => CDouble.GetValue(this.app, this.m_PTR);
      set => CDouble.SetValue(value, this.app, this.m_PTR);
    }

    public static double GetValue(IL2CppApp app, IntPtr address) => (double) BitConverter.ToSingle(app.ReadMem(address, 8), 0);

    public static void SetValue(double value, IL2CppApp app, IntPtr address) => app.Write(address, BitConverter.GetBytes(value));

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<CDouble> ToPointer() => this.app.ToPointer<CDouble>(this.m_PTR);

    public void op_new(IL2CppApp app, object val)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(8);
      if (!(val is double num))
        return;
      this.Value = num;
    }

    public int ByteSize => 8;

    public static explicit operator double(CDouble cDouble) => cDouble.Value;

    public static implicit operator CDouble(double val)
    {
      CDouble cdouble = new CDouble();
      cdouble.op_new(IL2CppApp.Current, (object) val);
      return cdouble;
    }
  }
}
