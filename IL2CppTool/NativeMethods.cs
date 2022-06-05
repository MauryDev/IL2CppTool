// Decompiled with JetBrains decompiler
// Type: IL2CppTool.NativeMethods
// Assembly: IL2CppTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9572D2E5-F210-461C-9FD3-A6B7BFA6DD25
// Assembly location: C:\Users\Glatrix\Desktop\BLOOP\IL2CppTool.dll

using IL2CppTool.Extensions;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace IL2CppTool
{
  public static class NativeMethods
  {
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool CloseHandle(IntPtr handle);

    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

    [DllImport("psapi.dll", SetLastError = true)]
    public static extern bool EnumProcessModulesEx(
      IntPtr hProcess,
      [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4), In, Out] IntPtr[] lphModule,
      int cb,
      [MarshalAs(UnmanagedType.U4)] out int lpcbNeeded,
      ModuleFilter dwFilterFlag);

    [DllImport("psapi.dll")]
    public static extern uint GetModuleFileNameEx(
      IntPtr hProcess,
      IntPtr hModule,
      [Out] StringBuilder lpBaseName,
      [MarshalAs(UnmanagedType.U4), In] uint nSize);

    [DllImport("psapi.dll", SetLastError = true)]
    public static extern bool GetModuleInformation(
      IntPtr hProcess,
      IntPtr hModule,
      out MODULEINFO lpmodinfo,
      uint cb);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool WriteProcessMemory(
      IntPtr hProcess,
      IntPtr lpBaseAddress,
      byte[] lpBuffer,
      int nSize,
      int lpNumberOfBytesWritten = 0);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ReadProcessMemory(
      IntPtr hProcess,
      IntPtr lpBaseAddress,
      byte[] lpBuffer,
      int nSize,
      int lpNumberOfBytesRead = 0);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr VirtualAllocEx(
      IntPtr hProcess,
      IntPtr lpAddress,
      int dwSize,
      AllocationType flAllocationType,
      MemoryProtection flProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool VirtualFreeEx(
      IntPtr hProcess,
      IntPtr lpAddress,
      int dwSize,
      MemoryFreeType dwFreeType);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr CreateRemoteThread(
      IntPtr hProcess,
      IntPtr lpThreadAttributes,
      int dwStackSize,
      IntPtr lpStartAddress,
      IntPtr lpParameter,
      ThreadCreationFlags dwCreationFlags,
      out int lpThreadId);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern WaitResult WaitForSingleObject(
      IntPtr hHandle,
      int dwMilliseconds);

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(
      ProcessAccessFlags dwDesiredAccess,
      [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
      int dwProcessId);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool WriteProcessMemory(
      IntPtr hProcess,
      IntPtr lpBaseAddress,
      byte[] lpBuffer,
      uint nSize,
      out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool GetExitCodeThread(IntPtr hThread, out IntPtr lpExitCode);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    public static void WriteMem(IntPtr handler, IntPtr address, byte[] data)
    {
      int lpNumberOfBytesWritten = 0;
      NativeMethods.WriteProcessMemory(handler, address, data, (uint) (ulong) data.Length, out lpNumberOfBytesWritten);
    }

    public static ProcessModule GetModuleByname(
      ProcessModuleCollection module,
      string name)
    {
      if (module == null)
        return (ProcessModule) null;
      ProcessModule moduleByname = (ProcessModule) null;
      foreach (ProcessModule processModule in (ReadOnlyCollectionBase) module)
      {
        if (processModule.ModuleName == name)
        {
          moduleByname = processModule;
          break;
        }
      }
      return moduleByname;
    }

    public static IntPtr Execute(IntPtr address, IntPtr parameters, IntPtr handler)
    {
      IntPtr remoteThread = NativeMethods.CreateRemoteThread(handler, IntPtr.Zero, 0, address, parameters, ThreadCreationFlags.None, out int _);
      if (remoteThread == IntPtr.Zero)
        throw new Exception("Failed to create a remote thread", (Exception) new Win32Exception(Marshal.GetLastWin32Error()));
      if (NativeMethods.WaitForSingleObject(remoteThread, -1) == WaitResult.WAIT_FAILED)
        throw new Exception("Failed to wait for a remote thread", (Exception) new Win32Exception(Marshal.GetLastWin32Error()));
      IntPtr lpExitCode;
      NativeMethods.GetExitCodeThread(remoteThread, out lpExitCode);
      NativeMethods.CloseHandle(remoteThread);
      return lpExitCode;
    }

    public static void HookFunction(
      IntPtr handler,
      IntPtr fromaddressfun,
      IntPtr toAddressFun,
      int nops)
    {
      byte[] numArray = new byte[5 + nops];
      numArray.WriteBytes(new byte[1]{ (byte) 233 }, 0);
      numArray.WriteInt(toAddressFun.ToInt32() - (fromaddressfun.ToInt32() + 5), 1);
      for (int index = 5; index < numArray.Length; ++index)
        numArray[index] = (byte) 144;
      NativeMethods.WriteMem(handler, fromaddressfun, numArray);
    }
  }
}
