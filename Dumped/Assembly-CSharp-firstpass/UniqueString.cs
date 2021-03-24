/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UniqueString
{
	// Fields
	private static Dictionary<string, string> m_strings;

	// Constructors
	public UniqueString();
	static UniqueString();

	// Methods
	public static string Intern(string str, bool removable = true);
	public static string IsInterned(string str);
	public static void Clear();
}

