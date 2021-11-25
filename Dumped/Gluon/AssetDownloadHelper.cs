using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.AssetBundle;

namespace Gluon
{
	public static class AssetDownloadHelper
	{
		public class ExcludedAssetInfo
		{
			private string excludedPath;

			private List<string> notExcludedPathList;

			public ExcludedAssetInfo(string path)
			{
			}

			public void RegisterNotExcludedPaths(string[] notExcludedPaths)
			{
			}

			public bool Contains(string name)
			{
				return default(bool);
			}
		}

		public const string saveVoiceAsset = "SaveVoiceAsset";

		public const string allVoiceDownloaded = "AllVoiceDownloaded";

		public const string downloadQuestDataInAdvance = "DownloadQuestDataInAdvance";

		public const string changeMyPageModeTo2d = "ChangeMyPageModeTo2d";

		public const string downloadMyPage3dDataInAdvance = "DownloadMyPage3dDataInAdvance";

		private static HashSet<string> allAssetBundleNames;

		private static string[] dungeonPaths;

		private static string[] prologueAssets_notLocalized;

		private static string[] storyPaths;

		private static string[] characterPaths_StoryImage;

		private static string[] firstDownloadCharaIds;

		private static string[] afterPrologueDownloadCharaIds;

		private static string[] dragonPaths_StoryImage;

		private static string[] firstDownloadDragonIds;

		private static string[] afterPrologueDownloadDragonIds;

		private static string[] afterProloguePreinAssetPaths;

		private static string[] afterPrologueNotPreinAssetPaths;

		private static string[] unlockedFortAssetPaths_notLocalized;

		private static string[] myPage3dUnlockedFortAssetPaths_notLocalized;

		private static string[] myPage3dAssetPaths_notLocalized;

		private static string[] myPage3dAssetExcludedPhrases_notLocalized;

		private static string[] volatileAssetPaths;

		private static string[] previouslySearchedAssetStartPaths;

		private static Dictionary<string, HashSet<string>> previouslySearchedAssetList;

		private static string defaultLocalizedSoundParentPath;

		public static bool IsSkipVoiceDownload
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static HashSet<string> GetPrologueAssets(string LocalizedSoundParentPath = "")
		{
			return null;
		}

		public static List<string> GetPrologueCharaDragonIdList()
		{
			return null;
		}

		public static HashSet<string> GetAfterPrologueAssetPaths(string LocalizedSoundParentPath = "")
		{
			return null;
		}

		public static string[] GetUnlockedFortAssetsNotLocalized()
		{
			return null;
		}

		public static bool IsMyPage3dAfterPrologueAsset(string assetBundleName)
		{
			return default(bool);
		}

		public static bool IsMyPage3dUnlockedFortAsset(string assetBundleName)
		{
			return default(bool);
		}

		public static bool IsLocalizedMyPage3dAsset(string assetBundleName)
		{
			return default(bool);
		}

		public static void Initialize(bool withSetupNames = false)
		{
		}

		public static HashSet<string> GetSuitableAssetPathList(string startStr)
		{
			return null;
		}

		public static string[] GetCurrentVariantSettings()
		{
			return null;
		}

		public static List<string> GetDownloadAssetsAfterPrologue(bool isPrein, string localizedSoundParentPath = "")
		{
			return null;
		}

		public static List<string> GetCharaAssetsForStory(string idStr)
		{
			return null;
		}

		public static List<string> GetDragonAssetsForStory(string idStr)
		{
			return null;
		}

		public static string GetEventCgAssetForStory(string eventName, string idStr)
		{
			return null;
		}

		public static List<string> GetAssets(string startStr, string localizedSoundParentPath = "", bool includesVoice = true)
		{
			return null;
		}

		private static bool IsLocalizedSoundStartStr(string startStr)
		{
			return default(bool);
		}

		private static List<string> GetAssets(string startStr, HashSet<string> names, string localizedSoundParentPath = "", bool includesVoice = true)
		{
			return null;
		}

		public static int[] GetGroupsInDiaryStory(bool withVoice)
		{
			return null;
		}

		public static void GetAssetsByGroup(int[] groups, HashSet<string> assets, bool withoutVoice)
		{
		}

		public static void DeleteAssetsOnBoot()
		{
		}

		public static void DeleteGroups(int[] groups)
		{
		}

		public static bool IsVolatileAsset(string assetBundleName)
		{
			return default(bool);
		}

		public static void DeleteAllQuestAssets()
		{
		}

		public static void DeletetClearedMainQuestAssets()
		{
		}

		private static HashSet<string> GetQuestUniqueAssets(HashSet<int> questIdList)
		{
			return null;
		}

		private static HashSet<string> GetGroupAssetNames(List<int> groups, bool withDependencies = true)
		{
			return null;
		}

		private static void DeleteQuestAssets(HashSet<int> targetQuestIdList, [Optional] HashSet<int> reservedQuestIdList)
		{
		}

		public static HashSet<string> GetActiveMemoryEventAssets(bool withVoice)
		{
			return null;
		}

		public static bool IsEssentialUnclockedFortAssets(int tutorialStep)
		{
			return default(bool);
		}

		public static void ExceptEssentialAssets(ref HashSet<string> targetQuestAssets)
		{
		}

		public static HashSet<string> GetStoryVoiceAssetNames()
		{
			return null;
		}

		public static HashSet<string> GetNonStoryVoiceAssetNames()
		{
			return null;
		}

		private static bool IsEnableToDeleteMyPage3dAssets(string target)
		{
			return default(bool);
		}

		public static HashSet<string> GetMyPage3dAssetNames(bool withDependencies)
		{
			return null;
		}

		public static HashSet<string> GetMyPage3dVoiceAssetNames(bool withDependencies)
		{
			return null;
		}

		public static HashSet<string> GetTargetGroupsAssetNames(List<int> targetGroups, bool withDependencies)
		{
			return null;
		}

		public static HashSet<string> GetDeleteQuestAndStoryTargetAll()
		{
			return null;
		}

		public static HashSet<string> CollectQuestAssets(HashSet<int> targetQuestIdList, HashSet<int> reservedQuestIdList)
		{
			return null;
		}

		public static void DeleteAssets(HashSet<string> targetAssets)
		{
		}

		public static long CalcAssetDataSize(HashSet<string> targetAssets)
		{
			return default(long);
		}

		public static DownloadOperation GetQuestAssetsDownloadOperation(int questId, int param = 0)
		{
			return null;
		}

		public static string[] GetQuestAssets(int questId, int param, [Optional] Func<int, HashSet<string>> getStoryAssetsFunc)
		{
			return null;
		}

		public static string[] GetCuttAssets(string name, bool includesVoice)
		{
			return null;
		}

		public static string GetLocalizedSoundParentPath()
		{
			return null;
		}

		public static int[] GetPrologueGroups()
		{
			return null;
		}

		public static int[] GetAfterPrologueGroups()
		{
			return null;
		}

		public static int[] GetUnlockedFortGroups()
		{
			return null;
		}

		public static int[] GetUnlockedFortOnPlayingGroups()
		{
			return null;
		}

		public static int[] GetLocalizedVoiceGroups(bool forceDownloadLocalizedMyPage3d = false)
		{
			return null;
		}

		public static int[] GetVoiceDownloadGroups(bool forceDownloadDataInAdvance = false)
		{
			return null;
		}

		public static int[] GetMyPage3dVoiceGroups(bool forceTragetingOnLocalizedMyPage3d = false)
		{
			return null;
		}

		public static int[] GetMyPage3dGroups(bool forceTragetingOnLocalizedMyPage3d = false)
		{
			return null;
		}

		private static void AddFullDownloadAdditionalGroups(List<int> groups, bool withVoice, bool forceDownloadQuestDataInAdvance = false)
		{
		}

		public static int[] GetFullDownloadGroups(bool forceDownloadDataInAdvance = false)
		{
			return null;
		}

		public static int[] GetFullDownloadGroupsExceptVoice(bool forceDownloadQuestDataInAdvance = false)
		{
			return null;
		}

		private static int GetMemoryEventGroup(int eventId)
		{
			return default(int);
		}

		private static int GetMemoryEventDiaryStoryGroup(int eventId)
		{
			return default(int);
		}

		private static int[] GetMemoryEventDiaryStoryWithVoiceGroupArray(int diaryGroup, bool withVoice)
		{
			return null;
		}

		public static int[] GetMemoryEventGroupArray(int eventId, bool withVoice)
		{
			return null;
		}
	}
}
