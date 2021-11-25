using System;
using System.Runtime.CompilerServices;
using CriWare;
using UnityEngine;

namespace Cute.Cri
{
	public static class CuteCriSetting
	{
		private static CriWareInitializer criWareInitializer;

		private const string DefaultDspBusSettingName = "DspBusSetting_0";

		public static bool IsInitialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CriAtom CriAtom
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static int NumberOfBinders => default(int);

		public static int NumberOfDecoders => default(int);

		public static bool UsesAndroidFastMixer => default(bool);

		public static event Action PausePreProcess
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action ResumePostProcess
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void Initialize(string criWareLibraryInitializerPrefabPath, bool useMcDsp = false)
		{
		}

		public static void RegisterAcf(string acfFile)
		{
		}

		public static void AttachDspBusSetting(string dspBusSetting)
		{
		}

		private static GameObject Instantiate(string prefabPath)
		{
			return null;
		}

		private static void RegisterAtomServerPausePrePostProcess()
		{
		}

		private static void AtomServerPausePreProcess(bool pause)
		{
		}

		private static void AtomServerResumePostProcess(bool pause)
		{
		}
	}
}
