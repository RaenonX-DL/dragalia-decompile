/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriWareDecrypter
{
	// Fields
	private static ulong temporalStorage;

	// Nested types
	[UnmanagedFunctionPointer]
	public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);

	// Constructors
	static CriWareDecrypter();

	// Methods
	public static bool Initialize(CriWareDecrypterConfig config);
	public static bool Initialize(string key, string authenticationFile, bool enableAtomDecryption, bool enableManaDecryption);
	[MonoPInvokeCallback]
	private static ulong CallbackFromNative(IntPtr ptr1);
	public static extern int CRIWARE3A537A62(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj);
}

