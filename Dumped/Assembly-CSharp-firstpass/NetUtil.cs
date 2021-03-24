/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class NetUtil
{
	// Fields
	[CompilerGenerated]
	private static NetLogHandler _LogHandler_k__BackingField;
	[CompilerGenerated]
	private static NetLogHandler _LogErrorHandler_k__BackingField;

	// Properties
	public static NetLogHandler LogHandler { [CompilerGenerated] get; [CompilerGenerated] set; }
	public static NetLogHandler LogErrorHandler { [CompilerGenerated] get; [CompilerGenerated] set; }

	// Methods
	public static void Log(string fmt, params object[] args);
	public static void LogError(string fmt, params object[] args);
}

