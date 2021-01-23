/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class OutGameSoundUtil
	{
		// Fields
		private const string questResultBgm = "BGM_OUT_0004_01";
		private const string clb01QuestResultBgm = "BGM_CLB_01_OUT_0002_01";
		private const string exHunterQuestResultBgm = "BGM_EX_HUNTER_01_OUT_0004_01";
		private const string clb01SoundGroup = "CLB_01_OUT_COMMON";
		private const string exRushSoundGroup = "EX_RUSH_01_OUT_COMMON";
		private const string exHunterSoundGroup = "EX_Hunter_01_OUT_COMMON";
		private const string outQuestGroup = "OUT_QUEST";
		private const string clb01QuestStartSound = "SE_CLB_01_OUT_COMMON_0003";
		private const string exRushQuestStartSound = "SE_EX_RUSH_01_OUT_COMMON_0002";
		private const string exHunterQuestStartSound = "SE_EX_HUNTER_01_OUT_COMMON_0004";
		private static readonly Dictionary<string, string> clb01SoundReplaceDict;
		private static readonly Dictionary<string, string> exRushSoundReplaceDict;
		private static readonly Dictionary<string, string> exHunterSoundReplaceDict;
		private static readonly string summonUpdateBgm;
		private static readonly Dictionary<int, string> clb01SummonUpdateBgms;
		private static readonly Dictionary<int, string> clb01SummonUpdateBgmGroups;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static SoundManager.ReplaceCueName __9__23_0;
			public static SoundManager.ReplaceCueName __9__23_1;
			public static SoundManager.ReplaceCueName __9__23_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _RegisterCrossOverCommonSoundReplacer_b__23_0(ref string cueName);
			internal void _RegisterCrossOverCommonSoundReplacer_b__23_1(ref string cueName);
			internal void _RegisterCrossOverCommonSoundReplacer_b__23_2(ref string cueName);
		}
	
		// Constructors
		static OutGameSoundUtil();
	
		// Methods
		public static void PlaySummonUpdateBgm(int eventType);
		public static void PlayQuestResultBgm(EventKindType eventType);
		public static void LoadCrossOverSoundGroup(EventKindType eventType);
		public static void LoadCrossOverSoundGroup(int summonId);
		public static void ReleaseCrossOverSoundGroup(EventKindType eventType, bool delay = true);
		public static void ReleaseCrossOverSoundGroup(int summonId);
		public static void PlayCrossOverQuestStartSound(EventKindType eventType);
		public static void RegisterCrossOverCommonSoundReplacer(EventKindType eventType);
		public static void RemoveCrossOverCommonSoundReplacer();
	}
}
