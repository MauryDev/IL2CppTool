// Decompiled with JetBrains decompiler
// Type: IL2CppTool.ProcessUtil
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;
using System.Collections.Generic;
using System.Text;

namespace IL2CppTool
{
  public static class ProcessUtil
  {
    public static bool Is64BitProcess(IntPtr handle)
    {
      if (!Environment.Is64BitOperatingSystem)
        return false;
      bool wow64Process;
      return !NativeMethods.IsWow64Process(handle, out wow64Process) ? IntPtr.Size == 8 : !wow64Process;
    }

    public static IEnumerable<ExportedFunction> GetExportedFunctions(
      IntPtr handle,
      IntPtr mod)
    {
      using (Memory memory = new Memory(handle))
      {
        IntPtr num = mod + memory.ReadInt(mod + memory.ReadInt(mod + 60) + 24 + (ProcessUtil.Is64BitProcess(handle) ? 112 : 96));
        IntPtr names = mod + memory.ReadInt(num + 32);
        IntPtr ordinals = mod + memory.ReadInt(num + 36);
        IntPtr functions = mod + memory.ReadInt(num + 28);
        int count = memory.ReadInt(num + 24);
        for (int i = 0; i < count; ++i)
        {
          string name = memory.ReadString(mod + memory.ReadInt(names + i * 4), 80, Encoding.ASCII);
          IntPtr address = mod + memory.ReadInt(functions + (int) memory.ReadShort(ordinals + i * 2) * 4);
          if (address != IntPtr.Zero)
            yield return new ExportedFunction(name, address);
        }
      }
    }
  }
}
