/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public abstract class CriAtomExVoicePool : CriDisposable
{
	// Fields
	public const int StandardMemoryAsrVoicePoolId = 0;
	public const int StandardStreamingAsrVoicePoolId = 1;
	public const int StandardMemoryNsrVoicePoolId = 2;
	public const int StandardStreamingNsrVoicePoolId = 3;
	protected IntPtr _handle;
	protected uint _identifier;
	protected int _numVoices;
	protected int _maxChannels;
	protected int _maxSamplingRate;

	// Properties
	public IntPtr nativeHandle { get; }
	public uint identifier { get; }
	public int numVoices { get; }
	public int maxChannels { get; }
	public int maxSamplingRate { get; }

	// Nested types
	public enum VoicePoolId
	{
		StandardMemory = 0,
		StandardStreaming = 1,
		LowLatencyMemory = 2,
		LowLatencyStreaming = 3,
		HcaMxMemory = 4,
		HcaMxStreaming = 5
	}

	public enum PitchShifterMode
	{
		Music = 0,
		Vocal = 1,
		SoundEffect = 2,
		Speech = 3
	}

	public struct UsedVoicesInfo
	{
		// Fields
		public int numUsedVoices;
		public int numPoolVoices;
	}

	protected struct PlayerConfig
	{
		// Fields
		public int maxChannels;
		public int maxSamplingRate;
		public bool streamingFlag;
		public int soundRendererType;
		public int decodeLatency;
	}

	protected struct VoicePoolConfig
	{
		// Fields
		public uint identifier;
		public int numVoices;
		public PlayerConfig playerConfig;
	}

	private struct PitchShifterConfig
	{
		// Fields
		public int mode;
		public int windowSize;
		public int overlapTimes;
	}

	private struct ExPitchShifterConfig
	{
		// Fields
		public int numDsp;
		public int maxChannels;
		public int maxSamplingRate;
		public PitchShifterConfig config;
	}

	private struct TimeStretchConfig
	{
		// Fields
		public int reserved;
	}

	private struct ExTimeStretchConfig
	{
		// Fields
		public int numDsp;
		public int maxChannels;
		public int maxSamplingRate;
		public TimeStretchConfig config;
	}

	// Constructors
	protected CriAtomExVoicePool();

	// Methods
	public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId);
	public override void Dispose();
	public UsedVoicesInfo GetNumUsedVoices();
	public void AttachDspTimeStretch();
	public void AttachDspPitchShifter(PitchShifterMode mode = PitchShifterMode.Music, int windosSize = 1024, int overlapTimes = 4);
	public void DetachDsp();
	~CriAtomExVoicePool();
	private static extern void CRIWARE967C97CC(int voice_pool_id, out int num_used_voices, out int num_pool_voices);
	private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices);
	public static extern void criAtomExVoicePool_Free(IntPtr pool);
	private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size);
	private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size);
	private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool);
}

