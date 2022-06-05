// Decompiled with JetBrains decompiler
// Type: IL2CppTool.Extensions.Helpers
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;
using System.Text;

namespace IL2CppTool.Extensions
{
  public static class Helpers
  {
    public static int ReadInt32(this byte[] buff, int offset) => BitConverter.ToInt32(buff, offset);

    public static short ReadInt16(this byte[] buff, int offset) => BitConverter.ToInt16(buff, offset);

    public static byte[] ReadBuff(this byte[] buff, int offset, int size)
    {
      byte[] destinationArray = new byte[size];
      Array.ConstrainedCopy((Array) buff, offset, (Array) destinationArray, 0, size);
      return destinationArray;
    }

    public static float ReadSingle(this byte[] buff, int offset) => BitConverter.ToSingle(buff, offset);

    public static string ReadString(this byte[] buff, int offset)
    {
      int num = Array.IndexOf<byte>(buff, (byte) 0, offset);
      return num != -1 ? Encoding.UTF8.GetString(buff.ReadBuff(offset, num - offset)) : Encoding.UTF8.GetString(buff.ReadBuff(offset, buff.Length - offset));
    }

    public static void WriteBytes(this byte[] buff, byte[] val, int offset) => Array.ConstrainedCopy((Array) val, 0, (Array) buff, offset, val.Length);

    public static void WriteInt(this byte[] buff, int val, int offset) => Array.ConstrainedCopy((Array) BitConverter.GetBytes(val), 0, (Array) buff, offset, 4);

    public static void WriteFloat(this byte[] buff, float val, int offset) => Array.ConstrainedCopy((Array) BitConverter.GetBytes(val), 0, (Array) buff, offset, 4);

    public static byte[] ToBytes(this string str, Encoding encoding)
    {
      byte[] bytes = encoding.GetBytes(str);
      byte[] buff = new byte[bytes.Length + 1];
      buff.WriteBytes(bytes, 0);
      return buff;
    }

    public static byte[] ToBytes(this int num) => BitConverter.GetBytes(num);
  }
}
