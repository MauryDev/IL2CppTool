// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemoryFreeType
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool
{
  [Flags]
  public enum MemoryFreeType
  {
    MEM_DECOMMIT = 16384, // 0x00004000
    MEM_RELEASE = 32768, // 0x00008000
  }
}
