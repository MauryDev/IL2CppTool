// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.CString
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using IL2CppTool.Extensions;
using System;
using System.Text;

namespace IL2CppTool.MemType
{
  public struct CString : IObjectBase
  {
    public const int Bytes = 256;
    public const int BytesString = 1;
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

    public string Value
    {
      get => CString.GetStringFromPointer(this.app, this.m_PTR, 256);
      set => CString.SetStringFromAddress(this.app, this.m_PTR, value);
    }

    public static string GetStringFromPointer(IL2CppApp app, IntPtr pointer, int limit)
    {
      Encoding utF8 = Encoding.UTF8;
      int num = 1;
      byte[] buff = app.ReadMem(pointer, limit);
      int size = limit;
      for (int index = 0; index < buff.Length; index += num)
      {
        if (buff[index] == (byte) 0)
        {
          size = index;
          break;
        }
      }
      return utF8.GetString(buff.ReadBuff(0, size));
    }

    public static void SetStringFromAddress(IL2CppApp app, IntPtr address, string value)
    {
      byte[] buff = new byte[value.Length + 1];
      buff.WriteBytes(Encoding.UTF8.GetBytes(value), 0);
      app.Write(address, buff);
    }

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public CPointer<CString> ToPointer() => this.app.ToPointer<CString>(this.m_PTR);

    public static explicit operator string(CString cString) => cString.Value;

    public static implicit operator CString(string val) => IL2CppApp.InicializeIObjectBase<CString>(val.Length + 1) with
    {
      Value = val
    };
  }
}
