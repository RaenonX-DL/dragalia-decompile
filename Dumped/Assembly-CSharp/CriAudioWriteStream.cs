/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAudioWriteStream
{
	// Fields
	private InternalDelegate internalDelegate;
	[CompilerGenerated]
	private IntPtr _callbackFunction_k__BackingField;
	[CompilerGenerated]
	private IntPtr _callbackPointer_k__BackingField;

	// Properties
	public IntPtr callbackFunction { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public IntPtr callbackPointer { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Nested types
	[UnmanagedFunctionPointer]
	private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples);

	public delegate uint Delegate(float[][] buffer, uint numSamples);

	[CompilerGenerated]
	private sealed class __c__DisplayClass12_0
	{
		// Fields
		public int bufferSize;
		public int numChannels;
		public Delegate callback;

		// Constructors
		public __c__DisplayClass12_0();
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass12_1
	{
		// Fields
		public float[][] buffer;
		public __c__DisplayClass12_0 CS___8__locals1;

		// Constructors
		public __c__DisplayClass12_1();

		// Methods
		internal uint _.ctor_b__0(IntPtr cbobj, IntPtr data, uint numSamples);
	}

	// Constructors
	public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer);
	public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256);
}

