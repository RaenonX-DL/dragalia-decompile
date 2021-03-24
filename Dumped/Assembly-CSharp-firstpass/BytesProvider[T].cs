/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class BytesProvider<T> : IBytesProvider<T>
{
	// Fields
	private Func<T, byte[]> _conversion;

	// Properties
	public static BytesProvider<T> Default { get; }

	// Constructors
	internal BytesProvider(Func<T, byte[]> conversion);

	// Methods
	public byte[] GetBytes(T value);
}

