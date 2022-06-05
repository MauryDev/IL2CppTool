// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemoryProtection
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool
{
  [Flags]
  public enum MemoryProtection
  {
    PAGE_EXECUTE = 16, // 0x00000010
    PAGE_EXECUTE_READ = 32, // 0x00000020
    PAGE_EXECUTE_READWRITE = 64, // 0x00000040
    PAGE_EXECUTE_WRITECOPY = 128, // 0x00000080
    PAGE_NOACCESS = 1,
    PAGE_READONLY = 2,
    PAGE_READWRITE = 4,
    PAGE_WRITECOPY = 8,
    PAGE_TARGETS_INVALID = 1073741824, // 0x40000000
    PAGE_TARGETS_NO_UPDATE = PAGE_TARGETS_INVALID, // 0x40000000
    PAGE_GUARD = 256, // 0x00000100
    PAGE_NOCACHE = 512, // 0x00000200
    PAGE_WRITECOMBINE = 1024, // 0x00000400
  }
}
