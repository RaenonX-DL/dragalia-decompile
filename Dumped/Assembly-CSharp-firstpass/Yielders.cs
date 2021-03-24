/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class Yielders
{
	// Fields
	public static bool Enabled;
	public static int _internalCounter;
	private static WaitForEndOfFrame _endOfFrame;
	private static WaitForFixedUpdate _fixedUpdate;
	private static Dictionary<float, WaitForSeconds> _waitForSecondsYielders;

	// Properties
	public static WaitForEndOfFrame EndOfFrame { get; }
	public static WaitForFixedUpdate FixedUpdate { get; }

	// Constructors
	static Yielders();

	// Methods
	public static WaitForSeconds GetWaitForSeconds(float seconds);
	public static void ClearWaitForSeconds();
}

