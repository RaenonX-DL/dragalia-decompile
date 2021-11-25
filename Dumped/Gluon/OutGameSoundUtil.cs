using System.Collections.Generic;

namespace Gluon
{
	public static class OutGameSoundUtil
	{
		private const string questResultBgm = "BGM_OUT_0004_01";

		private const string clb01QuestResultBgm = "BGM_CLB_01_OUT_0002_01";

		private const string exHunterQuestResultBgm = "BGM_EX_HUNTER_01_OUT_0004_01";

		private const string clb01SoundGroup = "CLB_01_OUT_COMMON";

		private const string exRushSoundGroup = "EX_RUSH_01_OUT_COMMON";

		private const string exHunterSoundGroup = "EX_Hunter_01_OUT_COMMON";

		private const string exEightSoundGroup = "EX_Eight_01_OUT_COMMON";

		private const string outQuestGroup = "OUT_QUEST";

		private const string clb01QuestStartSound = "SE_CLB_01_OUT_COMMON_0003";

		private const string exRushQuestStartSound = "SE_EX_RUSH_01_OUT_COMMON_0002";

		private const string exHunterQuestStartSound = "SE_EX_HUNTER_01_OUT_COMMON_0004";

		private static readonly Dictionary<string, string> clb01SoundReplaceDict;

		private static readonly Dictionary<string, string> exRushSoundReplaceDict;

		private static readonly Dictionary<string, string> exHunterSoundReplaceDict;

		private static readonly Dictionary<string, string> eightSoundReplaceDict;

		private static readonly string summonUpdateBgm;

		private static readonly Dictionary<int, string> clb01SummonUpdateBgms;

		private static readonly Dictionary<int, string> clb01SummonUpdateBgmGroups;

		public static void PlaySummonUpdateBgm(int eventType)
		{
		}

		public static void PlayQuestResultBgm(EventKindType eventType)
		{
		}

		public static void LoadCrossOverSoundGroup(EventKindType eventType, int eventViewType)
		{
		}

		public static void LoadCrossOverSoundGroup(int summonId)
		{
		}

		public static void ReleaseCrossOverSoundGroup(EventKindType eventType, int eventViewType, bool delay = true)
		{
		}

		public static void ReleaseCrossOverSoundGroup(int summonId)
		{
		}

		public static void PlayCrossOverQuestStartSound(EventKindType eventType)
		{
		}

		public static void RegisterCrossOverCommonSoundReplacer(EventKindType eventType, int eventViewType)
		{
		}

		public static void RemoveCrossOverCommonSoundReplacer()
		{
		}
	}
}
