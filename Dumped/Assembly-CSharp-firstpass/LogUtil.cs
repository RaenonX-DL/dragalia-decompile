/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class LogUtil
{
	// Fields
	public static bool EnableInMemoryStorage;
	public static int InMemoryItemMaxCount;
	public static List<string> InMemoryExceptions;
	public static List<string> InMemoryErrors;

	// Constructors
	public LogUtil();
	static LogUtil();

	// Methods
	public static string CombinePaths(params string[] paths);
	public static string FormatDateAsFileNameString(DateTime dt);
	public static string FormatTimeAsFileNameString(DateTime dt);
	public static void PushInMemoryException(string exception);
	public static void PushInMemoryError(string error);
}

