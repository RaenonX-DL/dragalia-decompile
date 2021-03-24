/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[Serializable]
public class CriAtomConfig
{
	// Fields
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

	// Nested types
	[Serializable]
	public class StandardVoicePoolConfig
	{
		// Fields
		public int memoryVoices;
		public int streamingVoices;

		// Constructors
		public StandardVoicePoolConfig();
	}

	[Serializable]
	public class HcaMxVoicePoolConfig
	{
		// Fields
		public int memoryVoices;
		public int streamingVoices;

		// Constructors
		public HcaMxVoicePoolConfig();
	}

	public enum LinuxOutput
	{
		Default = 0,
		PulseAudio = 1,
		ALSA = 2
	}

	[Serializable]
	public class AndroidLowLatencyStandardVoicePoolConfig
	{
		// Fields
		public int memoryVoices;
		public int streamingVoices;

		// Constructors
		public AndroidLowLatencyStandardVoicePoolConfig();
	}

	[Serializable]
	public class VitaManaVoicePoolConfig
	{
		// Fields
		public int numberOfManaDecoders;

		// Constructors
		public VitaManaVoicePoolConfig();
	}

	[Serializable]
	public class VitaAtrac9VoicePoolConfig
	{
		// Fields
		public int memoryVoices;
		public int streamingVoices;

		// Constructors
		public VitaAtrac9VoicePoolConfig();
	}

	[Serializable]
	public class Ps4Atrac9VoicePoolConfig
	{
		// Fields
		public int memoryVoices;
		public int streamingVoices;

		// Constructors
		public Ps4Atrac9VoicePoolConfig();
	}

	[Serializable]
	public class Ps4Audio3dConfig
	{
		// Fields
		public bool useAudio3D;
		public VoicePoolConfig voicePoolConfig;

		// Nested types
		[Serializable]
		public class VoicePoolConfig
		{
			// Fields
			public int memoryVoices;
			public int streamingVoices;

			// Constructors
			public VoicePoolConfig();
		}

		// Constructors
		public Ps4Audio3dConfig();
	}

	[Serializable]
	public class WebGLWebAudioVoicePoolConfig
	{
		// Fields
		public int voices;

		// Constructors
		public WebGLWebAudioVoicePoolConfig();
	}

	// Constructors
	public CriAtomConfig();
}

