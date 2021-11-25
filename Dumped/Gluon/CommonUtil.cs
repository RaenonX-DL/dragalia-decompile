using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonUtil
	{
		public class FontSetting
		{
			public class MyPage
			{
				public static Color blackFontColor;

				public static Color whiteFontColor;

				public static Color blackOutlineColor;
			}

			public class Growth
			{
				public static Color blackFontColor;

				public static Color whiteFontColor;

				public static Color blackOutlineColor;
			}

			public class Party
			{
				public static Color blackFontColor;

				public static Color whiteFontColor;

				public static Color blackOutlineColor;
			}

			public class Fort
			{
				public static Color blackFontColor;

				public static Color whiteFontColor;

				public static Color blackOutlineColor;
			}

			public class Summon
			{
				public static Color blackFontColor;

				public static Color whiteFontColor;

				public static Color blackOutlineColor;
			}

			public static Color commonWhiteFontColor;

			public static Color commonBlackFontColor;

			public static Color warningRedFontColor;

			public static Color highlightFontColor;

			public static Color invalidFontColor;

			public static Color invalidOutlineFontColor;

			public static Color positiveFontColor;

			public static Color negativeFontColor;

			public static Color grayOutFontOrImageColor;

			public static Color blackMaskImageColor;

			public static float normalFontSize;

			public static float smallFontSize;

			public static float titleFontSize;

			public static float buttonFontSize;

			public const string dragonFont = "Fonts/DFG-KoInn-W5";

			public static Font GetDragonFont()
			{
				return null;
			}
		}

		public class DialogPanelColor
		{
			public class MyPage
			{
				public static Color mainPanelColor;

				public static Color baseColor;
			}

			public class Growth
			{
				public static Color mainPanelColor;

				public static Color baseColor;
			}

			public class Party
			{
				public static Color mainPanelColor;

				public static Color baseColor;
			}

			public class Fort
			{
				public static Color mainPanelColor;

				public static Color baseColor;
			}

			public class Summon
			{
				public static Color mainPanelColor;

				public static Color baseColor;
			}

			public class RequiredItem
			{
				public static Color insufficientTextColor;

				public static Color insufficientRequiredColor;

				public static Color insufficientHavingColor;
			}
		}

		public const string prefAmuletTradeLastNewDate = "pref_AmuletTradeLastNewDate";

		public const int newIconLastingDays = 10;

		public static bool isEnteredFromBootScene;

		private const string REPLACE_PLAYER_NAME = "{player_name}";

		public static readonly TimeSpan dateCheckSpan;

		public static long lastLoginDate;

		public static long tutorialSummonLastLoginDate;

		public static float disableBrightness;

		public static float normalBrightness;

		public static string midpoint;

		public const string delayPressedStateParameterName = "DelayPressedState";

		public const string triggerDelayPressTriggerName = "DelayPressReleased";

		public const int dailyUpdateHourOffsetInUTC = -6;

		private static Dictionary<int, DateTime> dictCampaignStartDate;

		private static Dictionary<int, DateTime> dictCampaignEndDate;

		private static Dictionary<string, DateTime> dateStrUtcDict;

		private static DateTime serverTimeForFort;

		public static DateTime ServerUtcNowForFort
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public static void InjectDelayPressedStateForCell(GameObject cell)
		{
		}

		public static void SetSpriteByMaterialPath(Graphic image, string materialPath)
		{
		}

		public static void SetIconSpriteByGiftId(Graphic image, GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int limitOver = 0)
		{
		}

		public static void SetSpriteByMaterial(Graphic image, Material mat)
		{
		}

		public static void SetSpriteByMaterialAndTexture(Image image, Material mat, Texture2D tex)
		{
		}

		public static void OverrideImageSprite(Image image, string path, [Optional] string materialPath)
		{
		}

		public static void OverrideImageSprite(Image image, Texture2D tex, [Optional] Material mat)
		{
		}

		public static Material LoadMaterialOnCache(string path)
		{
			return null;
		}

		public static void SetEnableColorForAtlasMaterial(Button button, bool enable, bool adjustBrightness = true, bool withChildren = true, bool isPreIn = false, [Optional] List<GameObject> ignoreSetColorChildren, bool createNewMaterial = false)
		{
		}

		public static bool IsMaterialAlphaA8(Material mat)
		{
			return default(bool);
		}

		public static void SetEnableColorForAtlasMaterial(GameObject obj, bool enable, bool adjustBrightness = true, bool withChildren = true, bool isPreIn = false, [Optional] List<GameObject> ignoreSetColorChildren, bool createNewMaterial = false)
		{
		}

		public static void SetNormalColorForAtlasMaterial(GameObject obj, bool withChildren = true)
		{
		}

		public static void SetEnableColorForMaterialA8(Button button, bool enable, bool withChildren = true, bool isPreIn = false, [Optional] List<GameObject> ignoreSetColorChildren, bool createNewMaterial = false)
		{
		}

		public static void SetEnableColorForMaterialA8(GameObject obj, bool enable, bool adjustBrightness = true, bool withChildren = true, bool isPreIn = false, [Optional] List<GameObject> ignoreSetColorChildren, bool createNewMaterial = false)
		{
		}

		public static void SetColorModulusForAtlasMaterial(Image image, float ev, bool isAtlas)
		{
		}

		public static float GetColorModulus(Material imageMaterial)
		{
			return default(float);
		}

		public static void SetEnableColorForIconMaterial(Image image, bool enable)
		{
		}

		public static void SetColorToImageAndText(GameObject root, Color color)
		{
		}

		public static T LoadPrefabAndAddToTransform<T>(string prefabPath, Transform parent, bool resetLocalTransform = true)
		{
			return (T)null;
		}

		public static GameObject LoadPrefabAndAddToTransform(string prefabPath, Transform parent, bool resetLocalTransform = true)
		{
			return null;
		}

		public static T InstantiateObject<T>(GameObject prefab, Transform parent, bool resetLocalTransform = true)
		{
			return (T)null;
		}

		public static void DestroyChildren(Transform t)
		{
		}

		public static void DestroyImmediateChildren(Transform t)
		{
		}

		public static Transform FindChildRecursively(Transform parent, string childName)
		{
			return null;
		}

		public static void StartEnterScene(MonoBehaviour sceneObject, Action onEnterScene, [Optional] Action onPrevSceneTransitionDone, [Optional] Action onReadyForAsyncLoad, [Optional] GameObject asyncLoadGreenLightObject)
		{
		}

		private static IEnumerator EnterSceneCoroutine(Action onEnterScene, Action onPrevSceneTransitionDone, Action onReadyForHttpRequest, GameObject httpGreenLight)
		{
			return null;
		}

		public static void StartAutoLoadIndexFromDebugCommand(Action onEnterScene, bool enterSceneDirectly = false)
		{
		}

		public static void StartAutoLoadIndex(Action onEnterScene, bool enterSceneDirectly = false)
		{
		}

		public static void StartAutoLoadIndexImpl(Action onEnterScene, bool enterSceneDirectly = false)
		{
		}

		public static Transform FindNode(Transform current, string name)
		{
			return null;
		}

		public static int GetLayerIndexFromCullingMask(int cullingMask)
		{
			return default(int);
		}

		public static void SetLayerRecursively(GameObject obj, int layer, bool findAndSetAttachEffect = false)
		{
		}

		public static DateTime GetServerLocalNow()
		{
			return default(DateTime);
		}

		public static double ConvertToUnixTimestamp(DateTime date)
		{
			return default(double);
		}

		public static string ReplacePlayerName(string baseString)
		{
			return null;
		}

		public static string UnixTimeToString(double unixtime, bool bDateOnly)
		{
			return null;
		}

		public static long FromUtcToUnixTime(string utcStr)
		{
			return default(long);
		}

		public static bool IsWithinUnixTimePeriod(long beginTime, long endTime)
		{
			return default(bool);
		}

		public static DateTime DateTimeCutOffToSecond(DateTime dt)
		{
			return default(DateTime);
		}

		public static void ClearCache()
		{
		}

		private static bool TryGetDateTime(Dictionary<int, DateTime> dictDate, int id, string dateStr, out DateTime dateTime)
		{
			return default(bool);
		}

		private static bool TryGetCampaignStartDate(CampaignDataElement campaign, out DateTime startDate)
		{
			return default(bool);
		}

		private static bool TryGetCampaignEndDate(CampaignDataElement campaign, out DateTime endDate)
		{
			return default(bool);
		}

		public static bool IsWithinPeriod(CampaignDataElement campaign, DateTime now)
		{
			return default(bool);
		}

		public static bool IsWithinPeriod(string startDateStr, string endDateStr)
		{
			return default(bool);
		}

		public static bool IsWithinPeriod(string startDateStr, string endDateStr, DateTime time)
		{
			return default(bool);
		}

		public static long CheckDate(long unixTime = -1L)
		{
			return default(long);
		}

		public static long GetTotalWeeks(long unixTime = -1L)
		{
			return default(long);
		}

		public static long GetTotalMonths(long unixTime = -1L)
		{
			return default(long);
		}

		public static bool IsDateChanged()
		{
			return default(bool);
		}

		public static bool IsDateChangedTutorialSummon()
		{
			return default(bool);
		}

		public static string FormatNewLineCode(string str)
		{
			return null;
		}

		public static string RemoveNewLineCode(string str)
		{
			return null;
		}

		public static string FormatArgsColorTagWithUnit(string str, string color, string unit, bool isRemoveUnitInStr = false)
		{
			return null;
		}

		public static string RemoveFormatString(string str)
		{
			return null;
		}

		public static void Swap<T>(ref T lhs, ref T rhs)
		{
		}

		public static int Digit(int num)
		{
			return default(int);
		}

		public static int CeilToInt(float fparam, float digits = 3f)
		{
			return default(int);
		}

		public static void QuitAndroidApplication()
		{
		}

		public static bool ReplaceMainCharacterName(ref string charaName, int masterId, [Optional] string usePlayerName)
		{
			return default(bool);
		}

		public static string ReplaceMainCharacterName(string charaName, int masterId, [Optional] string usePlayerName)
		{
			return null;
		}

		public static void CreatePhotonErrorPopup([Optional] Action<MultiPlayError.ErrorType> onClose, bool isErrorPopupCanvas = false)
		{
		}

		public static string GetCharaBaseIdStr(int charaId)
		{
			return null;
		}

		public static bool isActiveChara(int charaId)
		{
			return default(bool);
		}

		public static bool isActiveEventAbility(int AbilityId)
		{
			return default(bool);
		}

		public static bool CheckTemporaryCharaInParty(bool useCommonCallback = true)
		{
			return default(bool);
		}

		public static bool CheckTemporaryCharaInParty(int partyIndex, bool useCommonCallback = true)
		{
			return default(bool);
		}

		private static bool CheckTemporaryCharaInParty(bool useCommonCallback, PartyList party)
		{
			return default(bool);
		}

		public static int GetActiveCharaCount()
		{
			return default(int);
		}

		public static DateTime GetResetTimeLocal()
		{
			return default(DateTime);
		}

		public static DateTime GetResetTimeUtc()
		{
			return default(DateTime);
		}

		public static DateTime GetResetTimeUtc(DateTime baseTime)
		{
			return default(DateTime);
		}

		public static DateTime GetResetTimeUtc(int day, int hour)
		{
			return default(DateTime);
		}

		public static DateTime GetWeeklyResetTimeUtc()
		{
			return default(DateTime);
		}

		public static DateTime GetWeeklyResetTimeUtc(DateTime baseTime)
		{
			return default(DateTime);
		}

		private static DateTime GetDayOfWeekResetTime(DayOfWeek dayOfWeek)
		{
			return default(DateTime);
		}

		public static DateTime GetBeforeDayOfWeekResetTime(DayOfWeek dayOfWeek)
		{
			return default(DateTime);
		}

		public static DateTime CalcAggregatePeriodEndDate(DateTime startAggregateTime, int periodDays)
		{
			return default(DateTime);
		}

		public static List<string> GetReleaseDayOfWeek(QuestGroupIntervalType type)
		{
			return null;
		}

		public static string GetReleaseDayOfWeekString(QuestGroupIntervalType type)
		{
			return null;
		}

		public static void SetTextAutoFontResizeWhenHeightExceeded(Text text, string textStr, Vector2 baseSizeDelta, [Optional] ContentSizeFitter fitter)
		{
		}

		public static DownloadOperation GetDownloadOperation(HashSet<string> hashSet)
		{
			return null;
		}

		public static DownloadOperation GetDownloadOperation(int[] group, HashSet<string> hashSet)
		{
			return null;
		}

		public static string GetDownloadResourceSizeText(long baseByte, Localize.TextId textIdGB = Localize.TextId.DownLoadAboutGigaByteFormat, Localize.TextId textIdMB = Localize.TextId.DownLoadAboutMegaByteFormat)
		{
			return null;
		}

		public static IEnumerator StartDownload(DownloadOperation downloadOperation, UnityAction completeCallback)
		{
			return null;
		}

		public static DownloadPopup CreateBeforePrologueDownloadPopup(DownloadOperation downloadOperation)
		{
			return null;
		}

		public static DownloadPopup CreateNeedBeforePrologueDownloadToPlayPopup(DownloadOperation downloadOperation)
		{
			return null;
		}

		public static SelectableDownloadPopup CreateSelectableAddDownloadConfirmPopup(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, TitleScene titleScene, long deletedSize = 0L)
		{
			return null;
		}

		public static SelectableDownloadPopup CreateNeedSelectableAddDownloadToPlayPopup(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, TitleScene titleScene, long deletedSize = 0L)
		{
			return null;
		}

		public static SelectableDownloadPopup CreateQuestStoryDownloadConfirmPopup(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice)
		{
			return null;
		}

		public static void DownloadQuestResource(int questId, int questAssetParam, UnityAction onCompleted, [Optional] UnityAction beforeDownload, [Optional] UnityAction onCancelled)
		{
		}

		public static void DownloadStoryResource(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, UnityAction onCompleted)
		{
		}

		public static void DownloadNonStoryVoice(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, UnityAction onCompleted, UnityAction onCompletedWithoutDownloading, UnityAction onCanceled)
		{
		}

		public static void DispNonStoryVoiceWarning(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, UnityAction onCompletedWarning, UnityAction onCompletedWithoutWarning)
		{
		}

		public static void DownloadTargetData(DownloadOperation downloadOperation, UnityAction onCompleted, UnityAction onCanceled)
		{
		}

		public static CommonPopup CreateTargetDataDeleteComfirmPopup(string deleteTitleText, string deleteBodyText, List<int> targetGroups, string deleteCompleteTitleText, string deleteCompleteBodyText, Func<string, bool> filteringAssetsFunc, Action<bool> onDone, MonoBehaviour parent)
		{
			return null;
		}

		private static IEnumerator DeleteTargetData(HashSet<string> targetAssets, string titleText, string bodyText, Action<bool> onDone)
		{
			return null;
		}

		public static void SetDefaultLightProbeParam(GameObject obj)
		{
		}

		public static void SetDefaultLightProbeParam(Material mat)
		{
		}

		public static bool CanTrade(int itemId)
		{
			return default(bool);
		}

		public static bool HasFlag(int value, int flag)
		{
			return default(bool);
		}

		public static Dictionary<int, int> GetNeedGrowItemCount(ulong exp, GrowthBaseType type)
		{
			return null;
		}

		public static int GetPlusMaterialId(MaterialType type)
		{
			return default(int);
		}

		public static void ReloadCurrentScene()
		{
		}

		public static bool HasNewItemInAmuletTrade()
		{
			return default(bool);
		}

		public static bool IsPickupAmuletTrade(AbilityCrestTradeElement crest)
		{
			return default(bool);
		}

		public static bool IsShowingNewIconForAmuletCell(AbilityCrestTradeElement crest)
		{
			return default(bool);
		}

		public static bool isActiveEventAbilityCrest(int crestId)
		{
			return default(bool);
		}

		public static IEnumerator CreateListCellsCoroutine<T>(TableViewController<T> tableViewController, int limitCreateCellCount = 5)
		{
			return null;
		}

		public static IEnumerator SetIconImageInText(string orgStr, List<RectTransform> iconParentRectList, Text iconInText, LocalizeTextLayoutPadding textPadding, Text forCalcText, bool changeResolution = false)
		{
			return null;
		}

		public static bool IsDuplicateAbilityCrest(int crestId1, int crestId2)
		{
			return default(bool);
		}

		public static bool IsDuplicateAbilityCrestBaseId(int crestId1, int crestId2)
		{
			return default(bool);
		}

		public static bool IsIncludingDuplicateAbilityCrestByActivePartyData([Optional] Action afterClosePopupAction)
		{
			return default(bool);
		}

		public static bool IsIncludingDuplicateAbilityCrestByPartyList(PartyList partyInfo, [Optional] Action afterClosePopupAction)
		{
			return default(bool);
		}

		public static void CheckAndRemoveDuplicateAbilityCrestInParty()
		{
		}
	}
}
