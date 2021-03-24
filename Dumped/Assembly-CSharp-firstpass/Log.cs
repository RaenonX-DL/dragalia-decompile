/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class Log
{
	// Fields
	public static LogLevel LogLevel;

	// Constructors
	static Log();

	// Methods
	public static void Info(object msg, params object[] args);
	public static void InfoEx(object msg, UnityEngine.Object context);
	public static void Warning(object msg, params object[] args);
	public static void Error(object msg, params object[] args);
	public static void Exception(Exception ex);
	public static void Assert(bool condition);
	public static void Assert(bool condition, string assertString);
	public static void Assert(bool condition, string assertString, bool pauseOnFail);
	private static object _format(object msg, params object[] args);
}

