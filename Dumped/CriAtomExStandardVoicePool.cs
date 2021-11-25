using System;

public class CriAtomExStandardVoicePool : CriAtomExVoicePool
{
	public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0u)
	{
	}

	private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size);
}
