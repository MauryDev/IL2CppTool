// Decompiled with JetBrains decompiler
// Type: IL2CppTool.LibMethods
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using IL2CppTool.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace IL2CppTool
{
  public static class LibMethods
  {
    private static Dictionary<string, byte[]> methods = new Dictionary<string, byte[]>(30);

    static LibMethods()
    {
      byte[] sourcetest = Resource1.sourcetest;
      int num;
      for (int offset1 = 0; offset1 < sourcetest.Length; offset1 = num + 1)
      {
        string key = sourcetest.ReadString(offset1);
        int offset2 = offset1 + (key.Length + 1);
        short size = sourcetest.ReadInt16(offset2);
        byte[] numArray = sourcetest.ReadBuff(offset2 + 2, (int) size);
        num = offset2 + (2 + (int) size);
        LibMethods.methods.Add(key, numArray);
      }
    }

    internal static byte[] GetBuffFromName(string name) => ((IEnumerable<byte>) LibMethods.methods[name]).ToArray<byte>();
  }
}
