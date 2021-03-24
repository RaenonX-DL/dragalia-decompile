/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsvConsole
{
	// Fields
	public static UsvConsole Instance;
	private Dictionary<string, UsvConsoleCmdHandler> _handlers;

	// Constructors
	public UsvConsole();

	// Methods
	public bool ExecuteCommand(string fullcmd);
}

