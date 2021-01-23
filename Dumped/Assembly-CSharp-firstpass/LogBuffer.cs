/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class LogBuffer
{
	// Fields
	public const int KB = 1024;
	public const int InternalBufSize = 16384;
	public byte[] Buf;
	public int BufSize;
	public int BufWrittenBytes;

	// Constructors
	public LogBuffer(int userDefinedSize = 0);

	// Methods
	public bool Receive(string content);
	public void Clear();
}

