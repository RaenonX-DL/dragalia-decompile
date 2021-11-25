using System;
using System.Runtime.InteropServices;

public static class CriAtomExCategory
{
	public enum ReactType
	{
		Ducker,
		AisacModulationTrigger
	}

	public enum ReactDuckerTargetType
	{
		Volume,
		AisacControlValue
	}

	public enum ReactDuckerCurveType
	{
		Linear,
		Square,
		SquareReverse,
		SCurve,
		FlatAtHalf
	}

	public struct ReactFadeParameter
	{
		public ReactDuckerCurveType curveType;

		public float curveStrength;

		public ushort fadeTimeMs;
	}

	public enum ReactHoldType
	{
		WhilePlaying,
		FixedTime
	}

	public struct ReactDuckerParameter
	{
		public struct Volume
		{
			public float level;
		}

		public struct AisacControl
		{
			public ushort id;

			public float value;
		}

		[StructLayout(2)]
		public struct Target
		{
			public Volume volume;

			public AisacControl aisacControl;
		}

		public Target target;

		public ReactDuckerTargetType targetType;

		public ReactFadeParameter entry;

		public ReactFadeParameter exit;

		public ReactHoldType holdType;

		public ushort holdTimeMs;
	}

	public struct ReactAisacModulationParameter
	{
		public bool enableDecrementAisacModulationKey;

		public uint decrementAisacModulationKey;

		public bool enableIncrementAisacModulationKey;

		public uint incrementAisacModulationKey;
	}

	public struct ReactParameter
	{
		[StructLayout(2)]
		public struct Parameter
		{
			public ReactDuckerParameter ducker;

			public ReactAisacModulationParameter aisacModulation;
		}

		public Parameter parameter;

		public ReactType type;

		public bool enablePausingCue;
	}

	public static void SetVolume(string name, float volume)
	{
	}

	public static void SetVolume(int id, float volume)
	{
	}

	public static float GetVolume(string name)
	{
		return default(float);
	}

	public static float GetVolume(int id)
	{
		return default(float);
	}

	public static void Mute(string name, bool mute)
	{
	}

	public static void Mute(int id, bool mute)
	{
	}

	public static bool IsMuted(string name)
	{
		return default(bool);
	}

	public static bool IsMuted(int id)
	{
		return default(bool);
	}

	public static void Solo(string name, bool solo, float muteVolume)
	{
	}

	public static void Solo(int id, bool solo, float muteVolume)
	{
	}

	public static bool IsSoloed(string name)
	{
		return default(bool);
	}

	public static bool IsSoloed(int id)
	{
		return default(bool);
	}

	public static void Pause(string name, bool pause)
	{
	}

	public static void Pause(int id, bool pause)
	{
	}

	public static bool IsPaused(string name)
	{
		return default(bool);
	}

	public static bool IsPaused(int id)
	{
		return default(bool);
	}

	public static void SetAisacControl(string name, string controlName, float value)
	{
	}

	[Obsolete]
	public static void SetAisac(string name, string controlName, float value)
	{
	}

	public static void SetAisacControl(int id, int controlId, float value)
	{
	}

	[Obsolete]
	public static void SetAisac(int id, int controlId, float value)
	{
	}

	public static void SetReactParameter(string name, ReactParameter parameter)
	{
	}

	public static bool GetReactParameter(string name, out ReactParameter parameter)
	{
		return default(bool);
	}

	public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
	{
		return default(bool);
	}

	public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
	{
		return default(bool);
	}

	private static extern void criAtomExCategory_SetVolumeByName(string name, float volume);

	private static extern float criAtomExCategory_GetVolumeByName(string name);

	private static extern void criAtomExCategory_SetVolumeById(int id, float volume);

	private static extern float criAtomExCategory_GetVolumeById(int id);

	private static extern void criAtomExCategory_MuteById(int id, bool mute);

	private static extern bool criAtomExCategory_IsMutedById(int id);

	private static extern void criAtomExCategory_MuteByName(string name, bool mute);

	private static extern bool criAtomExCategory_IsMutedByName(string name);

	private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume);

	private static extern bool criAtomExCategory_IsSoloedById(int id);

	private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume);

	private static extern bool criAtomExCategory_IsSoloedByName(string name);

	private static extern void criAtomExCategory_PauseById(int id, bool pause);

	private static extern bool criAtomExCategory_IsPausedById(int id);

	private static extern void criAtomExCategory_PauseByName(string name, bool pause);

	private static extern bool criAtomExCategory_IsPausedByName(string name);

	private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value);

	private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value);

	private static extern void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter);

	private static extern bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter);

	private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo);

	private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo);
}
