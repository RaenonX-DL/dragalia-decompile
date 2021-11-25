using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class CriAudioWriteStream
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples);

	public delegate uint Delegate(float[][] buffer, uint numSamples);

	private InternalDelegate internalDelegate;

	public IntPtr callbackFunction
	{
		[CompilerGenerated]
		get
		{
			return default(IntPtr);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IntPtr callbackPointer
	{
		[CompilerGenerated]
		get
		{
			return default(IntPtr);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer)
	{
	}

	public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256)
	{
	}
}
