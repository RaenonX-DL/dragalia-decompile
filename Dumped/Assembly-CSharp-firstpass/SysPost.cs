/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class SysPost
{
	// Nested types
	public delegate void StdMulticastDelegation(object sender, EventArgs e);

	// Constructors
	public SysPost();

	// Methods
	public static bool AssertException(bool expr, string msg);
	public static void InvokeMulticast(object sender, MulticastDelegate md);
	public static void InvokeMulticast(object sender, MulticastDelegate md, EventArgs e);
}

