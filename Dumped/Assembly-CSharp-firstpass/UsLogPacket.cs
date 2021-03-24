/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsLogPacket
{
	// Fields
	public const int MAX_CONTENT_LEN = 1024;
	public const int MAX_CALLSTACK_LEN = 1024;
	public ushort SeqID;
	public UsLogType LogType;
	public string Content;
	public float RealtimeSinceStartup;
	public string Callstack;

	// Constructors
	public UsLogPacket();
	public UsLogPacket(UsCmd c);

	// Methods
	public UsCmd CreatePacket();
}

