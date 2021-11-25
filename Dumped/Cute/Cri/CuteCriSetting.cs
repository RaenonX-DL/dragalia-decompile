using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cute.Cri
{
	public static class CuteCriSetting
	{
		private struct BufferSetting
		{
			public string DeviceModel
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

			public int BufferSize
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int StartTime
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public BufferSetting(string deviceModel, int bufferSize, int startTime)
			{
			}
		}

		private static CriWareInitializer criWareInitializer;

		private const string DefaultDspBusSettingName = "DspBusSetting_0";

		private const int DEFAULT_BUFFER_SIZE = 133;

		private const int DEFAULT_START_TIME = 100;

		private static readonly BufferSetting[] bufferSettingTable;

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

		private static void SetBufferSetting()
		{
		}

		public static int GetNumberOfBinders()
		{
			return default(int);
		}
	}
}
