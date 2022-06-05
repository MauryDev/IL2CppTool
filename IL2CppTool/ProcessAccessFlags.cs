// Decompiled with JetBrains decompiler
// Type: IL2CppTool.ProcessAccessFlags
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool
{
  [Flags]
  public enum ProcessAccessFlags : uint
  {
    All = 2035711, // 0x001F0FFF
    Terminate = 1,
    CreateThread = 2,
    VMOperation = 8,
    VMRead = 16, // 0x00000010
    VMWrite = 32, // 0x00000020
    DupHandle = 64, // 0x00000040
    SetInformation = 512, // 0x00000200
    QueryInformation = 1024, // 0x00000400
    Synchronize = 1048576, // 0x00100000
  }
}
