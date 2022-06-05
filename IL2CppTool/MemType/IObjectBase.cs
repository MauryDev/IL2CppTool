// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.IObjectBase
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public interface IObjectBase
  {
    IL2CppApp App { get; set; }

    IntPtr Address { get; set; }

    ICPointer ToPointer();
  }
}
