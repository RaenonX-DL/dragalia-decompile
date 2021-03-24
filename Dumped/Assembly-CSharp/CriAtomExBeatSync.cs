/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomExBeatSync
{
	// Nested types
	public struct Info
	{
		// Fields
		public IntPtr playerHn;
		public uint playbackId;
		public uint barCount;
		public uint beatCount;
		public float beatProgress;
		public float bpm;
	}

	[UnmanagedFunctionPointer]
	public delegate void CbFunc(ref Info info);

	// Methods
	public static void SetCallback(CbFunc func);
}

