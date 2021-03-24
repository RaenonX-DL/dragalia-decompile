/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomEx
{
	// Fields
	public const uint InvalidAisacControlId = 65535;
	public static SoundRendererType androidDefaultSoundRendererType;

	// Nested types
	public enum CharacterEncoding
	{
		Utf8 = 0,
		Sjis = 1
	}

	public enum SoundRendererType
	{
		Default = 0,
		Native = 1,
		Hw1 = 1,
		Asr = 2,
		Hw2 = 9
	}

	public enum VoiceAllocationMethod
	{
		Once = 0,
		Retry = 1
	}

	public enum BiquadFilterType
	{
		Off = 0,
		LowPass = 1,
		HighPass = 2,
		Notch = 3,
		LowShelf = 4,
		HighShelf = 5,
		Peaking = 6
	}

	public enum ResumeMode
	{
		AllPlayback = 0,
		PausedPlayback = 1,
		PreparedPlayback = 2
	}

	public enum PanType
	{
		Pan3d = 0,
		Pos3d = 1,
		Auto = 2
	}

	public enum VoiceControlMethod
	{
		PreferLast = 0,
		PreferFirst = 1
	}

	public enum Parameter
	{
		Volume = 0,
		Pitch = 1,
		Pan3dAngle = 2,
		Pan3dDistance = 3,
		Pan3dVolume = 4,
		BusSendLevel0 = 9,
		BusSendLevel1 = 10,
		BusSendLevel2 = 11,
		BusSendLevel3 = 12,
		BusSendLevel4 = 13,
		BusSendLevel5 = 14,
		BusSendLevel6 = 15,
		BusSendLevel7 = 16,
		BandPassFilterCofLow = 17,
		BandPassFilterCofHigh = 18,
		BiquadFilterType = 19,
		BiquadFilterFreq = 20,
		BiquadFIlterQ = 21,
		BiquadFilterGain = 22,
		EnvelopeAttackTime = 23,
		EnvelopeHoldTime = 24,
		EnvelopeDecayTime = 25,
		EnvelopeReleaseTime = 26,
		EnvelopeSustainLevel = 27,
		StartTime = 28,
		Priority = 31
	}

	public enum Speaker
	{
		FrontLeft = 0,
		FrontRight = 1,
		FrontCenter = 2,
		LowFrequency = 3,
		SurroundLeft = 4,
		SurroundRight = 5,
		SurroundBackLeft = 6,
		SurroundBackRight = 7
	}

	public enum Format : uint
	{
		ADX = 1,
		HCA = 3,
		HCA_MX = 4,
		WAVE = 5,
		RAW_PCM = 6
	}

	public struct FormatInfo
	{
		// Fields
		public Format format;
		public int samplingRate;
		public long numSamples;
		public long loopOffset;
		public long loopLength;
		public int numChannels;
		public uint reserved;
	}

	public struct AisacControlInfo
	{
		// Fields
		public readonly string name;
		public uint id;

		// Constructors
		public AisacControlInfo(byte[] data, int startIndex);
	}

	public struct CuePos3dInfo
	{
		// Fields
		public float coneInsideAngle;
		public float coneOutsideAngle;
		public float minAttenuationDistance;
		public float maxAttenuationDistance;
		public float sourceRadius;
		public float interiorDistance;
		public float dopplerFactor;
		public ushort distanceAisacControl;
		public ushort listenerBaseAngleAisacControl;
		public ushort sourceBaseAngleAisacControl;
		public ushort[] reserved;

		// Constructors
		public CuePos3dInfo(byte[] data, int startIndex);
	}

	public struct GameVariableInfo
	{
		// Fields
		public readonly string name;
		public uint id;
		public float gameValue;

		// Constructors
		public GameVariableInfo(byte[] data, int startIndex);
		public GameVariableInfo(string name, uint id, float gameValue);
	}

	public enum CueType
	{
		Polyphonic = 0,
		Sequential = 1,
		Shuffle = 2,
		Random = 3,
		RandomNoRepeat = 4,
		SwitchGameVariable = 5,
		ComboSequential = 6,
		SwitchSelector = 7,
		TrackTransitionBySelector = 8
	}

	public struct CueInfo
	{
		// Fields
		public int id;
		public CueType type;
		public readonly string name;
		public readonly string userData;
		public long length;
		public ushort[] categories;
		public short numLimits;
		public ushort numBlocks;
		public ushort numTracks;
		public ushort[] reserved;
		public byte priority;
		public byte headerVisibility;
		public byte ignore_player_parameter;
		public byte probability;
		public CuePos3dInfo pos3dInfo;
		public GameVariableInfo gameVariableInfo;

		// Constructors
		public CueInfo(byte[] data, int startIndex);
	}

	public struct WaveformInfo
	{
		// Fields
		public int waveId;
		public uint format;
		public int samplingRate;
		public int numChannels;
		public long numSamples;
		public bool streamingFlag;
		public uint[] reserved;

		// Constructors
		public WaveformInfo(byte[] data, int startIndex);
	}

	public struct AisacInfo
	{
		// Fields
		public readonly string name;
		public bool defaultControlFlag;
		public float defaultControlValue;
		public uint controlId;
		public readonly string controlName;

		// Constructors
		public AisacInfo(byte[] data, int startIndex);
	}

	public struct PerformanceInfo
	{
		// Fields
		public uint serverProcessCount;
		public uint lastServerTime;
		public uint maxServerTime;
		public uint averageServerTime;
		public uint lastServerInterval;
		public uint maxServerInterval;
		public uint averageServerInterval;
	}

	public struct ResourceUsage
	{
		// Fields
		public uint useCount;
		public uint limit;
	}

	// Constructors
	static CriAtomEx();

	// Methods
	public static void RegisterAcf(CriFsBinder binder, string acfPath);
	public static void RegisterAcf(byte[] acfData);
	public static void UnregisterAcf();
	public static void AttachDspBusSetting(string settingName);
	public static void DetachDspBusSetting();
	public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms);
	public static int GetNumGameVariables();
	public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info);
	public static float GetGameVariable(uint game_variable_id);
	public static float GetGameVariable(string game_variable_name);
	public static void SetGameVariable(uint game_variable_id, float game_variable_value);
	public static void SetGameVariable(string game_variable_name, float game_variable_value);
	public static void SetRandomSeed(uint seed);
	public static void ResetPerformanceMonitor();
	public static void GetPerformanceInfo(out PerformanceInfo info);
	public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index);
	public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name);
	public static void SetOutputVolume_VITA(float volume);
	public static bool IsBgmPortAcquired_VITA();
	public static bool IsSoundStopped_IOS();
	private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize);
	private static extern void criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize);
	private static extern void criAtomEx_UnregisterAcf();
	private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize);
	private static extern void criAtomEx_DetachDspBusSetting();
	private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms);
	private static extern int criAtomEx_GetNumGameVariables();
	private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info);
	private static extern float criAtomEx_GetGameVariableById(uint game_variable_id);
	private static extern float criAtomEx_GetGameVariableByName(string game_variable_name);
	private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value);
	private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value);
	private static extern void criAtomEx_SetRandomSeed(uint seed);
	private static extern void criAtom_ResetPerformanceMonitor();
	private static extern void criAtom_GetPerformanceInfo(out PerformanceInfo info);
	private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index);
	private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name);
	public static extern void criAtom_EnableSlLatencyCheck_ANDROID(bool sw);
	public static extern int criAtom_GetSlBufferConsumptionLatency_ANDROID();
}

