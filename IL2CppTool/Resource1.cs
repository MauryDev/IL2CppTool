// Decompiled with JetBrains decompiler
// Type: IL2CppTool.Resource1
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace IL2CppTool
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resource1
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resource1()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Resource1.resourceMan == null)
          Resource1.resourceMan = new ResourceManager("IL2CppTool.Resource1", typeof (Resource1).Assembly);
        return Resource1.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Resource1.resourceCulture;
      set => Resource1.resourceCulture = value;
    }

    internal static byte[] sourcetest => (byte[]) Resource1.ResourceManager.GetObject(nameof (sourcetest), Resource1.resourceCulture);
  }
}
