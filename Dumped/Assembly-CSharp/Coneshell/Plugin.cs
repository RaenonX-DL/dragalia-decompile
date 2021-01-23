/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Coneshell
{
	internal static class Plugin
	{
		// Fields
		private static bool initialized;
		private const string library_name = "il2cpp";
		internal static Delegate_EntryPoint _a;
		internal static Delegate_InitializeContext _b;
		internal static Delegate_ResetContext _c;
		internal static Delegate_PackOutSizeBound _d;
		internal static Delegate_Pack _e;
		internal static Delegate_UnpackOutSizeBound _f;
		internal static Delegate_Unpack _g;
		internal static Delegate_Decompress _h;
		internal static Delegate_CreateCustomVfs _i;
		internal static Delegate_DestroyCustomVfs _j;
	
		// Nested types
		[UnmanagedFunctionPointer]
		internal delegate IntPtr Delegate_EntryPoint();
	
		[UnmanagedFunctionPointer]
		internal delegate int Delegate_InitializeContext(byte[] secret, byte[] entropy);
	
		[UnmanagedFunctionPointer]
		internal delegate void Delegate_ResetContext();
	
		[UnmanagedFunctionPointer]
		internal delegate int Delegate_PackOutSizeBound(int inSize, int enableCompress);
	
		[UnmanagedFunctionPointer]
		internal delegate int Delegate_Pack(IntPtr pOut, byte[] inBytes, int inSize, byte[] nonce, int enableCompress);
	
		[UnmanagedFunctionPointer]
		internal delegate int Delegate_UnpackOutSizeBound(int inSize);
	
		[UnmanagedFunctionPointer]
		internal delegate int Delegate_Unpack(IntPtr pOut, byte[] inBytes, int inSize);
	
		[UnmanagedFunctionPointer]
		internal delegate int Delegate_Decompress(IntPtr pOut, int outSize, IntPtr inBytes, int inSize);
	
		[UnmanagedFunctionPointer]
		internal delegate IntPtr Delegate_CreateCustomVfs(byte[] bin, long size, byte[] name);
	
		[UnmanagedFunctionPointer]
		internal delegate void Delegate_DestroyCustomVfs(IntPtr pVfs);
	
		// Constructors
		static Plugin();
	
		// Methods
		internal static extern IntPtr _fx00();
		internal static void LoadLibrary();
		private static T GetProc<T>(IntPtr addr)
			where T : class;
		[Conditional]
		internal static void UnloadLibrary();
	}
}
