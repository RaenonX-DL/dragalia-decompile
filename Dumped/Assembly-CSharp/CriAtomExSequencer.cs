/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomExSequencer
{
	// Nested types
	[UnmanagedFunctionPointer]
	public delegate void EventCbFunc(string eventParamsString);

	// Methods
	public static void SetEventCallback(EventCbFunc func, string separator = "\t");
}

