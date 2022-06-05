// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MemType.CArray`1
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using System;

namespace IL2CppTool.MemType
{
  public struct CArray<T> : IObjectBase where T : struct, IStruct, IObjectBase
  {
    private IntPtr m_PTR;
    private IL2CppApp app;

    public CArray(IL2CppApp app, IntPtr address)
    {
      this.app = app;
      this.m_PTR = address;
    }

    public T this[int index]
    {
      get
      {
        T obj = new T();
        obj.Address = this.m_PTR + obj.ByteSize * index;
        obj.App = this.app;
        return obj;
      }
    }

    public void CopyTo(T[] arr, int carrayindex, int len)
    {
      for (int index = 0; index < len; ++index)
        arr[index] = this[index + carrayindex];
    }

    public IL2CppApp App
    {
      get => this.app;
      set => this.app = value;
    }

    public IntPtr Address
    {
      get => this.m_PTR;
      set => this.m_PTR = value;
    }

    public CPointer<CArray<T>> ToPointer() => this.app.ToPointer<CArray<T>>(this.m_PTR);

    ICPointer IObjectBase.ToPointer() => (ICPointer) this.ToPointer();

    public static implicit operator CArray<T>(object[] val)
    {
      int num = typeof (IObjectBase).IsAssignableFrom(typeof (T)) ? 1 : 0;
      CArray<T> carray = new CArray<T>();
      IL2CppApp current = IL2CppApp.Current;
      carray.App = current;
      carray.Address = current.CurrentAddressData;
      if (num == 0)
        return carray;
      foreach (object val1 in val)
        ((IStruct) new T()).op_new(current, val1);
      return carray;
    }
  }
}
