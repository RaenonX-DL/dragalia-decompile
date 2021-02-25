/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Core;
using Gluon.Master;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonUtil
	{
		// Fields
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
	
		// Properties
		public static DateTime ServerUtcNowForFort { get; set; }
	
		// Nested types
		public class FontSetting
		{
			// Fields
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
	
			// Nested types
			public class MyPage
			{
				// Fields
				public static Color blackFontColor;
				public static Color whiteFontColor;
				public static Color blackOutlineColor;
	
				// Constructors
				public MyPage();
				static MyPage();
			}
	
			public class Growth
			{
				// Fields
				public static Color blackFontColor;
				public static Color whiteFontColor;
				public static Color blackOutlineColor;
	
				// Constructors
				public Growth();
				static Growth();
			}
	
			public class Party
			{
				// Fields
				public static Color blackFontColor;
				public static Color whiteFontColor;
				public static Color blackOutlineColor;
	
				// Constructors
				public Party();
				static Party();
			}
	
			public class Fort
			{
				// Fields
				public static Color blackFontColor;
				public static Color whiteFontColor;
				public static Color blackOutlineColor;
	
				// Constructors
				public Fort();
				static Fort();
			}
	
			public class Summon
			{
				// Fields
				public static Color blackFontColor;
				public static Color whiteFontColor;
				public static Color blackOutlineColor;
	
				// Constructors
				public Summon();
				static Summon();
			}
	
			// Constructors
			public FontSetting();
			static FontSetting();
	
			// Methods
			public static Font GetDragonFont();
		}
	
		public class DialogPanelColor
		{
			// Nested types
			public class MyPage
			{
				// Fields
				public static Color mainPanelColor;
				public static Color baseColor;
	
				// Constructors
				public MyPage();
				static MyPage();
			}
	
			public class Growth
			{
				// Fields
				public static Color mainPanelColor;
				public static Color baseColor;
	
				// Constructors
				public Growth();
				static Growth();
			}
	
			public class Party
			{
				// Fields
				public static Color mainPanelColor;
				public static Color baseColor;
	
				// Constructors
				public Party();
				static Party();
			}
	
			public class Fort
			{
				// Fields
				public static Color mainPanelColor;
				public static Color baseColor;
	
				// Constructors
				public Fort();
				static Fort();
			}
	
			public class Summon
			{
				// Fields
				public static Color mainPanelColor;
				public static Color baseColor;
	
				// Constructors
				public Summon();
				static Summon();
			}
	
			public class RequiredItem
			{
				// Fields
				public static Color insufficientTextColor;
				public static Color insufficientRequiredColor;
				public static Color insufficientHavingColor;
	
				// Constructors
				public RequiredItem();
				static RequiredItem();
			}
	
			// Constructors
			public DialogPanelColor();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public Animator animator;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _InjectDelayPressedStateForCell_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public MonoBehaviour sceneObject;
			public Action onEnterScene;
			public Action onPrevSceneTransitionDone;
			public Action onReadyForAsyncLoad;
			public GameObject asyncLoadGreenLightObject;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _StartEnterScene_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__40_0;
			public static Func<bool> __9__97_0;
			public static Func<bool> __9__109_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _EnterSceneCoroutine_b__40_0();
			internal bool _StartDownload_b__97_0();
			internal bool _DeleteTargetData_b__109_2();
		}
	
		[CompilerGenerated]
		private sealed class _EnterSceneCoroutine_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action onReadyForHttpRequest;
			public Action onPrevSceneTransitionDone;
			public GameObject httpGreenLight;
			public Action onEnterScene;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnterSceneCoroutine_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public CommonPopup popup;
			public Action<MultiPlayError.ErrorType> onClose;
			public MultiPlayError.ErrorType type;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _CreatePhotonErrorPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public DownloadOperation retOeration;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass94_0();
	
			// Methods
			internal void _GetDownloadOperation_b__0(DownloadErrorType type, string error);
			internal void _GetDownloadOperation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public DownloadOperation retOeration;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass95_0();
	
			// Methods
			internal void _GetDownloadOperation_b__0(DownloadErrorType type, string error);
			internal void _GetDownloadOperation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0
		{
			// Fields
			public NowLoadingCanvas nowloading;
	
			// Constructors
			public __c__DisplayClass97_0();
	
			// Methods
			internal bool _StartDownload_b__1();
			internal bool _StartDownload_b__2();
			internal bool _StartDownload_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _StartDownload_d__97 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadOperation downloadOperation;
			private __c__DisplayClass97_0 __8__1;
			public UnityAction completeCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartDownload_d__97(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_0
		{
			// Fields
			public DownloadOperation downloadOperation;
	
			// Constructors
			public __c__DisplayClass98_0();
	
			// Methods
			internal void _CreateBeforePrologueDownloadPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0
		{
			// Fields
			public DownloadOperation downloadOperation;
	
			// Constructors
			public __c__DisplayClass99_0();
	
			// Methods
			internal void _CreateNeedBeforePrologueDownloadToPlayPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public UnityAction beforeDownload;
			public DownloadOperation downloadOperation;
			public UnityAction onCompleted;
			public UnityAction onCancelled;
	
			// Constructors
			public __c__DisplayClass103_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_1
		{
			// Fields
			public DownloadPopup popup;
			public __c__DisplayClass103_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass103_1();
	
			// Methods
			internal void _DownloadQuestResource_b__0();
			internal void _DownloadQuestResource_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass104_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public UnityAction onCompleted;
			public DownloadOperation downloadOperationWithoutVoice;
	
			// Constructors
			public __c__DisplayClass104_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass104_1
		{
			// Fields
			public DownloadPopup popup;
			public __c__DisplayClass104_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass104_1();
	
			// Methods
			internal void _DownloadStoryResource_b__0();
			internal void _DownloadStoryResource_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass104_2
		{
			// Fields
			public SelectableDownloadPopup popup;
			public __c__DisplayClass104_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass104_2();
	
			// Methods
			internal void _DownloadStoryResource_b__2();
			internal void _DownloadStoryResource_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public UnityAction onCompleted;
			public UnityAction onCanceled;
	
			// Constructors
			public __c__DisplayClass105_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_1
		{
			// Fields
			public DownloadPopup popup;
			public __c__DisplayClass105_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass105_1();
	
			// Methods
			internal void _DownloadNonStoryVoice_b__0();
			internal void _DownloadNonStoryVoice_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass106_0
		{
			// Fields
			public UnityAction onCompletedWarning;
	
			// Constructors
			public __c__DisplayClass106_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass106_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass106_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass106_1();
	
			// Methods
			internal void _DispNonStoryVoiceWarning_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public UnityAction onCompleted;
			public UnityAction onCanceled;
	
			// Constructors
			public __c__DisplayClass107_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_1
		{
			// Fields
			public DownloadPopup popup;
			public __c__DisplayClass107_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass107_1();
	
			// Methods
			internal void _DownloadTargetData_b__0();
			internal void _DownloadTargetData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass108_0
		{
			// Fields
			public CommonPopup popup;
			public MonoBehaviour parent;
			public HashSet<string> filterdAssets;
			public string deleteCompleteTitleText;
			public string deleteCompleteBodyText;
			public Action<bool> onDone;
	
			// Constructors
			public __c__DisplayClass108_0();
	
			// Methods
			internal void _CreateTargetDataDeleteComfirmPopup_b__0();
			internal void _CreateTargetDataDeleteComfirmPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass109_0
		{
			// Fields
			public HashSet<string> targetAssets;
			public CommonPopup popup;
			public Action<bool> onDone;
	
			// Nested types
			private struct __DeleteTargetData_b__1_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass109_0 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass109_0();
	
			// Methods
			internal void _DeleteTargetData_b__0();
			internal async void _DeleteTargetData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _DeleteTargetData_d__109 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HashSet<string> targetAssets;
			public Action<bool> onDone;
			private __c__DisplayClass109_0 __8__1;
			public string titleText;
			public string bodyText;
			private ParallelJob _job_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DeleteTargetData_d__109(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CreateListCellsCoroutine_d__121<T> : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TableViewController<T> tableViewController;
			public int limitCreateCellCount;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateListCellsCoroutine_d__121(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetIconImageInText_d__123 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string orgStr;
			public UnityEngine.UI.Text iconInText;
			public Graphic icon;
			public bool changeResolution;
			public LocalizeTextLayoutPadding textPadding;
			private string _str_5__2;
			private string[] _strLines_5__3;
			private int _iconLine_5__4;
			private float _strHeadWidth_5__5;
			private string _blankStr_5__6;
			private float _strBlankWidth_5__7;
			private float _strWidth_5__8;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetIconImageInText_d__123(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CommonUtil();
		static CommonUtil();
	
		// Methods
		public static void InjectDelayPressedStateForCell(GameObject cell);
		public static void SetSpriteByMaterialPath(Graphic image, string materialPath);
		public static void SetIconSpriteByGiftId(Graphic image, GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int limitOver = 0);
		public static void SetSpriteByMaterial(Graphic image, Material mat);
		public static void SetSpriteByMaterialAndTexture(Image image, Material mat, Texture2D tex);
		public static void OverrideImageSprite(Image image, string path, string materialPath = null);
		public static void OverrideImageSprite(Image image, Texture2D tex, Material mat = null);
		public static Material LoadMaterialOnCache(string path);
		public static void SetEnableColorForAtlasMaterial(Button button, bool enable, bool adjustBrightness = true, bool withChildren = true, bool isPreIn = false, List<GameObject> ignoreSetColorChildren = null, bool createNewMaterial = false);
		public static bool IsMaterialAlphaA8(Material mat);
		public static void SetEnableColorForAtlasMaterial(GameObject obj, bool enable, bool adjustBrightness = true, bool withChildren = true, bool isPreIn = false, List<GameObject> ignoreSetColorChildren = null, bool createNewMaterial = false);
		public static void SetNormalColorForAtlasMaterial(GameObject obj, bool withChildren = true);
		public static void SetEnableColorForMaterialA8(Button button, bool enable, bool withChildren = true, bool isPreIn = false, List<GameObject> ignoreSetColorChildren = null, bool createNewMaterial = false);
		public static void SetEnableColorForMaterialA8(GameObject obj, bool enable, bool adjustBrightness = true, bool withChildren = true, bool isPreIn = false, List<GameObject> ignoreSetColorChildren = null, bool createNewMaterial = false);
		public static void SetColorModulusForAtlasMaterial(Image image, float ev, bool isAtlas);
		public static float GetColorModulus(Material imageMaterial);
		public static void SetEnableColorForIconMaterial(Image image, bool enable);
		public static void SetColorToImageAndText(GameObject root, Color color);
		public static T LoadPrefabAndAddToTransform<T>(string prefabPath, Transform parent, bool resetLocalTransform = true);
		public static GameObject LoadPrefabAndAddToTransform(string prefabPath, Transform parent, bool resetLocalTransform = true);
		public static T InstantiateObject<T>(GameObject prefab, Transform parent, bool resetLocalTransform = true);
		public static void DestroyChildren(Transform t);
		public static void DestroyImmediateChildren(Transform t);
		public static Transform FindChildRecursively(Transform parent, string childName);
		public static void StartEnterScene(MonoBehaviour sceneObject, Action onEnterScene, Action onPrevSceneTransitionDone = null, Action onReadyForAsyncLoad = null, GameObject asyncLoadGreenLightObject = null);
		[IteratorStateMachine]
		private static IEnumerator EnterSceneCoroutine(Action onEnterScene, Action onPrevSceneTransitionDone, Action onReadyForHttpRequest, GameObject httpGreenLight);
		public static void StartAutoLoadIndexFromDebugCommand(Action onEnterScene, bool enterSceneDirectly = false);
		public static void StartAutoLoadIndex(Action onEnterScene, bool enterSceneDirectly = false);
		public static void StartAutoLoadIndexImpl(Action onEnterScene, bool enterSceneDirectly = false);
		public static Transform FindNode(Transform current, string name);
		public static int GetLayerIndexFromCullingMask(int cullingMask);
		public static void SetLayerRecursively(GameObject obj, int layer, bool findAndSetAttachEffect = false);
		public static DateTime GetServerLocalNow();
		public static double ConvertToUnixTimestamp(DateTime date);
		public static string ReplacePlayerName(string baseString);
		public static string UnixTimeToString(double unixtime, bool bDateOnly);
		public static long FromUtcToUnixTime(string utcStr);
		public static bool IsWithinUnixTimePeriod(long beginTime, long endTime);
		public static DateTime DateTimeCutOffToSecond(DateTime dt);
		public static void ClearCache();
		private static bool TryGetDateTime(Dictionary<int, DateTime> dictDate, int id, string dateStr, out DateTime dateTime);
		private static bool TryGetCampaignStartDate(CampaignDataElement campaign, out DateTime startDate);
		private static bool TryGetCampaignEndDate(CampaignDataElement campaign, out DateTime endDate);
		public static bool IsWithinPeriod(CampaignDataElement campaign, DateTime now);
		public static bool IsWithinPeriod(string startDateStr, string endDateStr);
		public static bool IsWithinPeriod(string startDateStr, string endDateStr, DateTime time);
		public static long CheckDate(long unixTime = -1);
		public static long GetTotalWeeks(long unixTime = -1);
		public static long GetTotalMonths(long unixTime = -1);
		public static bool IsDateChanged();
		public static bool IsDateChangedTutorialSummon();
		public static string FormatNewLineCode(string str);
		public static string RemoveNewLineCode(string str);
		public static string FormatArgsColorTagWithUnit(string str, string color, string unit, bool isRemoveUnitInStr = false);
		public static string RemoveFormatString(string str);
		public static void Swap<T>(ref T lhs, ref T rhs);
		public static int Digit(int num);
		public static int CeilToInt(float fparam, float digits = 3f);
		public static void QuitAndroidApplication();
		public static bool ReplaceMainCharacterName(ref string charaName, int masterId, string usePlayerName = null);
		public static string ReplaceMainCharacterName(string charaName, int masterId, string usePlayerName = null);
		public static void CreatePhotonErrorPopup(Action<MultiPlayError.ErrorType> onClose = null, bool isErrorPopupCanvas = false);
		public static string GetCharaBaseIdStr(int charaId);
		public static bool isActiveChara(int charaId);
		public static bool isActiveEventAbility(int AbilityId);
		public static bool CheckTemporaryCharaInParty(bool useCommonCallback = true);
		public static int GetActiveCharaCount();
		public static DateTime GetResetTimeLocal();
		public static DateTime GetResetTimeUtc();
		public static DateTime GetResetTimeUtc(int day, int hour);
		public static DateTime GetWeeklyResetTimeUtc();
		private static DateTime GetDayOfWeekResetTime(DayOfWeek dayOfWeek);
		public static DateTime GetBeforeDayOfWeekResetTime(DayOfWeek dayOfWeek);
		public static List<string> GetReleaseDayOfWeek(QuestGroupIntervalType type);
		public static string GetReleaseDayOfWeekString(QuestGroupIntervalType type);
		public static void SetTextAutoFontResizeWhenHeightExceeded(UnityEngine.UI.Text text, string textStr, Vector2 baseSizeDelta, ContentSizeFitter fitter = null);
		public static DownloadOperation GetDownloadOperation(HashSet<string> hashSet);
		public static DownloadOperation GetDownloadOperation(int[] group, HashSet<string> hashSet);
		public static string GetDownloadResourceSizeText(long baseByte, Localize.TextId textIdGB = Localize.TextId.DownLoadAboutGigaByteFormat, Localize.TextId textIdMB = Localize.TextId.DownLoadAboutMegaByteFormat);
		[IteratorStateMachine]
		public static IEnumerator StartDownload(DownloadOperation downloadOperation, UnityAction completeCallback);
		public static DownloadPopup CreateBeforePrologueDownloadPopup(DownloadOperation downloadOperation);
		public static DownloadPopup CreateNeedBeforePrologueDownloadToPlayPopup(DownloadOperation downloadOperation);
		public static SelectableDownloadPopup CreateSelectableAddDownloadConfirmPopup(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, TitleScene titleScene, long deletedSize = 0);
		public static SelectableDownloadPopup CreateNeedSelectableAddDownloadToPlayPopup(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, TitleScene titleScene, long deletedSize = 0);
		public static SelectableDownloadPopup CreateQuestStoryDownloadConfirmPopup(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice);
		public static void DownloadQuestResource(int questId, int questAssetParam, UnityAction onCompleted, UnityAction beforeDownload = null, UnityAction onCancelled = null);
		public static void DownloadStoryResource(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, UnityAction onCompleted);
		public static void DownloadNonStoryVoice(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, UnityAction onCompleted, UnityAction onCompletedWithoutDownloading, UnityAction onCanceled);
		public static void DispNonStoryVoiceWarning(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, UnityAction onCompletedWarning, UnityAction onCompletedWithoutWarning);
		public static void DownloadTargetData(DownloadOperation downloadOperation, UnityAction onCompleted, UnityAction onCanceled);
		public static CommonPopup CreateTargetDataDeleteComfirmPopup(string deleteTitleText, string deleteBodyText, List<int> targetGroups, string deleteCompleteTitleText, string deleteCompleteBodyText, Func<string, bool> filteringAssetsFunc, Action<bool> onDone, MonoBehaviour parent);
		[IteratorStateMachine]
		private static IEnumerator DeleteTargetData(HashSet<string> targetAssets, string titleText, string bodyText, Action<bool> onDone);
		public static void SetDefaultLightProbeParam(GameObject obj);
		public static void SetDefaultLightProbeParam(Material mat);
		public static bool CanTrade(int itemId);
		public static bool HasFlag(int value, int flag);
		public static Dictionary<int, int> GetNeedGrowItemCount(ulong exp, GrowthBaseType type);
		public static int GetPlusMaterialId(MaterialType type);
		public static void ReloadCurrentScene();
		public static bool HasNewItemInAmuletTrade();
		public static bool IsPickupAmuletTrade(AbilityCrestTradeElement crest);
		public static bool IsShowingNewIconForAmuletCell(AbilityCrestTradeElement crest);
		public static bool isActiveEventAbilityCrest(int crestId);
		[IteratorStateMachine]
		public static IEnumerator CreateListCellsCoroutine<T>(TableViewController<T> tableViewController, int limitCreateCellCount = 5);
		public static void PlaceIconNextToText(Graphic icon, UnityEngine.UI.Text text, float padding = 0f, bool isLeft = true);
		[IteratorStateMachine]
		public static IEnumerator SetIconImageInText(string orgStr, Graphic icon, UnityEngine.UI.Text iconInText, LocalizeTextLayoutPadding textPadding, bool changeResolution = false);
	}
}
