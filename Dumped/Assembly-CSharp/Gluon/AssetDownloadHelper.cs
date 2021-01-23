/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class AssetDownloadHelper
	{
		// Fields
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
		private static string[] dragonPaths_StoryImage;
		private static string[] firstDownloadDragonIds;
		private static string[] afterProloguePreinAssetPaths;
		private static string[] afterPrologueNotPreinAssetPaths;
		private static string[] unlockedFortAssetPaths_notLocalized;
		private static string[] myPage3dUnlockedFortAssetPaths_notLocalized;
		private static string[] myPage3dAssetPaths_notLocalized;
		private static string[] myPage3dAssetExcludedPhrases_notLocalized;
		private static string[] volatileAssetPaths;
		private static string[] previouslySearchedAssetStartPaths;
		private static Dictionary<string, HashSet<string>> previouslySearchedAssetList;
		[CompilerGenerated]
		private static bool _IsSkipVoiceDownload_k__BackingField;
	
		// Properties
		public static bool IsSkipVoiceDownload { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public class ExcludedAssetInfo
		{
			// Fields
			private string excludedPath;
			private List<string> notExcludedPathList;
	
			// Constructors
			public ExcludedAssetInfo(string path);
	
			// Methods
			public void RegisterNotExcludedPaths(string[] notExcludedPaths);
			public bool Contains(string name);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public AssetBundleManifest manifest;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal bool _GetAssetsByGroup_b__0(string item);
			internal string _GetAssetsByGroup_b__1(string hash);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public AssetBundleManifest manifest;
			public HashSet<string> hashes;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal bool _DeleteAssets_b__0(string name, TimeSpan timeSpan);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public HashSet<string> targetAssets;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal bool _DeleteAssets_b__0(string name);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public HashSet<string> targetAssets;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal bool _CalcAssetDataSize_b__0(string name);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__60_1;
			public static Action<DownloadErrorType, string> __9__60_0;
			public static Func<string, string> __9__61_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GetQuestAssetsDownloadOperation_b__60_0(DownloadErrorType type, string error);
			internal void _GetQuestAssetsDownloadOperation_b__60_1();
			internal string _GetQuestAssets_b__61_0(string path);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public int randomAreaId;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal bool _GetQuestAssets_b__1(RandomFloorDataElement data);
		}
	
		// Constructors
		static AssetDownloadHelper();
	
		// Methods
		public static HashSet<string> GetPrologueAssets(string LocalizedSoundParentPath = "");
		public static string[] GetUnlockedFortAssetsNotLocalized();
		public static bool IsMyPage3dAfterPrologueAsset(string assetBundleName);
		public static bool IsMyPage3dUnlockedFortAsset(string assetBundleName);
		public static bool IsLocalizedMyPage3dAsset(string assetBundleName);
		public static void Initialize(bool withSetupNames = false);
		public static HashSet<string> GetSuitableAssetPathList(string startStr);
		public static string[] GetCurrentVariantSettings();
		public static List<string> GetDownloadAssetsAfterPrologue(bool isPrein, string localizedSoundParentPath = "");
		public static List<string> GetCharaAssetsForStory(string idStr);
		public static List<string> GetDragonAssetsForStory(string idStr);
		public static string GetEventCgAssetForStory(string eventName, string idStr);
		public static List<string> GetAssets(string startStr, string localizedSoundParentPath = "", bool includesVoice = true);
		private static bool IsLocalizedSoundStartStr(string startStr);
		private static List<string> GetAssets(string startStr, HashSet<string> names, string localizedSoundParentPath = "", bool includesVoice = true);
		public static void GetAssetsByGroup(int[] groups, HashSet<string> assets, bool withoutVoice);
		public static void DeleteAssetsOnBoot();
		public static void DeleteAssets(int[] groups);
		public static bool IsVolatileAsset(string assetBundleName);
		public static void DeleteAllQuestAssets();
		public static void DeletetClearedMainQuestAssets();
		private static HashSet<string> GetQuestUniqueAssets(HashSet<int> questIdList);
		private static HashSet<string> GetGroupAssetNames(List<int> groups, bool withDependencies = true);
		private static void DeleteQuestAssets(HashSet<int> targetQuestIdList, HashSet<int> reservedQuestIdList = null);
		public static HashSet<string> GetActiveMemoryEventAssets();
		public static bool IsEssentialUnclockedFortAssets(int tutorialStep);
		public static void ExceptEssentialAssets(ref HashSet<string> targetQuestAssets);
		public static HashSet<string> GetStoryVoiceAssetNames();
		public static HashSet<string> GetNonStoryVoiceAssetNames();
		private static bool IsEnableToDeleteMyPage3dAssets(string target);
		public static HashSet<string> GetMyPage3dAssetNames(bool withDependencies);
		public static HashSet<string> GetMyPage3dVoiceAssetNames(bool withDependencies);
		public static HashSet<string> GetTargetGroupsAssetNames(List<int> targetGroups, bool withDependencies);
		public static HashSet<string> GetDeleteQuestAndStoryTargetAll();
		public static HashSet<string> CollectQuestAssets(HashSet<int> targetQuestIdList, HashSet<int> reservedQuestIdList);
		public static void DeleteAssets(HashSet<string> targetAssets);
		public static long CalcAssetDataSize(HashSet<string> targetAssets);
		public static DownloadOperation GetQuestAssetsDownloadOperation(int questId, int param = 0);
		public static string[] GetQuestAssets(int questId, int param, Func<int, HashSet<string>> getStoryAssetsFunc = null);
		public static string[] GetCuttAssets(string name, bool includesVoice);
		public static string GetLocalizedSoundParentPath();
		public static int[] GetPrologueGroups();
		public static int[] GetAfterPrologueGroups();
		public static int[] GetUnlockedFortGroups();
		public static int[] GetUnlockedFortOnPlayingGroups();
		public static int[] GetLocalizedVoiceGroups(bool forceDownloadLocalizedMyPage3d = false);
		public static int[] GetVoiceDownloadGroups(bool forceDownloadDataInAdvance = false);
		public static int[] GetMyPage3dVoiceGroups(bool forceTragetingOnLocalizedMyPage3d = false);
		public static int[] GetMyPage3dGroups(bool forceTragetingOnLocalizedMyPage3d = false);
		private static void AddFullDownloadAdditionalGroups(List<int> groups, bool withVoice, bool forceDownloadQuestDataInAdvance = false);
		public static int[] GetFullDownloadGroups(bool forceDownloadDataInAdvance = false);
		public static int[] GetFullDownloadGroupsExceptVoice(bool forceDownloadQuestDataInAdvance = false);
		public static int GetMemoryEventGroup(int eventId);
	}
}
