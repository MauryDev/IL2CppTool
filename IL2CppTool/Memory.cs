// Decompiled with JetBrains decompiler
// Type: IL2CppTool.Memory
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;
using System.Text;

namespace IL2CppTool
{
  public class Memory : IDisposable
  {
    private readonly IntPtr _handle;

    public Memory(IntPtr processHandle) => this._handle = processHandle;

    public string ReadString(IntPtr address, int length, Encoding encoding)
    {
      byte[] bytes = this.ReadBytes(address, length);
      int count = length;
      for (int index = 0; index < bytes.Length; ++index)
      {
        if (bytes[index] == (byte) 0)
        {
          count = index;
          break;
        }
      }
      return encoding.GetString(bytes, 0, count);
    }

    public string ReadUnicodeString(IntPtr address, int length) => Encoding.Unicode.GetString(this.ReadBytes(address, length));

    public short ReadShort(IntPtr address) => BitConverter.ToInt16(this.ReadBytes(address, 2), 0);

    public int ReadInt(IntPtr address) => BitConverter.ToInt32(this.ReadBytes(address, 4), 0);

    public long ReadLong(IntPtr address) => BitConverter.ToInt64(this.ReadBytes(address, 8), 0);

    public byte[] ReadBytes(IntPtr address, int size)
    {
      byte[] lpBuffer = new byte[size];
      NativeMethods.ReadProcessMemory(this._handle, address, lpBuffer, size);
      return lpBuffer;
    }

    public void Dispose()
    {
    }
  }
}
