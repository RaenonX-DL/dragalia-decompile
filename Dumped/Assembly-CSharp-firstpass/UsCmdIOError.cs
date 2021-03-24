/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsCmdIOError : Exception
{
	// Fields
	private static Dictionary<UsCmdIOErrorCode, string> InfoLut;
	public UsCmdIOErrorCode ErrorCode;

	// Constructors
	public UsCmdIOError(UsCmdIOErrorCode code);
	static UsCmdIOError();
}

