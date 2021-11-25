using System;

public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool
{
	public enum RawPcmFormat
	{
		Sint16,
		Float32
	}

	protected struct RawPcmPlayerConfig
	{
		public RawPcmFormat format;

		public int maxChannels;

		public int maxSamplingRate;

		public int soundRendererType;

		public int decodeLatency;
	}

	protected struct RawPcmVoicePoolConfig
	{
		public uint identifier;

		public int numVoices;

		public RawPcmPlayerConfig playerConfig;
	}

	public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0u)
	{
	}

	private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size);
}
