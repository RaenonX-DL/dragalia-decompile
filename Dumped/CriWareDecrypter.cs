using System;
using System.Runtime.InteropServices;

public static class CriWareDecrypter
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);

	private static ulong temporalStorage;

	public static bool Initialize(CriWareDecrypterConfig config)
	{
		return default(bool);
	}

	public static bool Initialize(string key, string authenticationFile, bool enableAtomDecryption, bool enableManaDecryption)
	{
		return default(bool);
	}

	private static ulong CallbackFromNative(IntPtr ptr1)
	{
		return default(ulong);
	}

	public static extern int CRIWARE3A537A62(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj);
}
