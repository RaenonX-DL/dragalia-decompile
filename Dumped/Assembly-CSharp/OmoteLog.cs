/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

internal class OmoteLog
{
	// Fields
	private static bool mEnabled;

	// Constructors
	protected OmoteLog();
	static OmoteLog();

	// Methods
	public static void SetEnable(bool enabled);
	public static void Info(string format, params object[] args);
	public static void Warn(string format, params object[] args);
	public static void WarnUnless(bool assertion, string format, params object[] args);
	public static void Error(string format, params object[] args);
	public static void ErrorUnless(bool assertion, string format, params object[] args);
}

