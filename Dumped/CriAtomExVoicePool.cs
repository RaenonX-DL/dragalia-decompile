using System;

public abstract class CriAtomExVoicePool : CriDisposable
{
	public enum VoicePoolId
	{
		StandardMemory = 0,
		StandardStreaming = 1,
		HcaMxMemory = 4,
		HcaMxStreaming = 5,
		LowLatencyMemory = 2,
		LowLatencyStreaming = 3
	}

	public enum PitchShifterMode
	{
		Music,
		Vocal,
		SoundEffect,
		Speech
	}

	public struct UsedVoicesInfo
	{
		public int numUsedVoices;

		public int numPoolVoices;
	}

	protected struct PlayerConfig
	{
		public int maxChannels;

		public int maxSamplingRate;

		public bool streamingFlag;

		public int soundRendererType;

		public int decodeLatency;
	}

	protected struct VoicePoolConfig
	{
		public uint identifier;

		public int numVoices;

		public PlayerConfig playerConfig;
	}

	private struct PitchShifterConfig
	{
		public int mode;

		public int windowSize;

		public int overlapTimes;
	}

	private struct ExPitchShifterConfig
	{
		public int numDsp;

		public int maxChannels;

		public int maxSamplingRate;

		public PitchShifterConfig config;
	}

	private struct TimeStretchConfig
	{
		public int reserved;
	}

	private struct ExTimeStretchConfig
	{
		public int numDsp;

		public int maxChannels;

		public int maxSamplingRate;

		public TimeStretchConfig config;
	}

	public const int StandardMemoryAsrVoicePoolId = 0;

	public const int StandardStreamingAsrVoicePoolId = 1;

	public const int StandardMemoryNsrVoicePoolId = 2;

	public const int StandardStreamingNsrVoicePoolId = 3;

	protected IntPtr _handle;

	protected uint _identifier;

	protected int _numVoices;

	protected int _maxChannels;

	protected int _maxSamplingRate;

	public IntPtr nativeHandle => default(IntPtr);

	public uint identifier => default(uint);

	public int numVoices => default(int);

	public int maxChannels => default(int);

	public int maxSamplingRate => default(int);

	public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId)
	{
		return default(UsedVoicesInfo);
	}

	public override void Dispose()
	{
	}

	public UsedVoicesInfo GetNumUsedVoices()
	{
		return default(UsedVoicesInfo);
	}

	public void AttachDspTimeStretch()
	{
	}

	public void AttachDspPitchShifter(PitchShifterMode mode = PitchShifterMode.Music, int windosSize = 1024, int overlapTimes = 4)
	{
	}

	public void DetachDsp()
	{
	}

	~CriAtomExVoicePool()
	{
	}

	private static extern void CRIWARE967C97CC(int voice_pool_id, out int num_used_voices, out int num_pool_voices);

	private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices);

	public static extern void criAtomExVoicePool_Free(IntPtr pool);

	private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size);

	private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size);

	private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool);
}
