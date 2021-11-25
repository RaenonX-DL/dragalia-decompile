using System;

[Serializable]
public class CriAtomConfig
{
	[Serializable]
	public class StandardVoicePoolConfig
	{
		public int memoryVoices;

		public int streamingVoices;
	}

	[Serializable]
	public class HcaMxVoicePoolConfig
	{
		public int memoryVoices;

		public int streamingVoices;
	}

	public enum LinuxOutput
	{
		Default,
		PulseAudio,
		ALSA
	}

	[Serializable]
	public class AndroidLowLatencyStandardVoicePoolConfig
	{
		public int memoryVoices;

		public int streamingVoices;
	}

	[Serializable]
	public class VitaManaVoicePoolConfig
	{
		public int numberOfManaDecoders;
	}

	[Serializable]
	public class VitaAtrac9VoicePoolConfig
	{
		public int memoryVoices;

		public int streamingVoices;
	}

	[Serializable]
	public class Ps4Atrac9VoicePoolConfig
	{
		public int memoryVoices;

		public int streamingVoices;
	}

	[Serializable]
	public class Ps4Audio3dConfig
	{
		[Serializable]
		public class VoicePoolConfig
		{
			public int memoryVoices;

			public int streamingVoices;
		}

		public bool useAudio3D;

		public VoicePoolConfig voicePoolConfig;
	}

	[Serializable]
	public class WebGLWebAudioVoicePoolConfig
	{
		public int voices;
	}

	public string acfFileName;

	public int maxVirtualVoices;

	public int maxVoiceLimitGroups;

	public int maxCategories;

	public int maxSequenceEventsPerFrame;

	public int maxBeatSyncCallbacksPerFrame;

	public StandardVoicePoolConfig standardVoicePoolConfig;

	public HcaMxVoicePoolConfig hcaMxVoicePoolConfig;

	public int outputSamplingRate;

	public bool usesInGamePreview;

	public float serverFrequency;

	public int asrOutputChannels;

	public bool useRandomSeedWithTime;

	public int categoriesPerPlayback;

	public int maxBuses;

	public int maxParameterBlocks;

	public bool vrMode;

	public int pcBufferingTime;

	public LinuxOutput linuxOutput;

	public int iosBufferingTime;

	public bool iosOverrideIPodMusic;

	public int androidBufferingTime;

	public int androidStartBufferingTime;

	public AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig;

	public bool androidUsesAndroidFastMixer;

	public bool androidForceToUseAsrForDefaultPlayback;

	public VitaManaVoicePoolConfig vitaManaVoicePoolConfig;

	public VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig;

	public Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig;

	public Ps4Audio3dConfig ps4Audio3dConfig;

	public WebGLWebAudioVoicePoolConfig webglWebAudioVoicePoolConfig;
}
