// Decompiled with JetBrains decompiler
// Type: IL2CppTool.ThreadCreationFlags
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool
{
  [Flags]
  public enum ThreadCreationFlags
  {
    None = 0,
    CREATE_SUSPENDED = 4,
    STACK_SIZE_PARAM_IS_A_RESERVATION = 65536, // 0x00010000
  }
}
