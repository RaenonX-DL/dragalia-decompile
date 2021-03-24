/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class LogEventArgs : EventArgs
{
	// Fields
	public int SeqID;
	public LogType LogType;
	public string Content;
	public string Stacktrace;
	public float Time;

	// Constructors
	public LogEventArgs(int seqID, LogType type, string content, string stacktrace, float time);
}

