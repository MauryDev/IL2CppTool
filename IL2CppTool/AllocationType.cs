// Decompiled with JetBrains decompiler
// Type: IL2CppTool.AllocationType
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool
{
  [Flags]
  public enum AllocationType
  {
    MEM_COMMIT = 4096, // 0x00001000
    MEM_RESERVE = 8192, // 0x00002000
    MEM_RESET = 524288, // 0x00080000
    MEM_RESET_UNDO = 16777216, // 0x01000000
    MEM_LARGE_PAGES = 536870912, // 0x20000000
    MEM_PHYSICAL = 4194304, // 0x00400000
    MEM_TOP_DOWN = 1048576, // 0x00100000
  }
}
