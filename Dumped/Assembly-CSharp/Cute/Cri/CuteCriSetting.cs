/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public static class CuteCriSetting
	{
		// Fields
		[CompilerGenerated]
		private static bool _IsInitialized_k__BackingField;
		private static CriWareInitializer criWareInitializer;
		[CompilerGenerated]
		private static CriAtom _CriAtom_k__BackingField;
		private const string DefaultDspBusSettingName = "DspBusSetting_0";
		private const int DEFAULT_BUFFER_SIZE = 133;
		private const int DEFAULT_START_TIME = 100;
		private static readonly BufferSetting[] bufferSettingTable;
	
		// Properties
		public static bool IsInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static CriAtom CriAtom { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private struct BufferSetting
		{
			// Fields
			[CompilerGenerated]
			private string _DeviceModel_k__BackingField;
			[CompilerGenerated]
			private int _BufferSize_k__BackingField;
			[CompilerGenerated]
			private int _StartTime_k__BackingField;
	
			// Properties
			public string DeviceModel { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int BufferSize { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int StartTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public BufferSetting(string deviceModel, int bufferSize, int startTime);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<BufferSetting> __9__14_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SetBufferSetting_b__14_0(BufferSetting item);
		}
	
		// Constructors
		static CuteCriSetting();
	
		// Methods
		public static void Initialize(string criWareLibraryInitializerPrefabPath, bool useMcDsp = false);
		public static void RegisterAcf(string acfFile);
		public static void AttachDspBusSetting(string dspBusSetting);
		private static GameObject Instantiate(string prefabPath);
		private static void SetBufferSetting();
		public static int GetNumberOfBinders();
	}
}
