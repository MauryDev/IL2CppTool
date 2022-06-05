// Decompiled with JetBrains decompiler
// Type: IL2CppTool.Module
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool
{
  public class Module
  {
    public IL2CppApp app;
    private IntPtr allocationaddress;
    private int offsetData;
    private int length;

    public IntPtr CurrentAddress => this.allocationaddress + this.offsetData;

    public Module(IL2CppApp app, IntPtr address, int size)
    {
      this.app = app;
      this.allocationaddress = address;
      this.length = size;
    }

    public IntPtr WriteData(byte[] buff)
    {
      IntPtr currentAddress = this.CurrentAddress;
      int num = this.offsetData + buff.Length;
      if (num > this.length)
        throw new Exception("offset > " + (object) this.length);
      NativeMethods.WriteMem(this.app.handler, currentAddress, buff);
      this.offsetData = num;
      return currentAddress;
    }

    public IntPtr ReserveData(int size)
    {
      IntPtr currentAddress = this.CurrentAddress;
      int num = this.offsetData + size;
      this.offsetData = num <= this.length ? num : throw new Exception("offset > " + (object) this.length);
      return currentAddress;
    }
  }
}
