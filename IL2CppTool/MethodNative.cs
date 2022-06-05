// Decompiled with JetBrains decompiler
// Type: IL2CppTool.MethodNative
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using IL2CppTool.Extensions;
using IL2CppTool.MemType;
using System;

namespace IL2CppTool
{
  public class MethodNative
  {
    public IL2CppApp app;

    public IntPtr Address { get; internal set; }

    public MethodNative(IL2CppApp app)
    {
      this.app = app;
      this.Address = app.CurrentAddressFun;
      this.CreateCall();
    }

    private IntPtr CreateCall() => this.app.WriteFun(LibMethods.GetBuffFromName(nameof (CreateCall)));

    public IntPtr EndCall() => this.app.WriteFun(LibMethods.GetBuffFromName(nameof (EndCall)));

    public CPointer<CVoid> il2cpp_domain_get()
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_domain_get));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_domain_get)].ToInt32(), 1);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 8);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_thread_attach(CPointer<CVoid> domain)
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_thread_attach));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_thread_attach)].ToInt32(), 1);
      buffFromName.WriteInt(domain.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_domain_assembly_open(
      CPointer<CVoid> domain,
      CPointer<CString> name)
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_domain_assembly_open));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_domain_assembly_open)].ToInt32(), 1);
      buffFromName.WriteInt(name.Address.ToInt32(), 7);
      buffFromName.WriteInt(domain.Address.ToInt32(), 13);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 23);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_class_from_name(
      CPointer<CVoid> image,
      CPointer<CString> namespaze,
      CPointer<CString> name)
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_from_name));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_from_name)].ToInt32(), 1);
      buffFromName.WriteInt(name.m_PTR.ToInt32(), 7);
      buffFromName.WriteInt(namespaze.m_PTR.ToInt32(), 13);
      buffFromName.WriteInt(image.Address.ToInt32(), 19);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 29);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<Il2CppObject> il2cpp_runtime_invoke(
      CPointer<CVoid> method,
      CPointer<Il2CppObject> obj,
      CPointer<CPointer<CVoid>> _params,
      CPointer<CVoid> exc)
    {
      CPointer<Il2CppObject> cpointer = this.app.ReservePointer<Il2CppObject>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_runtime_invoke));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_runtime_invoke)].ToInt32(), 1);
      buffFromName.WriteInt(exc.Address.ToInt32(), 7);
      buffFromName.WriteInt(_params.Address.ToInt32(), 13);
      buffFromName.WriteInt(obj.Address.ToInt32(), 19);
      buffFromName.WriteInt(method.Address.ToInt32(), 25);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 35);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_assembly_get_image(CPointer<CVoid> assembly)
    {
      CPointer<CVoid> image = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_assembly_get_image));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_assembly_get_image)].ToInt32(), 1);
      buffFromName.WriteInt(assembly.Address.ToInt32(), 7);
      buffFromName.WriteInt(image.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return image;
    }

    public CPointer<CVoid> il2cpp_class_get_method_from_name(
      CPointer<CVoid> klass,
      CPointer<CString> name,
      C4Bytes argsCount)
    {
      CPointer<CVoid> methodFromName = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_get_method_from_name));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_get_method_from_name)].ToInt32(), 1);
      buffFromName.WriteInt(argsCount.Address.ToInt32(), 7);
      buffFromName.WriteInt(name.m_PTR.ToInt32(), 13);
      buffFromName.WriteInt(klass.Address.ToInt32(), 19);
      buffFromName.WriteInt(methodFromName.Address.ToInt32(), 29);
      this.app.WriteFun(buffFromName);
      return methodFromName;
    }

    public void IsNull(ICPointer value, C4Bytes address)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (IsNull));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(address.Address.ToInt32(), 10);
      this.app.WriteFun(buffFromName);
    }

    public CPointer<CVoid> il2cpp_get_corlib()
    {
      CPointer<CVoid> corlib = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_get_corlib));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_get_corlib)].ToInt32(), 1);
      buffFromName.WriteInt(corlib.Address.ToInt32(), 8);
      this.app.WriteFun(buffFromName);
      return corlib;
    }

    public CPointer<CVoid> il2cpp_alloc(C4Bytes size)
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_alloc));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_alloc)].ToInt32(), 1);
      buffFromName.WriteInt(size.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public void il2cpp_free(CPointer<CVoid> pointer)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_free));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_free)].ToInt32(), 1);
      buffFromName.WriteInt(pointer.Address.ToInt32(), 7);
      this.app.WriteFun(buffFromName);
    }

    public CPointer<CVoid> il2cpp_class_get_field_from_name(
      CPointer<CVoid> klass,
      CPointer<CString> name)
    {
      CPointer<CVoid> fieldFromName = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_get_field_from_name));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_get_field_from_name)].ToInt32(), 1);
      buffFromName.WriteInt(name.m_PTR.ToInt32(), 7);
      buffFromName.WriteInt(klass.Address.ToInt32(), 13);
      buffFromName.WriteInt(fieldFromName.Address.ToInt32(), 23);
      this.app.WriteFun(buffFromName);
      return fieldFromName;
    }

    public CPointer<CString> il2cpp_class_get_name(CPointer<CVoid> klass)
    {
      CPointer<CString> name = this.app.ReservePointer<CString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_get_name));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_get_name)].ToInt32(), 1);
      buffFromName.WriteInt(klass.Address.ToInt32(), 7);
      buffFromName.WriteInt(name.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return name;
    }

    public CPointer<CString> il2cpp_class_get_namespace(CPointer<CVoid> klass)
    {
      CPointer<CString> cpointer = this.app.ReservePointer<CString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_get_namespace));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_get_namespace)].ToInt32(), 1);
      buffFromName.WriteInt(klass.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_class_get_parent(CPointer<CVoid> klass)
    {
      CPointer<CVoid> parent = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_get_parent));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_get_parent)].ToInt32(), 1);
      buffFromName.WriteInt(klass.Address.ToInt32(), 7);
      buffFromName.WriteInt(parent.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return parent;
    }

    public CPointer<CString> il2cpp_class_get_assemblyname(CPointer<CVoid> klass)
    {
      CPointer<CString> assemblyname = this.app.ReservePointer<CString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_get_assemblyname));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_get_assemblyname)].ToInt32(), 1);
      buffFromName.WriteInt(klass.Address.ToInt32(), 7);
      buffFromName.WriteInt(assemblyname.m_PTR.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return assemblyname;
    }

    public CPointer<CString> il2cpp_field_get_name(CPointer<CVoid> field)
    {
      CPointer<CString> name = this.app.ReservePointer<CString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_field_get_name));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_field_get_name)].ToInt32(), 1);
      buffFromName.WriteInt(field.Address.ToInt32(), 7);
      buffFromName.WriteInt(name.m_PTR.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return name;
    }

    public C4Bytes il2cpp_field_get_offset(CPointer<CVoid> field)
    {
      C4Bytes offset = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_field_get_offset));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_field_get_offset)].ToInt32(), 1);
      buffFromName.WriteInt(field.Address.ToInt32(), 7);
      buffFromName.WriteInt(offset.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return offset;
    }

    public void il2cpp_field_get_value(
      CPointer<Il2CppObject> obj,
      CPointer<CVoid> field,
      CPointer<CVoid> value)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_field_get_value));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_field_get_value)].ToInt32(), 1);
      buffFromName.WriteInt(value.Address.ToInt32(), 7);
      buffFromName.WriteInt(field.Address.ToInt32(), 13);
      buffFromName.WriteInt(obj.Address.ToInt32(), 19);
      this.app.WriteFun(buffFromName);
    }

    public void il2cpp_field_set_value(
      CPointer<Il2CppObject> obj,
      CPointer<CVoid> field,
      CPointer<CVoid> value)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_field_set_value));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_field_set_value)].ToInt32(), 1);
      buffFromName.WriteInt(value.Address.ToInt32(), 7);
      buffFromName.WriteInt(field.Address.ToInt32(), 13);
      buffFromName.WriteInt(obj.Address.ToInt32(), 19);
      this.app.WriteFun(buffFromName);
    }

    public void il2cpp_field_static_get_value(CPointer<CVoid> field, CPointer<CVoid> value)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_field_static_get_value));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_field_static_get_value)].ToInt32(), 1);
      buffFromName.WriteInt(value.Address.ToInt32(), 7);
      buffFromName.WriteInt(field.Address.ToInt32(), 13);
      this.app.WriteFun(buffFromName);
    }

    public void il2cpp_field_static_set_value(CPointer<CVoid> field, CPointer<CVoid> value)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_field_static_set_value));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_field_static_set_value)].ToInt32(), 1);
      buffFromName.WriteInt(value.Address.ToInt32(), 7);
      buffFromName.WriteInt(field.Address.ToInt32(), 13);
      this.app.WriteFun(buffFromName);
    }

    public CPointer<CString> il2cpp_method_get_name(CPointer<CVoid> method)
    {
      CPointer<CString> name = this.app.ReservePointer<CString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_method_get_name));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_method_get_name)].ToInt32(), 1);
      buffFromName.WriteInt(method.Address.ToInt32(), 7);
      buffFromName.WriteInt(name.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return name;
    }

    public C4Bytes il2cpp_method_get_param_count(CPointer<CVoid> method)
    {
      C4Bytes paramCount = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_method_get_param_count));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_method_get_param_count)].ToInt32(), 1);
      buffFromName.WriteInt(method.Address.ToInt32(), 7);
      buffFromName.WriteInt(paramCount.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return paramCount;
    }

    public CPointer<CString> il2cpp_method_get_param_name(
      CPointer<CVoid> method,
      C4Bytes index)
    {
      CPointer<CString> paramName = this.app.ReservePointer<CString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_method_get_param_name));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_method_get_param_name)].ToInt32(), 1);
      buffFromName.WriteInt(method.Address.ToInt32(), 7);
      buffFromName.WriteInt(index.Address.ToInt32(), 13);
      buffFromName.WriteInt(paramName.Address.ToInt32(), 23);
      this.app.WriteFun(buffFromName);
      return paramName;
    }

    public CPointer<CVoid> il2cpp_object_get_class(CPointer<Il2CppObject> obj)
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_object_get_class));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_object_get_class)].ToInt32(), 1);
      buffFromName.WriteInt(obj.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<Il2CppObject> il2cpp_object_new(CPointer<CVoid> klass)
    {
      CPointer<Il2CppObject> cpointer = this.app.ReservePointer<Il2CppObject>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_object_new));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_object_new)].ToInt32(), 1);
      buffFromName.WriteInt(klass.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_object_unbox(CPointer<Il2CppObject> obj)
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_object_unbox));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_object_unbox)].ToInt32(), 1);
      buffFromName.WriteInt(obj.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<Il2CppObject> il2cpp_value_box(
      CPointer<CVoid> klass,
      CPointer<CVoid> data)
    {
      CPointer<Il2CppObject> cpointer = this.app.ReservePointer<Il2CppObject>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_value_box));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_value_box)].ToInt32(), 1);
      buffFromName.WriteInt(data.Address.ToInt32(), 7);
      buffFromName.WriteInt(klass.Address.ToInt32(), 13);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 23);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public C4Bytes il2cpp_string_length(CPointer<IL2CppString> str)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_string_length));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_string_length)].ToInt32(), 1);
      buffFromName.WriteInt(str.Address.ToInt32(), 7);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public CPointer<IL2CppString> il2cpp_string_new(CPointer<CString> str)
    {
      CPointer<IL2CppString> cpointer = this.app.ReservePointer<IL2CppString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_string_new));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_string_new)].ToInt32(), 1);
      buffFromName.WriteInt(str.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<IL2CppString> il2cpp_string_new_utf16(
      CPointer<CWString> str,
      C4Bytes length)
    {
      CPointer<IL2CppString> cpointer = this.app.ReservePointer<IL2CppString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_string_new_utf16));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_string_new_utf16)].ToInt32(), 1);
      buffFromName.WriteInt(length.Address.ToInt32(), 7);
      buffFromName.WriteInt(str.Address.ToInt32(), 13);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 23);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_thread_current()
    {
      CPointer<CVoid> cpointer = this.app.ReservePointer<CVoid>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_thread_current));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_thread_current)].ToInt32(), 1);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 8);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public C4Bytes il2cpp_array_length(CPointer<IL2CppArray> array)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName("il2cpp_string_new");
      buffFromName.WriteInt(this.app.methodIl2cpp["il2cpp_string_new"].ToInt32(), 1);
      buffFromName.WriteInt(array.Address.ToInt32(), 7);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public C4Bytes il2cpp_array_get_byte_length(CPointer<IL2CppArray> array)
    {
      C4Bytes byteLength = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_array_get_byte_length));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_array_get_byte_length)].ToInt32(), 1);
      buffFromName.WriteInt(array.Address.ToInt32(), 7);
      buffFromName.WriteInt(byteLength.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return byteLength;
    }

    public CPointer<IL2CppArray> il2cpp_array_new(
      CPointer<CVoid> elementTypeInfo,
      C4Bytes length)
    {
      CPointer<IL2CppArray> cpointer = this.app.ReservePointer<IL2CppArray>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_array_new));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_array_new)].ToInt32(), 1);
      buffFromName.WriteInt(length.Address.ToInt32(), 7);
      buffFromName.WriteInt(elementTypeInfo.Address.ToInt32(), 13);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 23);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public C4Bytes il2cpp_object_get_size(CPointer<Il2CppObject> obj)
    {
      C4Bytes size = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_object_get_size));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_object_get_size)].ToInt32(), 1);
      buffFromName.WriteInt(obj.Address.ToInt32(), 7);
      buffFromName.WriteInt(size.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return size;
    }

    public CPointer<CWString> il2cpp_string_chars(CPointer<IL2CppString> str)
    {
      CPointer<CWString> cpointer = this.app.ReservePointer<CWString>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_string_chars));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_string_chars)].ToInt32(), 1);
      buffFromName.WriteInt(str.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public C4Bytes il2cpp_method_methodPointer(CPointer<CVoid> method)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_method_methodPointer));
      buffFromName.WriteInt(method.Address.ToInt32(), 1);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 8);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public void IF(CByte value, C4Bytes address)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (IF));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(address.Address.ToInt32(), 11);
      this.app.WriteFun(buffFromName);
    }

    public CByte Negate(CByte value)
    {
      CByte cbyte = this.app.ReserveObject<CByte>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (Negate));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(cbyte.Address.ToInt32(), 8);
      this.app.WriteFun(buffFromName);
      return cbyte;
    }

    public C4Bytes And(C4Bytes value, C4Bytes value2)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (And));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(value2.Address.ToInt32(), 7);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 12);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public C4Bytes OR(C4Bytes value, C4Bytes value2)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (OR));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(value2.Address.ToInt32(), 7);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 12);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public C4Bytes XOR(C4Bytes value, C4Bytes value2)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (XOR));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(value2.Address.ToInt32(), 7);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 12);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public CByte And_Conditional(CByte value, CByte value2)
    {
      CByte cbyte = this.app.ReserveObject<CByte>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (And_Conditional));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(value2.Address.ToInt32(), 7);
      buffFromName.WriteInt(cbyte.Address.ToInt32(), 25);
      this.app.WriteFun(buffFromName);
      return cbyte;
    }

    public CByte OR_Conditional(CByte value, CByte value2)
    {
      CByte cbyte = this.app.ReserveObject<CByte>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (OR_Conditional));
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      buffFromName.WriteInt(value2.Address.ToInt32(), 7);
      buffFromName.WriteInt(cbyte.Address.ToInt32(), 29);
      this.app.WriteFun(buffFromName);
      return cbyte;
    }

    public void Mov(C4Bytes obj, C4Bytes value)
    {
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (Mov));
      buffFromName.WriteInt(obj.Address.ToInt32(), 6);
      buffFromName.WriteInt(value.Address.ToInt32(), 1);
      this.app.WriteFun(buffFromName);
    }

    public CByte IsEqual(C4Bytes value1, C4Bytes value2)
    {
      CByte cbyte = this.app.ReserveObject<CByte>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (IsEqual));
      buffFromName.WriteInt(value1.Address.ToInt32(), 1);
      buffFromName.WriteInt(value2.Address.ToInt32(), 7);
      buffFromName.WriteInt(cbyte.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cbyte;
    }

    public CPointer<CVoid> il2cpp_class_from_il2cpp_type(CPointer<CVoid> type)
    {
      CPointer<CVoid> cpointer = this.app.ReserveObject<CPointer<CVoid>>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_from_il2cpp_type));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_from_il2cpp_type)].ToInt32(), 1);
      buffFromName.WriteInt(type.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<Il2CppObject> il2cpp_type_get_object(CPointer<CVoid> type)
    {
      CPointer<Il2CppObject> cpointer = this.app.ReserveObject<CPointer<Il2CppObject>>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_type_get_object));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_type_get_object)].ToInt32(), 1);
      buffFromName.WriteInt(type.Address.ToInt32(), 7);
      buffFromName.WriteInt(cpointer.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return cpointer;
    }

    public CPointer<CVoid> il2cpp_class_get_type(CPointer<CVoid> klass)
    {
      CPointer<CVoid> type = this.app.ReserveObject<CPointer<CVoid>>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_class_get_type));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_class_get_type)].ToInt32(), 1);
      buffFromName.WriteInt(klass.Address.ToInt32(), 7);
      buffFromName.WriteInt(type.Address.ToInt32(), 17);
      this.app.WriteFun(buffFromName);
      return type;
    }

    public CByte il2cpp_type_equals(CPointer<CVoid> type, CPointer<CVoid> type2)
    {
      CByte cbyte = this.app.ReserveObject<CByte>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (il2cpp_type_equals));
      buffFromName.WriteInt(this.app.methodIl2cpp[nameof (il2cpp_type_equals)].ToInt32(), 1);
      buffFromName.WriteInt(type.Address.ToInt32(), 7);
      buffFromName.WriteInt(type2.Address.ToInt32(), 13);
      buffFromName.WriteInt(cbyte.Address.ToInt32(), 23);
      this.app.WriteFun(buffFromName);
      return cbyte;
    }

    public C4Bytes Add(C4Bytes val1, C4Bytes val2)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (Add));
      buffFromName.WriteInt(val1.Address.ToInt32(), 1);
      buffFromName.WriteInt(val2.Address.ToInt32(), 7);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 12);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public C4Bytes Sub(C4Bytes val1, C4Bytes val2)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (Sub));
      buffFromName.WriteInt(val1.Address.ToInt32(), 1);
      buffFromName.WriteInt(val2.Address.ToInt32(), 7);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 12);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public C4Bytes Mul(C4Bytes val1, C4Bytes val2)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (Mul));
      buffFromName.WriteInt(val1.Address.ToInt32(), 1);
      buffFromName.WriteInt(val2.Address.ToInt32(), 8);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 13);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public C4Bytes Div(C4Bytes val1, C4Bytes val2)
    {
      C4Bytes c4Bytes = this.app.ReserveObject<C4Bytes>();
      byte[] buffFromName = LibMethods.GetBuffFromName(nameof (Div));
      buffFromName.WriteInt(val1.Address.ToInt32(), 2);
      buffFromName.WriteInt(val2.Address.ToInt32(), 12);
      buffFromName.WriteInt(c4Bytes.Address.ToInt32(), 16);
      this.app.WriteFun(buffFromName);
      return c4Bytes;
    }

    public void Invoke() => this.app.Call(this.Address);

    public Action ToDel() => new Action(this.Invoke);
  }
}
