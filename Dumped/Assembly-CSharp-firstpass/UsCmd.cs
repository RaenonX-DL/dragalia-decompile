/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsCmd
{
	// Fields
	public const int STRIP_NAME_MAX_LEN = 64;
	public const int BUFFER_SIZE = 16384;
	private int _writeOffset;
	private int _readOffset;
	private byte[] _buffer;

	// Properties
	public byte[] Buffer { get; }
	public int WrittenLen { get; }

	// Constructors
	public UsCmd();
	public UsCmd(byte[] given);

	// Methods
	public object ReadPrimitive<T>();
	public string ReadString();
	public void WritePrimitive<T>(T value);
	public void WriteStringStripped(string value, short stripLen);
	public eNetCmd ReadNetCmd();
	public short ReadInt16();
	public int ReadInt32();
	public float ReadFloat();
	public void WriteNetCmd(eNetCmd cmd);
	public void WriteInt16(short value);
	public void WriteInt32(int value);
	public void WriteFloat(float value);
	public void WriteStringStripped(string value);
	public void WriteString(string value);
}

