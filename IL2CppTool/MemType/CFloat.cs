// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.CFloat
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct CFloat : IObjectBase, IStruct
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

    public float Value
    {
      get => CFloat.GetValue(this.app, this.m_PTR);
      set => CFloat.SetValue(value, this.app, this.m_PTR);
    }

    public static float GetValue(IL2CppApp app, IntPtr address) => BitConverter.ToSingle(app.ReadMem(address, 4), 0);

    public static void SetValue(float value, IL2CppApp app, IntPtr address) => app.Write(address, BitConverter.GetBytes(value));

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<CFloat> ToPointer() => this.app.ToPointer<CFloat>(this.m_PTR);

    public void op_new(IL2CppApp app, object val)
    {
      this.app = app;
      this.m_PTR = app.ReserveData(4);
      if (!(val is float num))
        return;
      this.Value = num;
    }

    public int ByteSize => 4;

    public static explicit operator float(CFloat cFloat) => cFloat.Value;

    public static implicit operator CFloat(float val)
    {
      CFloat cfloat = new CFloat();
      cfloat.op_new(IL2CppApp.Current, (object) val);
      return cfloat;
    }
  }
}
