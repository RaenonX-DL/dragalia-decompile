using System;

public class CriAtomExWaveVoicePool : CriAtomExVoicePool
{
	public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0u)
	{
	}

	private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size);
}
