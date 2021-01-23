/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool
{
	// Nested types
	public enum RawPcmFormat
	{
		Sint16 = 0,
		Float32 = 1
	}

	protected struct RawPcmPlayerConfig
	{
		// Fields
		public RawPcmFormat format;
		public int maxChannels;
		public int maxSamplingRate;
		public int soundRendererType;
		public int decodeLatency;
	}

	protected struct RawPcmVoicePoolConfig
	{
		// Fields
		public uint identifier;
		public int numVoices;
		public RawPcmPlayerConfig playerConfig;
	}

	// Constructors
	public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0);

	// Methods
	private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size);
}

