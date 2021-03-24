/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomExAcbDebug
{
	// Nested types
	public struct AcbInfo
	{
		// Fields
		public string name;
		public uint size;
		public uint version;
		public CriAtomEx.CharacterEncoding characterEncoding;
		public float volume;
		public int numCues;
	}

	private struct AcbInfoForMarshaling
	{
		// Fields
		public IntPtr namePtr;
		public uint size;
		public uint version;
		public CriAtomEx.CharacterEncoding characterEncoding;
		public float volume;
		public int numCues;

		// Methods
		public void Convert(out AcbInfo x);
	}

	// Methods
	public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo);
	private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo);
}

